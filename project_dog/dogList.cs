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
    public partial class dogList : Form
    {
        public dogList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void 입양완료갱얼지ToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
