namespace project_dog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dogList doglist = new dogList();
            doglist.Show();
            //this.Dispose();
        }
    }
}