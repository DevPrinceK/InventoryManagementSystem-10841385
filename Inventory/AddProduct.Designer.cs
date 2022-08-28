namespace Inventory
{
    partial class AddProduct
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
            this.productCategory = new System.Windows.Forms.ComboBox();
            this.prodQty = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.addProdBtn = new System.Windows.Forms.Button();
            this.prodTags = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.prodExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prodPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prodDescription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prodName = new System.Windows.Forms.TextBox();
            this.prod_name_lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodQty)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.productCategory);
            this.panel1.Controls.Add(this.prodQty);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.addProdBtn);
            this.panel1.Controls.Add(this.prodTags);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.prodExpiryDate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.prodPrice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.prodDescription);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.prodName);
            this.panel1.Controls.Add(this.prod_name_lb);
            this.panel1.Location = new System.Drawing.Point(264, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 619);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // productCategory
            // 
            this.productCategory.ForeColor = System.Drawing.Color.SteelBlue;
            this.productCategory.FormattingEnabled = true;
            this.productCategory.Items.AddRange(new object[] {
            "Beverage",
            "Vegetable"});
            this.productCategory.Location = new System.Drawing.Point(564, 348);
            this.productCategory.Name = "productCategory";
            this.productCategory.Size = new System.Drawing.Size(404, 31);
            this.productCategory.TabIndex = 19;
            this.productCategory.SelectedIndexChanged += new System.EventHandler(this.productCategory_SelectedIndexChanged);
            // 
            // prodQty
            // 
            this.prodQty.DecimalPlaces = 2;
            this.prodQty.ForeColor = System.Drawing.Color.SteelBlue;
            this.prodQty.Location = new System.Drawing.Point(564, 224);
            this.prodQty.Name = "prodQty";
            this.prodQty.Size = new System.Drawing.Size(404, 30);
            this.prodQty.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(781, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 48);
            this.button1.TabIndex = 16;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addProdBtn
            // 
            this.addProdBtn.BackColor = System.Drawing.Color.Navy;
            this.addProdBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addProdBtn.ForeColor = System.Drawing.Color.White;
            this.addProdBtn.Location = new System.Drawing.Point(81, 514);
            this.addProdBtn.Name = "addProdBtn";
            this.addProdBtn.Size = new System.Drawing.Size(663, 48);
            this.addProdBtn.TabIndex = 15;
            this.addProdBtn.Text = "Add Product";
            this.addProdBtn.UseVisualStyleBackColor = false;
            this.addProdBtn.Click += new System.EventHandler(this.addProdBtn_Click);
            // 
            // prodTags
            // 
            this.prodTags.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prodTags.Location = new System.Drawing.Point(564, 441);
            this.prodTags.Name = "prodTags";
            this.prodTags.Size = new System.Drawing.Size(404, 32);
            this.prodTags.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(564, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Product Tags";
            this.label7.UseWaitCursor = true;
            // 
            // prodExpiryDate
            // 
            this.prodExpiryDate.CalendarForeColor = System.Drawing.Color.SteelBlue;
            this.prodExpiryDate.CalendarTitleForeColor = System.Drawing.Color.SteelBlue;
            this.prodExpiryDate.CalendarTrailingForeColor = System.Drawing.Color.SteelBlue;
            this.prodExpiryDate.Location = new System.Drawing.Point(81, 447);
            this.prodExpiryDate.Name = "prodExpiryDate";
            this.prodExpiryDate.Size = new System.Drawing.Size(404, 30);
            this.prodExpiryDate.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(81, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Product Expiry Date";
            this.label6.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(564, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Product Category";
            this.label5.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(564, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Product Quantity";
            this.label4.UseWaitCursor = true;
            // 
            // prodPrice
            // 
            this.prodPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prodPrice.Location = new System.Drawing.Point(564, 94);
            this.prodPrice.Name = "prodPrice";
            this.prodPrice.Size = new System.Drawing.Size(404, 32);
            this.prodPrice.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(564, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product Price";
            this.label3.UseWaitCursor = true;
            // 
            // prodDescription
            // 
            this.prodDescription.Location = new System.Drawing.Point(81, 198);
            this.prodDescription.Name = "prodDescription";
            this.prodDescription.Size = new System.Drawing.Size(404, 181);
            this.prodDescription.TabIndex = 4;
            this.prodDescription.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(81, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Description";
            this.label2.UseWaitCursor = true;
            // 
            // prodName
            // 
            this.prodName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prodName.Location = new System.Drawing.Point(81, 94);
            this.prodName.Name = "prodName";
            this.prodName.Size = new System.Drawing.Size(404, 32);
            this.prodName.TabIndex = 1;
            // 
            // prod_name_lb
            // 
            this.prod_name_lb.AutoSize = true;
            this.prod_name_lb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prod_name_lb.Location = new System.Drawing.Point(81, 60);
            this.prod_name_lb.Name = "prod_name_lb";
            this.prod_name_lb.Size = new System.Drawing.Size(121, 23);
            this.prod_name_lb.TabIndex = 0;
            this.prod_name_lb.Text = "Product Name";
            this.prod_name_lb.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(668, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Product";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 720);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Name = "AddProduct";
            this.Text = " ";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label5;
        private Label label4;
        private TextBox prodPrice;
        private Label label3;
        private RichTextBox prodDescription;
        private Label label2;
        private TextBox prodName;
        private Label prod_name_lb;
        private Button addProdBtn;
        private TextBox prodTags;
        private Label label7;
        private DateTimePicker prodExpiryDate;
        private Label label6;
        private Button button1;
        private NumericUpDown prodQty;
        private ComboBox productCategory;
    }
}