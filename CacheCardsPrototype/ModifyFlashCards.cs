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
    public partial class ModifyFlashCards : Form
    {
        public DB mainDB;
        public User currentUser;
        public ModifyFlashCards(DB mainDB, User currentUser)
        {
            InitializeComponent();
            this.mainDB = mainDB;
            this.currentUser = currentUser;
        }

        private void ModifyFlashCards_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new HomePage(this.mainDB, this.currentUser);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void textBox1_textChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void createButton_Click(object sender, EventArgs e)
        {
            if (setNameTextbox.Text.Length == 0) {
                MessageBox.Show("A card must belong to a set!"); return;
            }
            // insert card
            Card newCard = new Card();
            newCard.front = frontTextbox.Text;
            newCard.back = backTextbox.Text;

            if (this.currentUser.flashcards.ContainsKey(setNameTextbox.Text))
            {
                currentUser.flashcards[topicDropdown.Text][setNameTextbox.Text].cards.Append(newCard);
            }
            else
            {
                Set newSet = new Set();
                newSet.topic = topicDropdown.Text;
                newSet.setname= setNameTextbox.Text;
                newSet.cards.Append(newCard);
                currentUser.flashcards[topicDropdown.Text].Add(newSet.setname, newSet);
            }
        }
    }
}
