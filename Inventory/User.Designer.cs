namespace Inventory
{
    partial class Users
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearTextBox = new System.Windows.Forms.Button();
            this.createUser = new System.Windows.Forms.Button();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.userRole = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.clearTextBox);
            this.panel1.Controls.Add(this.createUser);
            this.panel1.Controls.Add(this.userPassword);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.gender);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.userRole);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.firstName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lastName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(284, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 560);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // clearTextBox
            // 
            this.clearTextBox.BackColor = System.Drawing.Color.IndianRed;
            this.clearTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearTextBox.ForeColor = System.Drawing.Color.White;
            this.clearTextBox.Location = new System.Drawing.Point(685, 445);
            this.clearTextBox.Name = "clearTextBox";
            this.clearTextBox.Size = new System.Drawing.Size(193, 52);
            this.clearTextBox.TabIndex = 18;
            this.clearTextBox.Text = "Clear";
            this.clearTextBox.UseVisualStyleBackColor = false;
            this.clearTextBox.Click += new System.EventHandler(this.clearTextBox_Click);
            // 
            // createUser
            // 
            this.createUser.BackColor = System.Drawing.Color.Navy;
            this.createUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createUser.ForeColor = System.Drawing.Color.White;
            this.createUser.Location = new System.Drawing.Point(149, 445);
            this.createUser.Name = "createUser";
            this.createUser.Size = new System.Drawing.Size(515, 52);
            this.createUser.TabIndex = 17;
            this.createUser.Text = "Add User";
            this.createUser.UseVisualStyleBackColor = false;
            this.createUser.Click += new System.EventHandler(this.createUser_Click);
            // 
            // userPassword
            // 
            this.userPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userPassword.Location = new System.Drawing.Point(532, 341);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(346, 34);
            this.userPassword.TabIndex = 16;
            this.userPassword.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(532, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Password";
            this.label7.UseMnemonic = false;
            // 
            // gender
            // 
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gender.ForeColor = System.Drawing.Color.SteelBlue;
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Non-Binary"});
            this.gender.Location = new System.Drawing.Point(149, 220);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(346, 36);
            this.gender.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(532, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Role";
            // 
            // userRole
            // 
            this.userRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userRole.FormattingEnabled = true;
            this.userRole.Items.AddRange(new object[] {
            "Attendant",
            "Admin",
            "Staff"});
            this.userRole.Location = new System.Drawing.Point(532, 220);
            this.userRole.Name = "userRole";
            this.userRole.Size = new System.Drawing.Size(346, 36);
            this.userRole.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(149, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gender";
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstName.Location = new System.Drawing.Point(149, 115);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(346, 34);
            this.firstName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(149, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "First Name";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username.Location = new System.Drawing.Point(149, 341);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(346, 34);
            this.username.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(149, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Username";
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastName.Location = new System.Drawing.Point(532, 115);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(346, 34);
            this.lastName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(532, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(634, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Management";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1335, 609);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Name = "Users";
            this.Text = "Inventory | User Management";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox firstName;
        private Label label3;
        private TextBox username;
        private Label label4;
        private TextBox lastName;
        private Label label5;
        private Label label1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private ComboBox userRole;
        private Label label6;
        private Button clearTextBox;
        private Button createUser;
        private TextBox userPassword;
        private Label label7;
        private ComboBox gender;
    }
}