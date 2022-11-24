using MySql.Data.MySqlClient;

namespace project_dog
{
    class Creature
    {
        public string name { get; set; }
        public int? age { get; set; }
        public string sex { get; set; }
    }
    class Dog : Creature
    {
        public string var { get; set; }
        public char neu { get; set; }
        public int par { get; set; }
    }
    class Person : Creature
    {
        public string pohneNum { get; set; }
        public string address { get; set; }
    }
    internal static class Program
    {
        public static MySqlConnection con = new MySqlConnection("Server=localhost;Port=3307;Database=dog_db;Uid=root;Pwd=1306;");
        public static string id;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            (new Form1()).Show();
            Application.Run();
        }
    }
}