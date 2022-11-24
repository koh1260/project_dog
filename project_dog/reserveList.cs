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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project_dog
{
    public partial class reserveList : Form
    {
        string searchVal = "Phone";
        Person person = new Person();
        public reserveList()
        {
            InitializeComponent();
            manCb.Checked = true;
            numCb.Checked = true;
            adminName.Text = "관리자: " + Program.id;
            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Text;
            int? DogID = int.Parse(dogIdTb.Text);
            person.name = perNameTb.Text;
            person.age = int.Parse(perAgeTb.Text);
            person.pohneNum = perNumTb.Text;
            person.address = perAddressTb.Text;

            try
            {
                Program.con.Open();

                string perInQuery = string.Format("INSERT INTO adop_per (name, age, sex, phone, 주소) values('{0}',{1},'{2}','{3}','{4}') ", person.name, person.age, person.sex, person.pohneNum, person.address);
                string reserInQuery = string.Format("INSERT INTO reservation(입양자, DogID, Phone, date, 주소) values('{0}',{1},'{2}','{3}', '{4}')", person.name, DogID, person.pohneNum, date, person.address);
                string phoneCheckQuery = string.Format("SELECT name from adop_per WHERE Phone = '{0}'", person.pohneNum);
                string dogUpdate = string.Format("UPDATE dog SET par=2 WHERE DogID={0}", DogID);


                MySqlCommand perInCmd = new MySqlCommand(perInQuery, Program.con);
                MySqlCommand reserInCmd = new MySqlCommand(reserInQuery, Program.con);
                MySqlCommand phoneCheckCmd = new MySqlCommand(phoneCheckQuery, Program.con);
                MySqlCommand dogUpdateCmd = new MySqlCommand(dogUpdate, Program.con);

                MySqlDataReader rdr = phoneCheckCmd.ExecuteReader();

                if (dogIdTb.Text == "")
                {
                    MessageBox.Show("강아지를 선택하세요");
                    Program.con.Close();
                    return;
                }
                if (perNameTb.Text == "")
                {
                    MessageBox.Show("이름을 입력하세요");
                    Program.con.Close();
                    return;
                }
                if (perAgeTb.Text == "")
                {
                    MessageBox.Show("나이를 입력하세요");
                    Program.con.Close();
                    return;
                }
                if (perNumTb.Text == "")
                {
                    MessageBox.Show("전화번호를 입력하세요");
                    Program.con.Close();
                    return;
                }
                if (perAddressTb.Text == "")
                {
                    MessageBox.Show("주소를 입력하세요");
                    Program.con.Close();
                    return;
                }

                if (rdr.Read())
                {
                    //이미 분양 예약자 테이블에 존재하는 사람이 또 예약하는 경우
                    if ((string)rdr["name"] == person.name)
                    {
                        rdr.Close();
                        //분양 예약 테이블에만 데이터 삽입
                        reserInCmd.ExecuteNonQuery();
                        dogUpdateCmd.ExecuteNonQuery(); //분양 상태를 예약으로 업데이트(par=2)
                        MessageBox.Show("분양 예약 등록 완료");
                        dateTimePicker1.Value = DateTime.Now;
                        dogIdTb.Text = null;
                        perNameTb.Text = null;
                        perAgeTb.Text = null;
                        perNumTb.Text = null;
                        perAddressTb.Text = null;

                        Program.con.Close();
                        return;
                    }
                    MessageBox.Show("이미 동록된 전화번호입니다.");
                    Program.con.Close();
                    return;
                }
                //첫 분양 예약자 - 분양 예약자, 분양 예약 데이터 모두 삽입
                rdr.Close();
                perInCmd.ExecuteNonQuery();
                reserInCmd.ExecuteNonQuery();
                dogUpdateCmd.ExecuteNonQuery(); //분양 상태를 예약으로 업데이트(par=2)
                MessageBox.Show("분양 예약 등록 완료");
                dateTimePicker1.Value = DateTime.Now;
                dogIdTb.Text = null;
                perNameTb.Text = null;
                perAgeTb.Text = null;
                perNumTb.Text = null;
                perAddressTb.Text = null;
                Program.con.Close();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked == true)
            {
                person.sex = "남";
                womanCb.Checked = false;
                return;
            }
            if (cb.Checked == false)
            {
                if (womanCb.Checked == false)
                {
                    manCb.Checked = true;
                    person.sex = "남";
                }
            }
        }

        private void womanCb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked == true)
            {
                person.sex = "여";
                manCb.Checked = false;
                return;
            }
            if (cb.Checked == false)
            {
                if (manCb.Checked == false)
                {
                    womanCb.Checked = true;
                    person.sex = "여";
                }
            }
        }

        private void registList_Click(object sender, EventArgs e)
        {
            dogList dogList = new dogList();
            dogList.Show();
        }

        private void adminName_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.con.Open();

            string selQuery = "SELECT *  FROM reservation;";
            MySqlCommand selCmd = new MySqlCommand(selQuery, Program.con);
            MySqlDataAdapter da = new MySqlDataAdapter(selCmd);
            DataTable dt = new DataTable();
            Program.con.Close();
            da.Fill(dt);

            reserveDataList.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //분양 여부 업데이트
            foreach (DataGridViewRow row in reserveDataList.SelectedRows)
            {
                int data = (int)row.Cells[2].Value;
                reserveDataList.Rows.RemoveAt(row.Index);

                string parUpQuery = string.Format("UPDATE dog SET par=1 WHERE DogID={0}", data);
                string delQuery = string.Format("DELETE FROM reservation WHERE DogID={0}", data);
                MySqlCommand parUpCmd = new MySqlCommand(parUpQuery, Program.con);
                MySqlCommand delCmd = new MySqlCommand(delQuery, Program.con);

                try
                {
                    Program.con.Open();
                    parUpCmd.ExecuteNonQuery();
                    delCmd.ExecuteNonQuery();
                    MessageBox.Show("분양 완료 처리되었습니다.");
                    Program.con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in reserveDataList.SelectedRows)
            {
                int data = (int)row.Cells[2].Value;
                reserveDataList.Rows.RemoveAt(row.Index);

                string parUpQuery = string.Format("UPDATE dog SET par=0 WHERE DogID={0}", data);
                string delQuery = string.Format("DELETE FROM reservation WHERE DogID={0}", data);
                MySqlCommand parUpCmd = new MySqlCommand(parUpQuery, Program.con);
                MySqlCommand delCmd = new MySqlCommand(delQuery, Program.con);

                try
                {
                    Program.con.Open();
                    parUpCmd.ExecuteNonQuery();
                    delCmd.ExecuteNonQuery();
                    MessageBox.Show("분양 취소 처리되었습니다.");
                    Program.con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void 입양완료갱얼지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adopCom adop = new adopCom();
            adop.Show();
            this.Close();
        }

        private void numCb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if(cb.Checked == true)
            {
                searchVal = "Phone";
                numCb.Checked = false;
                return;
            }
            if(cb.Checked == false)
            {
                if(nameCb.Checked == false)
                {
                    searchVal = "Phone";
                    numCb.Checked = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string search = searchTb.Text;

            Program.con.Open();

            string searchQuery = string.Format("SELECT * FROM reservation WHERE {0} = {1}", searchVal, search);
            MySqlCommand searchCmd = new MySqlCommand(searchQuery, Program.con);
            MySqlDataReader rdr = searchCmd.ExecuteReader();

            if (rdr.Read())
            {
                rdr.Close();
                MySqlDataAdapter da = new MySqlDataAdapter(searchCmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                reserveDataList.DataSource = dt;

                Program.con.Close();
                return;
            }
            MessageBox.Show("정보가 없습니다");
            Program.con.Close();
        }

        private void nameCb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (cb.Checked == true)
            {
                searchVal = "name";
                nameCb.Checked = false;
                return;
            }
            if (cb.Checked == false)
            {
                if (numCb.Checked == false)
                {
                    searchVal = "name";
                    nameCb.Checked = true;
                }
            }
        }
    }
}
