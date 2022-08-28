namespace Inventory
{
    partial class Home
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
            this.sidePanel = new System.Windows.Forms.Panel();
            this.usersTab = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.productsTab = new System.Windows.Forms.Button();
            this.categoryTab = new System.Windows.Forms.Button();
            this.logoutTab = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.currentPageLabel = new System.Windows.Forms.Label();
            this.userIcon = new System.Windows.Forms.PictureBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mainContentPanel = new System.Windows.Forms.Panel();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.Navy;
            this.sidePanel.Controls.Add(this.usersTab);
            this.sidePanel.Controls.Add(this.label3);
            this.sidePanel.Controls.Add(this.button3);
            this.sidePanel.Controls.Add(this.button2);
            this.sidePanel.Controls.Add(this.button1);
            this.sidePanel.Controls.Add(this.iconBox);
            this.sidePanel.Controls.Add(this.productsTab);
            this.sidePanel.Controls.Add(this.categoryTab);
            this.sidePanel.Controls.Add(this.logoutTab);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(219, 563);
            this.sidePanel.TabIndex = 0;
            // 
            // usersTab
            // 
            this.usersTab.FlatAppearance.BorderSize = 0;
            this.usersTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersTab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usersTab.Location = new System.Drawing.Point(3, 313);
            this.usersTab.Name = "usersTab";
            this.usersTab.Size = new System.Drawing.Size(213, 62);
            this.usersTab.TabIndex = 6;
            this.usersTab.Text = "Users";
            this.usersTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersTab.UseVisualStyleBackColor = true;
            this.usersTab.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dashboard";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(3, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 62);
            this.button3.TabIndex = 5;
            this.button3.Text = "Sales";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(3, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 62);
            this.button2.TabIndex = 4;
            this.button2.Text = "Transactions";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 62);
            this.button1.TabIndex = 3;
            this.button1.Text = "Settings";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // iconBox
            // 
            this.iconBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.iconBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBox.Location = new System.Drawing.Point(0, 0);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(219, 76);
            this.iconBox.TabIndex = 0;
            this.iconBox.TabStop = false;
            // 
            // productsTab
            // 
            this.productsTab.FlatAppearance.BorderSize = 0;
            this.productsTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsTab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productsTab.Location = new System.Drawing.Point(0, 76);
            this.productsTab.Name = "productsTab";
            this.productsTab.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.productsTab.Size = new System.Drawing.Size(213, 62);
            this.productsTab.TabIndex = 2;
            this.productsTab.Text = "Products";
            this.productsTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productsTab.UseVisualStyleBackColor = true;
            this.productsTab.Click += new System.EventHandler(this.productsTab_Click);
            // 
            // categoryTab
            // 
            this.categoryTab.FlatAppearance.BorderSize = 0;
            this.categoryTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryTab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryTab.Location = new System.Drawing.Point(3, 125);
            this.categoryTab.Name = "categoryTab";
            this.categoryTab.Size = new System.Drawing.Size(213, 62);
            this.categoryTab.TabIndex = 1;
            this.categoryTab.Text = "Category";
            this.categoryTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryTab.UseVisualStyleBackColor = true;
            this.categoryTab.Click += new System.EventHandler(this.categoryTab_Click_1);
            // 
            // logoutTab
            // 
            this.logoutTab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutTab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logoutTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutTab.Location = new System.Drawing.Point(0, 501);
            this.logoutTab.Name = "logoutTab";
            this.logoutTab.Size = new System.Drawing.Size(219, 62);
            this.logoutTab.TabIndex = 0;
            this.logoutTab.Text = "Logout";
            this.logoutTab.UseVisualStyleBackColor = true;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.MediumVioletRed;
            this.topPanel.Controls.Add(this.currentPageLabel);
            this.topPanel.Controls.Add(this.userIcon);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(219, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1114, 76);
            this.topPanel.TabIndex = 1;
            // 
            // currentPageLabel
            // 
            this.currentPageLabel.AutoSize = true;
            this.currentPageLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentPageLabel.ForeColor = System.Drawing.Color.Cyan;
            this.currentPageLabel.Location = new System.Drawing.Point(6, 13);
            this.currentPageLabel.Name = "currentPageLabel";
            this.currentPageLabel.Size = new System.Drawing.Size(188, 45);
            this.currentPageLabel.TabIndex = 1;
            this.currentPageLabel.Text = "Dashboard";
            // 
            // userIcon
            // 
            this.userIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.userIcon.Location = new System.Drawing.Point(1029, 0);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(85, 76);
            this.userIcon.TabIndex = 0;
            this.userIcon.TabStop = false;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.bottomPanel.Controls.Add(this.label1);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(219, 507);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1114, 56);
            this.bottomPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copyright @2022. Powered by kpstechnologies";
            // 
            // mainContentPanel
            // 
            this.mainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContentPanel.Location = new System.Drawing.Point(219, 76);
            this.mainContentPanel.Name = "mainContentPanel";
            this.mainContentPanel.Size = new System.Drawing.Size(1114, 431);
            this.mainContentPanel.TabIndex = 3;
            this.mainContentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainContentPanel_Paint);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 563);
            this.Controls.Add(this.mainContentPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sidePanel);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Name = "Home";
            this.Text = "Inventory | Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel sidePanel;
        private Panel topPanel;
        private Panel bottomPanel;
        private Panel mainContentPanel;
        private Label label1;
        private Button productsTab;
        private Button categoryTab;
        private Button logoutTab;
        private Button button1;
        private Button button3;
        private Button button2;
        private PictureBox iconBox;
        private Label currentPageLabel;
        private PictureBox userIcon;
        private Label label3;
        private Button usersTab;
    }
}