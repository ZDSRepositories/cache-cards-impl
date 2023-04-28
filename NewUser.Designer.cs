namespace CacheCardsPrototype
{
    partial class NewUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newUsernameTxtbox = new System.Windows.Forms.TextBox();
            this.passwordTxtbox = new System.Windows.Forms.TextBox();
            this.confPasswordTxtbox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.confPassLabel = new System.Windows.Forms.Label();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newUsernameTxtbox
            // 
            this.newUsernameTxtbox.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newUsernameTxtbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.newUsernameTxtbox.Location = new System.Drawing.Point(238, 173);
            this.newUsernameTxtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newUsernameTxtbox.Name = "newUsernameTxtbox";
            this.newUsernameTxtbox.Size = new System.Drawing.Size(396, 33);
            this.newUsernameTxtbox.TabIndex = 2;
            // 
            // passwordTxtbox
            // 
            this.passwordTxtbox.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTxtbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.passwordTxtbox.Location = new System.Drawing.Point(238, 240);
            this.passwordTxtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordTxtbox.Name = "passwordTxtbox";
            this.passwordTxtbox.Size = new System.Drawing.Size(396, 33);
            this.passwordTxtbox.TabIndex = 3;
            // 
            // confPasswordTxtbox
            // 
            this.confPasswordTxtbox.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confPasswordTxtbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.confPasswordTxtbox.Location = new System.Drawing.Point(238, 314);
            this.confPasswordTxtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confPasswordTxtbox.Name = "confPasswordTxtbox";
            this.confPasswordTxtbox.Size = new System.Drawing.Size(396, 33);
            this.confPasswordTxtbox.TabIndex = 4;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Consolas", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.usernameLabel.Location = new System.Drawing.Point(238, 150);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(240, 22);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Please enter a username";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.BackColor = System.Drawing.Color.Transparent;
            this.passLabel.Font = new System.Drawing.Font("Consolas", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.passLabel.Location = new System.Drawing.Point(238, 217);
            this.passLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(240, 22);
            this.passLabel.TabIndex = 6;
            this.passLabel.Text = "Please enter a password";
            // 
            // confPassLabel
            // 
            this.confPassLabel.AutoSize = true;
            this.confPassLabel.BackColor = System.Drawing.Color.Transparent;
            this.confPassLabel.Font = new System.Drawing.Font("Consolas", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confPassLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.confPassLabel.Location = new System.Drawing.Point(238, 291);
            this.confPassLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.confPassLabel.Name = "confPassLabel";
            this.confPassLabel.Size = new System.Drawing.Size(170, 22);
            this.confPassLabel.TabIndex = 7;
            this.confPassLabel.Text = "confirm password";
            // 
            // createAccountButton
            // 
            this.createAccountButton.AutoSize = true;
            this.createAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.createAccountButton.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createAccountButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.createAccountButton.Location = new System.Drawing.Point(342, 365);
            this.createAccountButton.Margin = new System.Windows.Forms.Padding(30, 4, 5, 19);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(179, 32);
            this.createAccountButton.TabIndex = 15;
            this.createAccountButton.Text = "CREATE ACCOUNT";
            this.createAccountButton.UseVisualStyleBackColor = false;
            this.createAccountButton.Click += new System.EventHandler(this.createAccount_Click);
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CacheCardsPrototype.Properties.Resources.cachecards_background;
            this.ClientSize = new System.Drawing.Size(880, 541);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.confPassLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.confPasswordTxtbox);
            this.Controls.Add(this.passwordTxtbox);
            this.Controls.Add(this.newUsernameTxtbox);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "NewUser";
            this.Text = "New User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox newUsernameTxtbox;
        private TextBox passwordTxtbox;
        private TextBox confPasswordTxtbox;
        private Label usernameLabel;
        private Label passLabel;
        private Label confPassLabel;
        private Button createAccountButton;
    }
}