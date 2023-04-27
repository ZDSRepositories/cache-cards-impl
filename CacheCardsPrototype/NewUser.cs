using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacheCardsPrototype
{
    public partial class NewUser : Form
    {
        // Make variables for DB and user being passed around
        public DB mainDB;
        public User currentUser;

        // new username entered by user
        public string newUsername;
        public NewUser(DB mainDB, User currentUser )
        {
            InitializeComponent();
            this.mainDB = mainDB;
            this.currentUser = currentUser;
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            newUsername = newUsernameTxtbox.Text;
            if (mainDB.users.ContainsKey(newUsername))
            {
                newUsernameTxtbox.BackColor = Color.Red;
                MessageBox.Show("Username already taken");
            }
            if (!passwordTxtbox.Text.Equals(confPasswordTxtbox.Text))
            {
                MessageBox.Show("Password doesn't match confirm password");
            }
            if(passwordTxtbox.Text == null || passwordTxtbox.Text.Length == 0)
            {
                MessageBox.Show("Password can't be nothing");
            }
            //after all checks
            User newUser = new User();
            newUser.username = newUsername;
            newUser.password = passwordTxtbox.Text;
            mainDB.users.Add(newUsername, newUser);

            DBManager dbm = new DBManager();
            dbm.serializeDB(mainDB);

            }
    }
}
