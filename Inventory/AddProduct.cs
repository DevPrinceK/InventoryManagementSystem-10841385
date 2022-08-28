using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            prodName.Text = "";
            prodPrice.Text = "";
            prodQty.Value = 0;
            prodExpiryDate.Text = "";
            prodDescription.Text = "";
            prodTags.Text = "";
        }

        private void backhome_Click(object sender, EventArgs e)
        {
            this.Close();

            Home home = new Home();
            home.Show();
        }

        private void addProdBtn_Click(object sender, EventArgs e)
        {
            string name = prodName.Text;
            string price = prodPrice.Text;
            string description = prodDescription.Text;
            string expiry = prodExpiryDate.Text;
            string tags = prodTags.Text;
            string quantity = prodQty.Text;

            DBCON db = new DBCON();

            

           

        }
    }
}
