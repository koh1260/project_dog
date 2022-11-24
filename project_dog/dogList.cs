using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project_dog
{
    public partial class dogList : Form
    {
        string searchVal = "name";
        List<CheckBox> search = new List<CheckBox>();
        public dogList()
        {
            InitializeComponent();
            nameCb.Checked = true;
            adminName.Text = "관리자: " + Program.id;
            search = new List<CheckBox>(){nameCb, varCb};
        }

        public void MysqlCon()
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           

            
        }

        private void 입양완료갱얼지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adopCom adopcom = new adopCom();
            adopcom.Show();
            this.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (varCb.Checked == false && nameCb.Checked == false)
            {
                nameCb.Checked = true;
            }

            foreach (CheckBox c in search)
            {
                if (cb.Checked)
                {
                    if (cb.Name == c.Name)
                    {
                        searchVal = "var";
                        continue;
                    }
                    c.CheckState = CheckState.Unchecked;
                }
            }
        }

        private void btnDogRegi_Click(object sender, EventArgs e)
        {
            dogRegist dogregist = new dogRegist();
            dogregist.Show();
        }

        private void menuReserv_Click(object sender, EventArgs e)
        {
            FormReserve formreserv = new FormReserve();
            formreserv.Show();
        }

        private void registList_Click(object sender, EventArgs e)
        {
            reserveList reservelist = new reserveList();
            reservelist.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Program.con.Open();
            //미분양된 강아지 SELECT
            string selQuery = "SELECT DogID, name, age, sex, var, neu  FROM dog WHERE par = 0";
            MySqlCommand selCmd = new MySqlCommand(selQuery, Program.con);
            MySqlDataAdapter da = new MySqlDataAdapter(selCmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dogDataList.DataSource = dt;
            Program.con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
      

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dogDataList.SelectedRows)
            {
                Program.con.Open();
                string imgSelQuery = string.Format("SELECT image FROM dog WHERE DogID = {0}", row.Cells[0].Value);
                MySqlCommand imgSelCmd = new MySqlCommand(imgSelQuery, Program.con);
                MySqlDataReader rdr = imgSelCmd.ExecuteReader();

                if (rdr.Read())
                {
                    if (DBNull.Value != rdr["image"])
                    {
                        var data = (Byte[])rdr["image"];
                        var stream = new MemoryStream(data);
                        pictureBox1.Image = System.Drawing.Image.FromStream(stream);
                    }
                    else
                    {
                        pictureBox1.Image = Properties.Resources.profilejpg;
                    }
                }
                rdr.Close();
                //선택된 셀의 데이터 왼 쪽 TextBox, PictureBox에 넣기.
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();
                textBox4.Text = row.Cells[4].Value.ToString();
                textBox5.Text = row.Cells[5].Value.ToString();

                Program.con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //종료
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dogDataList.SelectedRows)
            {
                int data = (int)row.Cells[0].Value;
                dogDataList.Rows.RemoveAt(row.Index);

                string delQuery = string.Format("DELETE FROM dog WHERE  DogID = {0}", data);
                MySqlCommand delCmd = new MySqlCommand(delQuery, Program.con);

                MySqlDataReader rdr;

                try
                {
                    Program.con.Open();
                    rdr = delCmd.ExecuteReader();
                    textBox1.Text = null;
                    textBox2.Text = null;
                    textBox3.Text = null;
                    textBox4.Text = null;
                    textBox5.Text = null;
                    pictureBox1.Image = null;

                    rdr.Close();
                    Program.con.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void nameCb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (varCb.Checked == false && nameCb.Checked == false)
            {
                nameCb.Checked = true;
            }

            foreach (CheckBox c in search)
            {
                if (cb.Checked)
                {
                    if (cb.Name == c.Name)
                    {
                        searchVal = "name";
                        continue;
                    }
                    c.CheckState = CheckState.Unchecked;
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Program.con.Open();
            //체크된 조건을 만족하고 미분양된 강아지 검색
            string searchQuery = string.Format("SELECT DogID, name, age, sex, var, neu  FROM dog WHERE {0} = '{1}' AND par = 0 ", searchVal, searchTb.Text);
            MySqlCommand searchCmd = new MySqlCommand(searchQuery, Program.con);
            MySqlDataReader rdr = searchCmd.ExecuteReader();

            if (rdr.Read())
            {
                rdr.Close();
                MySqlDataAdapter da = new MySqlDataAdapter(searchCmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dogDataList.DataSource = dt;

                Program.con.Close();
                return;
            }
            MessageBox.Show("정보가 없습니다");
            Program.con.Close();
        }

        private void searchTb_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }
    }
}
