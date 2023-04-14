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
    public partial class CreateFlashCards : Form
    {
        public DB mainDB;
        public User currentUser;
        public CreateFlashCards(DB mainDB, User currentUser)
        {
            InitializeComponent();
            this.mainDB = mainDB;
            this.currentUser = currentUser;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new FlashcardSets(this.mainDB, this.currentUser);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new HomePage(this.mainDB, this.currentUser);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new FlashcardSets(this.mainDB, this.currentUser);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new GameCatalog(this.mainDB, this.currentUser);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
=======
﻿using System;
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
    public partial class CreateFlashCards : Form
    {
        public CreateFlashCards()
        {
            InitializeComponent();
        }
    }
}
>>>>>>> Created a new form for creating cards, made changes to modify form. Messed around with the home form a bit, and made some mistakes :( I tries to not commit the changes I made to home form, but not sure if it'll work. Messed around with the code of the modify and create forms, tried to connect it to the database, tried to make the buttons functionable. But I still need to work on it cuz I messed up again. So ya'll will be able to see just the nonfunctional form. Buttons probably don't work.
