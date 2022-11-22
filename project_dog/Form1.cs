using MySql.Data.MySqlClient;
using System.Drawing;

namespace project_dog
{
    public partial class Form1 : Form
    {
        MySqlConnection con;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = textBoxId.Text;
            string pw = textBoxPw.Text;

            try
            {
                con = new MySqlConnection("Server=localhost;Port=3307;Database=dog_db;Uid=root;Pwd=1306;");
                con.Open();
                string selQuery = string.Format("SELECT * FROM admin WHERE ID = '{0}'", id);
                //string selPwQuery = string.Format("SELECT * FROM admin WHERE ID = '{0}'", id);

                MySqlCommand selcmd = new MySqlCommand(selQuery, con);
                //MySqlCommand selPcmd = new MySqlCommand(selPwQuery, con);
                MySqlDataReader rdr = selcmd.ExecuteReader();
                
                if(id == "" || pw == "")
                {
                    MessageBox.Show("���̵� Ȥ�� ��й�ȣ�� �Էµ��� �ʾҽ��ϴ�.");
                    return;
                }
                if (rdr.Read())
                {
                    Console.WriteLine(rdr["PW"]);
                    if (Equals(pw, rdr["PW"]))
                    {
                        MessageBox.Show("�ݰ��� " + rdr["name"]);
                        con.Close();
                        rdr.Close();

                        dogList dl = new dogList(id);
                        dl.Show();
                        this.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("����� �޶�");
                        rdr.Close();
                        return;
                    }
                }
                rdr.Close();
                MessageBox.Show("�������� �ʴ� admin�Դϴ�.");
            }catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }



        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            signUp signup = new signUp();
            signup.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}