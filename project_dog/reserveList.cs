using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace project_dog
{
    public partial class reserveList : Form
    {
        Person person;
        public static string dogId;
        string dogId2;
        public reserveList()
        {
            InitializeComponent();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Text;
            int DogID = int.Parse(dogIdTb.Text);
            person.name = perNameTb.Text;
            person.age = int.Parse(perAgeTb.Text);
            person.sex = perSexTb.Text;
            person.pohneNum = perNumTb.Text;
            person.address = perAddressTb.Text;
            
            try
            {
                Program.con.Open();

                string perInQuery = string.Format("INSERT INTO adop_per (name, age, sex, phone, 주소) values('{0}',{1},'{2}','{3}','{4}') ", person.name, person.age, person.sex, person.pohneNum, person.address);
                string reserInQuery = string.Format("INSERT INTO reservation(입양자, DogID, Phone, date) values('{0}',{1},'{2}','{3}')", person.name, DogID, person.pohneNum, date);
                string phoneCheckQuery = string.Format("SELECT name from adop_per WHERE Phone = '{0}'", person.pohneNum);
                MySqlCommand perInCmd = new MySqlCommand(perInQuery, Program.con);
                MySqlCommand reserInCmd = new MySqlCommand(reserInQuery, Program.con);
                MySqlCommand phoneCheckCmd = new MySqlCommand(phoneCheckQuery, Program.con);

                MySqlDataReader rdr = phoneCheckCmd.ExecuteReader();

                if (rdr.Read())
                {
                    //이미 분양 예약자 테이블에 존재하는 사람이 또 예약하는 경우
                    if ((string)rdr["name"] == person.name)
                    {
                        //분양 예약 테이블에만 데이터 삽입
                        if(reserInCmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("분양 예약 등록 완료");
                            dateTimePicker1.Value = DateTime.Now;
                            dogIdTb.Text = null;
                            perNameTb.Text = null;
                            perAgeTb.Text = null;
                            perSexTb = null;
                            perNumTb.Text = null;
                            perAddressTb.Text = null;
                        }
                    }
                }
                //첫 분양 예약자 - 분양 예약자, 분양 예약 데이터 모두 삽입
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string setDogIdTb
        {
            set { dogIdTb.Text = value; }
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnDogSel_Click(object sender, EventArgs e)
        {
            dogSel dogSel = new dogSel(this);
            dogSel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
