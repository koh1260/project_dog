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
using MySql.Data.MySqlClient;

namespace project_dog
{
    public partial class signUp : Form
    {

        public signUp()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            //if (selCommand.ExecuteNonQuery() != 1)
            //    ShowDialog("")
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pwCTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOk_Click(sender, e);
             }
        }

        private void pwCTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string name = nameTb.Text;
            string id = idTb.Text;
            string pw = pwTb.Text;
            string pwC = pwCTb.Text;

            try
            {
                Program.con = new MySqlConnection("Server=localhost;Port=3307;Database=dog_db;Uid=root;Pwd=1306;");
                Program.con.Open();

                string selQuery = string.Format("SELECT * FROM admin WHERE ID='{0}'", id);
                string inQuery = string.Format("INSERT INTO admin (ID, PW, name) VALUES('{0}','{1}','{2}')", id, pw, name);

                MySqlCommand selCmd = new MySqlCommand(selQuery, Program.con);
                MySqlCommand inCmd = new MySqlCommand(inQuery, Program.con);
                MySqlDataReader rdr = selCmd.ExecuteReader();

                //하나라도 비어 있음 안 됨, 비번 8자 이상, 아이디는 중복X, 
                if (id.Length != 0 && pw.Length != 0 && pwC.Length != 0 && name.Length != 0)
                {
                    if (rdr.Read())
                    {
                        MessageBox.Show("이미 존재하는 아이디입니다.");
                        Program.con.Close();
                        return;
                    }
                    rdr.Close();
                    if (pw.Length >= 8)
                    {
                        if (pwTb.Text == pwCTb.Text)
                        {
                            if (inCmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("회원 가입이 완료되었습니다.");
                                nameTb.Text = null;
                                idTb.Text = null;
                                pwTb.Text = null;
                                pwCTb.Text = null;
                                Program.con.Close();
                                return;
                            }
                        }
                        MessageBox.Show("비밀번호가 일치하지 않습니다.");
                        Program.con.Close();
                    }
                    MessageBox.Show("비번 8자 이상 입력 ㄱㄱ");
                    Program.con.Close();
                    return;
                }
                MessageBox.Show("정보를 모두 입력하세요.");
                Program.con.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
