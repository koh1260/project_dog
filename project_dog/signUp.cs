﻿using System;
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
        MySqlConnection con;

        public signUp()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection("Server=localhost;Port=3307;Database=dog_db;Uid=root;Pwd=1306;");
                con.Open();                   

                string selQuery = string.Format("SELECT * FROM admin WHERE ID='{0}'",idTb.Text);
                string inQuery = string.Format("INSERT INTO admin (ID, PW, name) VALUES('{0}','{1}','{2}')", idTb.Text, pwTb.Text, nameTb, Text);

                MySqlCommand selCmd = new MySqlCommand(selQuery, con);
                MySqlCommand inCmd = new MySqlCommand(inQuery, con);
                MySqlDataReader rdr = selCmd.ExecuteReader();

                if (idTb.Text.Length != 0 && pwTb.Text.Length != 0 && pwCTb.Text.Length != 0 && nameTb.Text.Length != 0)
                {
                    if (rdr.Read())
                    {
                        MessageBox.Show("이미 존재하는 아이디입니다.");
                        con.Close();
                        return;
                    }
                    rdr.Close();
                    if (pwTb.Text == pwCTb.Text)
                    {
                        if (inCmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("회원 가입이 완료되었습니다.");
                            con.Close();
                            return;
                        }

                    }
                    MessageBox.Show("비밀번호가 일치하지 않습니다.");
                    return;
                }
                MessageBox.Show("정보를 모두 입력하세요.");
                con.Close();

            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            //if (selCommand.ExecuteNonQuery() != 1)
            //    ShowDialog("")
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
