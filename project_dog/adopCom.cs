using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_dog
{
    public partial class adopCom : Form
    {
        string searchVal = "이름";
        public adopCom()
        {
            InitializeComponent();
            adminName.Text = "관리자: " + Program.id;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.con.Open();
            //체크된 조건을 만족하고 분양된 강아지 검색
            string searchQuery = string.Format("SELECT DogID, 이름, age, sex, var, neu  FROM dog WHERE {0} = '{1}' AND par = 1 ", searchVal, searchTb.Text);
            MySqlCommand searchCmd = new MySqlCommand(searchQuery, Program.con);
            MySqlDataReader rdr = searchCmd.ExecuteReader();

            if (rdr.Read())
            {
                rdr.Close();
                MySqlDataAdapter da = new MySqlDataAdapter(searchCmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                adopComList.DataSource = dt;

                Program.con.Close();
                return;
            }
            MessageBox.Show("정보가 없습니다");
            Program.con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void registList_Click(object sender, EventArgs e)
        {
            dogList dl = new dogList();
            dl.Show();
            this.Close();
        }

        private void 입양완료갱얼지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reserveList rl = new reserveList();
            rl.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.con.Open();
            //미분양된 강아지 SELECT
            string selQuery = "SELECT DogID, 이름, age, sex, var, neu  FROM dog WHERE par = 1";
            MySqlCommand selCmd = new MySqlCommand(selQuery, Program.con);
            MySqlDataAdapter da = new MySqlDataAdapter(selCmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            adopComList.DataSource = dt;
            Program.con.Close();
        }

        private void adopComList_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in adopComList.SelectedRows)
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

        private void nameCb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if(cb.Checked == true)
            {
                varCb.Checked = false;
                searchVal = "이름";
                return;
            }
            if(cb.Checked == false)
            {
                if(varCb.Checked == false)
                {
                    nameCb.Checked = true;
                    searchVal = "이름";
                }
            }
        }

        private void varCb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (cb.Checked == true)
            {
                nameCb.Checked = false;
                searchVal = "var";
                return;
            }
            if (cb.Checked == false)
            {
                if (nameCb.Checked == false)
                {
                    varCb.Checked = true;
                    searchVal = "var";
                }
            }
        }

        private void searchTb_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button4_Click(sender, e);
            }
        }
    }
}
