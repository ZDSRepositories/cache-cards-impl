using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Text.Json;
using System.Configuration;
using System.IO;
using System.Collections;

namespace CacheCardsPrototype
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public User(string usr, string pwd) {
            username = usr;
            password = pwd;
        
        }
    }
    public class DB
    {
        public Dictionary<string, User> users = new Dictionary<string, User>();
    }
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
            this.Load += loginPage_Load;
        }

        private DB mainDB = new DB();
        private const string db_filename = "database.json";

        private void loginPage_Load(object sender, EventArgs e)
        {
            // Deserialize the DB on startup.
            string jsonString = File.ReadAllText(db_filename);
            mainDB = JsonSerializer.Deserialize<DB>(jsonString);            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!mainDB.users.ContainsKey(textBox1.Text.ToString())) // if there is no user with the username
            {
                MessageBox.Show("There's no user named '"+ textBox1.Text + "'!");
            }
            else if (!textBox2.Text.Equals(mainDB.users[textBox1.Text].password))
            {
                MessageBox.Show("Wrong password!");
            }
            else {
                this.Hide();
                var form2 = new HomePage();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }

    }
}
