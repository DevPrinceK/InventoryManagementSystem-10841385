namespace Moses_Market_Management_System
{
    partial class adminForm
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
            this.logoutTab = new System.Windows.Forms.Button();
            this.reorderTab = new System.Windows.Forms.Button();
            this.salesTab = new System.Windows.Forms.Button();
            this.SellerTab = new System.Windows.Forms.Button();
            this.poductTab = new System.Windows.Forms.Button();
            this.categoryTab = new System.Windows.Forms.Button();
            this.adminFormPanel = new System.Windows.Forms.Panel();
            this.navbarPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sidePanel.SuspendLayout();
            this.navbarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.Navy;
            this.sidePanel.Controls.Add(this.logoutTab);
            this.sidePanel.Controls.Add(this.reorderTab);
            this.sidePanel.Controls.Add(this.salesTab);
            this.sidePanel.Controls.Add(this.SellerTab);
            this.sidePanel.Controls.Add(this.poductTab);
            this.sidePanel.Controls.Add(this.categoryTab);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(5);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(318, 692);
            this.sidePanel.TabIndex = 0;
            this.sidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.adminFormPanel_Paint);
            // 
            // logoutTab
            // 
            this.logoutTab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.logoutTab.ForeColor = System.Drawing.Color.White;
            this.logoutTab.Location = new System.Drawing.Point(0, 634);
            this.logoutTab.Margin = new System.Windows.Forms.Padding(5);
            this.logoutTab.Name = "logoutTab";
            this.logoutTab.Size = new System.Drawing.Size(318, 58);
            this.logoutTab.TabIndex = 5;
            this.logoutTab.Text = "Logout";
            this.logoutTab.UseVisualStyleBackColor = true;
            this.logoutTab.Click += new System.EventHandler(this.logoutTab_Click);
            // 
            // reorderTab
            // 
            this.reorderTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.reorderTab.FlatAppearance.BorderSize = 0;
            this.reorderTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reorderTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.reorderTab.ForeColor = System.Drawing.Color.White;
            this.reorderTab.Location = new System.Drawing.Point(0, 232);
            this.reorderTab.Margin = new System.Windows.Forms.Padding(5);
            this.reorderTab.Name = "reorderTab";
            this.reorderTab.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.reorderTab.Size = new System.Drawing.Size(318, 58);
            this.reorderTab.TabIndex = 4;
            this.reorderTab.Text = "Reorder";
            this.reorderTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reorderTab.UseVisualStyleBackColor = true;
            // 
            // salesTab
            // 
            this.salesTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.salesTab.FlatAppearance.BorderSize = 0;
            this.salesTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.salesTab.ForeColor = System.Drawing.Color.White;
            this.salesTab.Location = new System.Drawing.Point(0, 174);
            this.salesTab.Margin = new System.Windows.Forms.Padding(5);
            this.salesTab.Name = "salesTab";
            this.salesTab.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.salesTab.Size = new System.Drawing.Size(318, 58);
            this.salesTab.TabIndex = 3;
            this.salesTab.Text = "Sales";
            this.salesTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesTab.UseVisualStyleBackColor = true;
            this.salesTab.Click += new System.EventHandler(this.salesTab_Click);
            // 
            // SellerTab
            // 
            this.SellerTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.SellerTab.FlatAppearance.BorderSize = 0;
            this.SellerTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellerTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SellerTab.ForeColor = System.Drawing.Color.White;
            this.SellerTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SellerTab.Location = new System.Drawing.Point(0, 116);
            this.SellerTab.Margin = new System.Windows.Forms.Padding(5);
            this.SellerTab.Name = "SellerTab";
            this.SellerTab.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.SellerTab.Size = new System.Drawing.Size(318, 58);
            this.SellerTab.TabIndex = 2;
            this.SellerTab.Text = "Seller";
            this.SellerTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SellerTab.UseVisualStyleBackColor = true;
            this.SellerTab.Click += new System.EventHandler(this.SellerTab_Click);
            // 
            // poductTab
            // 
            this.poductTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.poductTab.FlatAppearance.BorderSize = 0;
            this.poductTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.poductTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.poductTab.ForeColor = System.Drawing.Color.White;
            this.poductTab.Location = new System.Drawing.Point(0, 58);
            this.poductTab.Margin = new System.Windows.Forms.Padding(5);
            this.poductTab.Name = "poductTab";
            this.poductTab.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.poductTab.Size = new System.Drawing.Size(318, 58);
            this.poductTab.TabIndex = 1;
            this.poductTab.Text = "Product";
            this.poductTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.poductTab.UseVisualStyleBackColor = true;
            this.poductTab.Click += new System.EventHandler(this.poductTab_Click);
            // 
            // categoryTab
            // 
            this.categoryTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoryTab.FlatAppearance.BorderSize = 0;
            this.categoryTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.categoryTab.ForeColor = System.Drawing.Color.White;
            this.categoryTab.Location = new System.Drawing.Point(0, 0);
            this.categoryTab.Margin = new System.Windows.Forms.Padding(5);
            this.categoryTab.Name = "categoryTab";
            this.categoryTab.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.categoryTab.Size = new System.Drawing.Size(318, 58);
            this.categoryTab.TabIndex = 0;
            this.categoryTab.Text = "Category";
            this.categoryTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryTab.UseVisualStyleBackColor = true;
            this.categoryTab.Click += new System.EventHandler(this.categoryTab_Click);
            // 
            // adminFormPanel
            // 
            this.adminFormPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.adminFormPanel.Location = new System.Drawing.Point(318, 57);
            this.adminFormPanel.Margin = new System.Windows.Forms.Padding(5);
            this.adminFormPanel.Name = "adminFormPanel";
            this.adminFormPanel.Size = new System.Drawing.Size(1016, 635);
            this.adminFormPanel.TabIndex = 1;
            // 
            // navbarPanel
            // 
            this.navbarPanel.BackColor = System.Drawing.Color.Navy;
            this.navbarPanel.Controls.Add(this.label1);
            this.navbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbarPanel.Location = new System.Drawing.Point(318, 0);
            this.navbarPanel.Margin = new System.Windows.Forms.Padding(4);
            this.navbarPanel.Name = "navbarPanel";
            this.navbarPanel.Size = new System.Drawing.Size(1016, 58);
            this.navbarPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 Blk BT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(297, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shoprite Ghana Limited";
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 692);
            this.Controls.Add(this.navbarPanel);
            this.Controls.Add(this.adminFormPanel);
            this.Controls.Add(this.sidePanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "adminForm";
            this.Text = "DCIT318 IA | Admin";
            this.sidePanel.ResumeLayout(false);
            this.navbarPanel.ResumeLayout(false);
            this.navbarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button logoutTab;
        private System.Windows.Forms.Button reorderTab;
        private System.Windows.Forms.Button salesTab;
        private System.Windows.Forms.Button SellerTab;
        private System.Windows.Forms.Button poductTab;
        private System.Windows.Forms.Button categoryTab;
        private System.Windows.Forms.Panel adminFormPanel;
        private System.Windows.Forms.Panel navbarPanel;
        private System.Windows.Forms.Label label1;
    }
}