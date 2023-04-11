using System.Text.Json;


namespace CacheCardsPrototype
{
    public partial class loginPage : Form
    {
        // we need to make sure that every user can open the file
        private const string db_filename = "database.json";
        // get the full path name on the specific system
        public string full_path = Path.GetFullPath(db_filename);
        public loginPage()
        {
            InitializeComponent();
            this.Load += LoginPage_Load;
        }

        public DB mainDB = new DB();
        public User currentUser = new User();


        //private const string db_filename = "database.json";
        //"C:\\Users\\1zada\\OneDrive\\Documents\\software_engineering_1\\cache_cards\\repository\\cache-cards-impl\\CacheCardsPrototype\\database.json";

        private DB deserializeDB()
        {
            //User foo = new User();
            //foo.username = "bob"; foo.password= "tomato";
            //mainDB.users.Add(foo.username,  foo);
            //string jsonString = JsonSerializer.Serialize(mainDB);
            //File.WriteAllText(db_filename, jsonString);

            string jsonString = File.ReadAllText(full_path);
            //MessageBox.Show(jsonString);
            mainDB = JsonSerializer.Deserialize<DB>(jsonString);
            return mainDB;
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            // Deserialize the DB on startup.
            mainDB = deserializeDB();


        }


        private void button1_Click(object sender, EventArgs e)
        {
            mainDB = deserializeDB();
            if (!mainDB.users.ContainsKey(textBox1.Text.ToString())) // if there is no user with the username
            {
                MessageBox.Show("There's no user named '" + textBox1.Text + "'!");
            }
            else if (!textBox2.Text.Equals(mainDB.users[textBox1.Text].password))
            {
                MessageBox.Show("Wrong password!");
            }
            else
            {
                this.currentUser = mainDB.users[textBox1.Text];
                this.Hide();
                var form2 = new HomePage(mainDB, currentUser);
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }

    }
    public class User
    {
        // attributes of a user
        public string username { get; set; }
        public string password { get; set; }
        public User() {
        
        }
    }
    public class DB
    {
        public Dictionary<string, User> users { get; set; } = new Dictionary<string, User>();
    }

}
