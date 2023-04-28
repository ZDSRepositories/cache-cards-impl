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
        private string newUsername;
        private string newPass;
        // status of creating the new user
        // private bool validUser = false;
        private bool confirmedPass = false;
        private bool validPass = false;
        public NewUser(DB mainDB, User currentUser )
        {
            InitializeComponent();
            this.mainDB = mainDB;
            this.currentUser = currentUser;
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            // Ensure that the user has a unique username and that their pasword is confirmed
            if (newUsernameTxtbox.Text.Length == 0 || newUsernameTxtbox.Text == null)
            {
                MessageBox.Show("Must enter a username");
            }
            else
            {
                newUsername = newUsernameTxtbox.Text;
                // check if the username is taken
                if (mainDB.users.ContainsKey(newUsername))
                {
                    newUsernameTxtbox.BackColor = Color.Red;
                    MessageBox.Show("Username already taken");
                    // clear text box so the loop is not stuck
                    newUsernameTxtbox.Clear();
                    newUsernameTxtbox.BackColor = SystemColors.Window;
                }
            }

            if ((passwordTxtbox.Text.Length == 0 || passwordTxtbox.Text == null) | (confPasswordTxtbox.Text.Length == 0 || confPasswordTxtbox.Text == null))
            {
                MessageBox.Show("Password fields cannot be left blank. \nPlease fill in both fields and try again");
            }
            else if (!passwordTxtbox.Text.Equals(confPasswordTxtbox.Text))
            {
                MessageBox.Show("Passwords do not match");
            }
            else
            { // after all checks, create new User object and assign username and password
                User newUser = new User();
                newUser.username = newUsername;
                newUser.password = newPass;

                // add the username to the dictionary 
                mainDB.users.Add(newUsername, newUser);

                // sereialize to the json file
                DBManager dbm = new DBManager();
                dbm.serializeDB(mainDB);

                // let the user know they have created an account and send them to their home page
                MessageBox.Show("Your account has been created succesfully!");
                this.Hide();
                var form2 = new HomePage(mainDB, newUser);
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }
    }
}
