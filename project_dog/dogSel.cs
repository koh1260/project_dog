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
    public partial class dogSel : Form
    {
        reserveList reservForm;
        public dogSel(reserveList reserv)
        {
            reservForm = reserv;
            InitializeComponent();
            Program.con.Open();
            //미분양된 강아지 SELECT
            string selQuery = "SELECT DogID, name, age, sex, var, neu  FROM dog WHERE par = 0";
            MySqlCommand selCmd = new MySqlCommand(selQuery, Program.con);
            MySqlDataAdapter da = new MySqlDataAdapter(selCmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            dogSelList.DataSource = dt;
            Program.con.Close();
        }

        private void dogSelList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }



        private void dogSelList_CellDoubleClick_2(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dogSelList.SelectedRows)
            {
                reservForm.setDogIdTb = row.Cells[0].Value.ToString();
            }
            this.Close();
        }
    }
}
