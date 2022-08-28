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
    public partial class ProductCategory : Form
    {
        public ProductCategory()
        {
            InitializeComponent();
        }

        private void backhome_Click(object sender, EventArgs e)
        {
            this.Close();

            Home home = new Home();
            home.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            categoryName.Text = "";
            categoryDescription.Text = "";
            categoryID.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (categoryName.Text != "" && categoryDescription.Text != "" && categoryID.Text != "")
            {
                // My sql connections
                DBCON.OpenConnection();
                MySqlCommand cmd;
                try
                {
                    string query = "INSERT INTO category(id, name, description)";
                    cmd = new MySqlCommand(query, DBCON.conn);
                    cmd.Parameters.AddWithValue("@id", categoryID.Text);
                    cmd.Parameters.AddWithValue("@name", categoryName.Text);
                    cmd.Parameters.AddWithValue("@description", categoryDescription.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Category Created Successfully!");
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
                MessageBox.Show("All fields for product category must be entered.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
