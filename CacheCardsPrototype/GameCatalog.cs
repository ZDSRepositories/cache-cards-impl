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
    public partial class GameCatalog : Form
    {
        public DB mainDB;
        public User currentUser;
        public GameCatalog(DB mainDB, User currentUser)
        {
            InitializeComponent();
            this.mainDB = mainDB;
            this.currentUser = currentUser;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
