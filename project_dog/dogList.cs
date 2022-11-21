using MySql.Data.MySqlClient;
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
using static System.Net.Mime.MediaTypeNames;

namespace project_dog
{
    public partial class dogList : Form
    {
        MySqlConnection con; 
        public dogList(string name)
        {
            InitializeComponent();
            adminName.Text = name;
            con = new MySqlConnection("Server=localhost;Port=3307;Database=dog_db;Uid=root;Pwd=1306;");
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
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

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
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();

            string selQuery = "SELECT DogID, name, age, sex, var, neu, image FROM dog WHERE par = 0";
            MySqlCommand selCmd = new MySqlCommand(selQuery, con);
            MySqlDataAdapter da = new MySqlDataAdapter(selCmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dogDataList.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
      

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dogDataList.SelectedRows)
            {
                //name age sex var neu par image
                //string value1 = row.Cells[0].Value.ToString();
                //string value2 = row.Cells[1].Value.ToString();
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();
                textBox4.Text = row.Cells[4].Value.ToString();
                textBox5.Text = row.Cells[5].Value.ToString();
    
                var data = (Byte[])(row.Cells[6].Value);
                var stream = new MemoryStream(data);
                pictureBox1.Image = System.Drawing.Image.FromStream(stream);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dogDataList.SelectedRows)
            {
                dogDataList.Rows.RemoveAt(item.Index);
            }
        }
    }
}
