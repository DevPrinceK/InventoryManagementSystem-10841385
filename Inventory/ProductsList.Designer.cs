namespace Inventory
{
    partial class ProductsListWindow
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.prodCategory,
            this.prodPrice,
            this.prodExpiryDate,
            this.prodDescription,
            this.tags});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1827, 672);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "Product ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.FillWeight = 500F;
            this.name.HeaderText = "Product Name";
            this.name.MinimumWidth = 100;
            this.name.Name = "name";
            this.name.Width = 500;
            // 
            // prodCategory
            // 
            this.prodCategory.FillWeight = 150F;
            this.prodCategory.HeaderText = "Product Category";
            this.prodCategory.MinimumWidth = 6;
            this.prodCategory.Name = "prodCategory";
            this.prodCategory.Width = 300;
            // 
            // prodPrice
            // 
            this.prodPrice.HeaderText = "Product Price";
            this.prodPrice.MinimumWidth = 6;
            this.prodPrice.Name = "prodPrice";
            this.prodPrice.Width = 200;
            // 
            // prodExpiryDate
            // 
            this.prodExpiryDate.FillWeight = 150F;
            this.prodExpiryDate.HeaderText = "Expiry Date";
            this.prodExpiryDate.MinimumWidth = 6;
            this.prodExpiryDate.Name = "prodExpiryDate";
            this.prodExpiryDate.Width = 200;
            // 
            // prodDescription
            // 
            this.prodDescription.FillWeight = 350F;
            this.prodDescription.HeaderText = "Product Description";
            this.prodDescription.MinimumWidth = 6;
            this.prodDescription.Name = "prodDescription";
            this.prodDescription.Width = 200;
            // 
            // tags
            // 
            this.tags.FillWeight = 200F;
            this.tags.HeaderText = "Product Tags";
            this.tags.MinimumWidth = 6;
            this.tags.Name = "tags";
            this.tags.Width = 200;
            // 
            // ProductsListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 672);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductsListWindow";
            this.Text = "Inventory | Products List";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn prodCategory;
        private DataGridViewTextBoxColumn prodPrice;
        private DataGridViewTextBoxColumn prodExpiryDate;
        private DataGridViewTextBoxColumn prodDescription;
        private DataGridViewTextBoxColumn tags;
    }
}