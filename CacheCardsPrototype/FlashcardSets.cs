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

namespace CacheCardsPrototype
{
    public partial class FlashcardSets : Form
    {
        public DB mainDB;
        public User currentUser;

        

        public FlashcardSets(DB mainDB, User currentUser)
        {
            InitializeComponent();
            this.mainDB = mainDB;
            this.currentUser = currentUser;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void FlashcardSets_Load(object sender, EventArgs e)
        {
            if ((currentUser.flashcards.Count() > 0))
            {
                // get the user's topics
                string[] usersTopics = currentUser.flashcards.Keys.ToArray();
                // get the user's setNames
                string[] usersSetNames = currentUser.flashcards[usersTopics[0]].Keys.ToArray();

                label3.Text = usersSetNames[0];
                label4.Text = usersSetNames[1];
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(usersTopics);
                //Set newSet = new Set();
            }
            else
            {
                usersSetsPanel.Controls.Clear();
            }
            
            
           
            
            //if(usersTopics != null ) 
            //{
            //    
            //}
            //foreach (string topic in usersTopics)
            //{
            //    Label 
            //}


            //if (usersSetNames.Length > 0) { 
            //    label3.Text = usersSetNames[0];
            //}
            //if (usersSetNames.Length > 1)
            //{
            //    label4.Text = usersSetNames[1];
            //}
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new HomePage(this.mainDB, this.currentUser);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void flashcardsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new FlashcardSets(this.mainDB, this.currentUser);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void gameButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new GameCatalog(this.mainDB, this.currentUser);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new ModifyFlashCards(this.mainDB, this.currentUser);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //// get the user's topic names
            //string[] usersTopics = this.currentUser.flashcards.Keys.ToArray();
            //// get the user's setNames
            //string[] usersSetNames = this.currentUser.flashcards[usersTopics[0]].Keys.ToArray();
            this.Hide();
            var form2 = new StudyFlashCards(this.mainDB, this.currentUser);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //// get the user's topic names
            //string[] usersTopics = this.currentUser.flashcards.Keys.ToArray();
            //// get the user's setNames
            //string[] usersSetNames = this.currentUser.flashcards[usersTopics[0]].Keys.ToArray();
            this.Hide();
            var form2 = new StudyFlashCards(this.mainDB, this.currentUser);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new ModifyFlashCards(this.mainDB, this.currentUser);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new ModifyFlashCards(this.mainDB, this.currentUser);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
