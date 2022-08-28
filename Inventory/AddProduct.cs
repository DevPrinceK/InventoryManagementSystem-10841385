using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            if (prodName.Text != "" && prodExpiryDate.Text != "" && prodPrice.Text != "")
            {
                // My sql connections
                DBCON.OpenConnection();
                MySqlCommand cmd;
                try
                {
                    string query = "INSERT INTO product(name, category, price, quantity, description, expiryDate, tags) values ('" + prodName.Text + "',  '" + productCategory.Text + "', '" + prodPrice.Text + "', '" + prodQty.Text + "', '" + prodDescription.Text + "', '" + prodExpiryDate.MaxDate + "',  '" + prodTags.Text +"')";
                    cmd = new MySqlCommand(query, DBCON.conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Product Created Successfully!");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    DBCON.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Product Name, Expiry date and Price fields must not be empty.");
            }

        }

        private void productCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
