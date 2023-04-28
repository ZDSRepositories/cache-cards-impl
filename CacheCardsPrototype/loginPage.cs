using System.Text.Json;


namespace CacheCardsPrototype
{
     

    
    public partial class loginPage : Form
    {


        public loginPage()
        {
            InitializeComponent();
            this.Load += LoginPage_Load;
            //MessageBox.Show(full_path);
        }

        public DB mainDB = new DB();
        public User currentUser = new User();
        // we need to make sure that every user can open the file
        private const string db_filename = "database.json";
        // get the full path name on the specific system

        public string full_path = Path.GetFullPath(db_filename);


        public DB deserializeDB()
        {
            string jsonString = File.ReadAllText(full_path);
            //MessageBox.Show(jsonString);
            mainDB = JsonSerializer.Deserialize<DB>(jsonString);
            return mainDB;
        }

        public void serializeDB(DB memoryDB, string absolute_path)
        {
            string jsonString = JsonSerializer.Serialize(memoryDB);
            File.WriteAllText(absolute_path, jsonString);
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            // Deserialize the DB on startup.
            mainDB = deserializeDB();


        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Create New User");
            this.Hide();
            var form2 = new NewUser(mainDB, currentUser);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainDB = deserializeDB();
            if (!mainDB.users.ContainsKey(textBox1.Text.ToString())) // if there is no user with the username
            {
                MessageBox.Show("There's no user named '" + textBox1.Text + "'!\nPlease press the create account button");
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

        private void loginPage_Load_1(object sender, EventArgs e)
        {

        }
    }
    public class User
    {
        // attributes of a user
        public string username { get; set; }
        public string password { get; set; }
        public Dictionary<string, Dictionary<string, Set>> flashcards { get; set; } = new Dictionary<string, Dictionary<string, Set>>(); // keys: topic names, values: dictionaries of sets by set name
        public User() {
        
        }
    }
    public class DB
    {
        public Dictionary<string, User> users { get; set; } = new Dictionary<string, User>();
    }
    public class Card
    {
        public string front { get; set; }
        public string back { get; set; }
    }

    public class Set
    {
        public string setname { get; set; }
        public string topic { get; set; }
        public Card[] cards { get; set; }
    }

    public class DBManager
    {
        public DBManager() { }

        // we need to make sure that every user can open the file
        private const string db_filename = "database.json";
        // get the full path name on the specific system

        public string full_path = Path.GetFullPath(db_filename);

        public DB deserializeDB()
        {
            string jsonString = File.ReadAllText(full_path);
            //MessageBox.Show(jsonString);
            DB mainDB = JsonSerializer.Deserialize<DB>(jsonString);
            return mainDB;
        }
        public void serializeDB(DB memoryDB)
        {
            string jsonString = JsonSerializer.Serialize(memoryDB);
            File.WriteAllText(full_path, jsonString);
        }
    }

    // make a class that can get the topic names and setnames with a function
    // then just call the method and have it return an array or something so we
    // can then work with the array, same idea as making a class for the serialization
    // and deserialization 

}
