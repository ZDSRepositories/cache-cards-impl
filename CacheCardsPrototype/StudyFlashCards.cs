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
    public partial class StudyFlashCards : Form
    {
        public DB mainDB;
        public User currentUser;
        public string workingSet;
        public StudyFlashCards(DB mainDB, User currentUser)
        {
            InitializeComponent();
            this.mainDB = mainDB;
            this.currentUser = currentUser;
           // this.workingSet = setname;
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

        
        private void backOfCardText_Click(object sender, EventArgs e)
        {
            backOfCard.SendToBack();
        }

        private void frontOfCardText_Click(object sender, EventArgs e)
        {
            frontOfCard.SendToBack();
        }

        private void StudyFlashCards_Load(object sender, EventArgs e)
        {
            if (this.currentUser.flashcards.Count > 0)
            {
                frontOfCardText.Text = currentUser.flashcards["databases"]["Test 1 Prep"].cards[0].front;
                backOfCardText.Text = currentUser.flashcards["databases"]["Test 1 Prep"].cards[0].back;
            }
        }

        private void knowItButton_Click(object sender, EventArgs e)
        {
            frontOfCardText.Text = currentUser.flashcards["databases"]["Test 1 Prep"].cards[1].front;
            backOfCardText.Text = currentUser.flashcards["databases"]["Test 1 Prep"].cards[1].back;
        }
    }
}
