using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace project_dog
{
    public partial class dogRegist : Form
    {
        Dog dog = new Dog();
        List<CheckBox> BoyAndGirl = new List<CheckBox>();
        List<CheckBox> NeuCheckB = new List<CheckBox>();
        string imgPath = null;
        public dogRegist()
        {
            InitializeComponent();

            boyCb.Checked = true;
            NeuO.Checked = true;
            BoyAndGirl = new List<CheckBox>() { boyCb, girlCb };
            NeuCheckB = new List<CheckBox>() { NeuO, NeuX };
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            

            if (boyCb.Checked)
            {
                dog.sex = "남";
            }
            else
            {
                dog.sex = "여";
            }

            if (NeuO.Checked)
            {
                dog.neu = 'O';
            }
            else
            {
                dog.neu = 'X';
            }
            dog.name = ReNameTb.Text;
            dog.age = int.Parse(ReAgeTb.Text);
            dog.var = ReVarTb.Text;
            dog.par = 0;
            MySqlCommand cmd = new MySqlCommand();

            UInt32 FileSize;
            byte[] rawData;
            FileStream fs;
            BinaryReader br;
            try {
                MySqlCommand inCmd;
                if (imgPath != null)
                {
                    fs = new FileStream(imgPath, FileMode.Open, FileAccess.Read);
                    FileSize = (UInt32)fs.Length;

                    rawData = new byte[FileSize];
                    fs.Read(rawData, 0, (int)FileSize);
                    fs.Close();

                    Program.con.Open();

                    string inQuery = string.Format("INSERT INTO dog (name, age, sex, var, neu, par, image) VALUES('{0}',{1},'{2}', '{3}', '{4}',{5}, @File)", dog.name, dog.age, dog.sex, dog.var, dog.neu, dog.par);

                    inCmd = new MySqlCommand(inQuery, Program.con);

                    inCmd.Parameters.AddWithValue("@File", rawData);
                }
                else
                {
                    Program.con.Open();

                    string inQuery = string.Format("INSERT INTO dog (name, age, sex, var, neu, par) VALUES('{0}',{1},'{2}', '{3}', '{4}',{5})", dog.name, dog.age, dog.sex, dog.var, dog.neu, dog.par);

                    inCmd = new MySqlCommand(inQuery, Program.con);
                }
                if (dog.name.Length != 0 && dog.age != 0 && dog.var.Length != 0)
                {

                    if (inCmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("등록이 완료되었습니다.");
                        pictureBox1.Image = Properties.Resources.profilejpg;
                        ReNameTb.Text = null;
                        ReAgeTb.Text = null;
                        ReVarTb.Text = null;
                        boyCb.Checked = true;
                        NeuO.Checked = true;
                        Program.con.Close();
                        return;
                    }
                }
                Program.con.Close();
                MessageBox.Show("정보를 모두 입력하세요.");
            } catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void ReNameTb_TextChanged(object sender, EventArgs e)
        {
            //한글만
            char[] inputchars = ReNameTb.Text.ToCharArray();
            var sb = new StringBuilder();
            foreach (var item in inputchars)
            {
                if (char.GetUnicodeCategory(item) == UnicodeCategory.OtherLetter)
                {
                    sb.Append(item);
                }
            }
            ReNameTb.Text = sb.ToString().Trim();
        }

        private void ReAgeTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void ReVarTb_TextChanged(object sender, EventArgs e)
        {
            //한글만
            char[] inputchars = ReNameTb.Text.ToCharArray();
            var sb = new StringBuilder();
            foreach (var item in inputchars)
            {
                if (char.GetUnicodeCategory(item) == UnicodeCategory.OtherLetter)
                {
                    sb.Append(item);
                }
            }
            ReNameTb.Text = sb.ToString().Trim();
        }

        private void boyCb_CheckedChanged(object sender, EventArgs e)
        {
            //성별 체크박스 중복 선택 X
            CheckBox cb = (CheckBox)sender;

            if(boyCb.Checked == false && girlCb.Checked == false)
            {
                boyCb.Checked = true;
            }

            foreach (CheckBox c in BoyAndGirl)
            {
                if (cb.Checked)
                {
                    if (cb.Name == c.Name)
                    {
                        dog.sex = "남";
                        continue;
                    }
                    c.CheckState = CheckState.Unchecked;
                }
            }
        }

        private void girlCb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (boyCb.Checked == false && girlCb.Checked == false)
            {
                boyCb.Checked = true;
            }

            foreach (CheckBox c in BoyAndGirl)
            {
                if (cb.Checked)
                {
                    if (cb.Name == c.Name)
                    {
                        dog.sex = "여";
                        continue;
                    }
                    c.CheckState = CheckState.Unchecked;
                }
            }
        }

        private void NeuO_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (NeuO.Checked == false && NeuX.Checked == false)
            {
                NeuO.Checked = true;
            }

            foreach (CheckBox c in NeuCheckB)
            {
                if (cb.Checked)
                {
                    if (cb.Name == c.Name)
                    {
                        dog.neu = 'O';
                        continue;
                    }
                    c.CheckState = CheckState.Unchecked;
                }
            }
        }

        private void NeuX_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            foreach (CheckBox c in NeuCheckB)
            {
                if (cb.Checked)
                {
                    if (cb.Name == c.Name)
                    {
                        dog.neu = 'X';
                        continue;
                    }
                    c.CheckState = CheckState.Unchecked;
                }
            }
        }

        private void selPic_Click(object sender, EventArgs e)
        {
            //이미지 선택하면 보여주고 경로 저장.
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "이미지 파일 (*.jpg, *.png) | *.jpg; *.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileFullName = ofd.FileName;
                imgPath = fileFullName;
                pictureBox1.Image = new Bitmap(ofd.FileName);
                pictureBox1.Tag = ofd.FileName;
            }

            //ShowFileOpenDialog();
        }
        public void ShowFileOpenDialog(){
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "image";
            ofd.Filter = "이미지 파일 (*.jpg, *.png) | *.jpg; *.png";

            DialogResult dr = ofd.ShowDialog();

            if(dr == DialogResult.OK)
            {
                string fileFullName = ofd.FileName;

                imgPath = fileFullName;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void savePic_Click(object sender, EventArgs e)
        {
           

           
        }
    }
}
