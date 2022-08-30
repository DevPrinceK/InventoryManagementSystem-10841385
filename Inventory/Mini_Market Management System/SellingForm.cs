using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Moses_Market_Management_System;
using MySql.Data.MySqlClient;

namespace Moses_Market_Management_System
{
    public partial class SellingForm : Form
    {
        DBConnect dBCon = new DBConnect();
        DGVPrinter printer = new DGVPrinter();
        public SellingForm()
        {
            InitializeComponent();
        }

        private void getCategory()
        {
            string selectQuerry = "SELECT * FROM category";
            MySqlCommand command = new MySqlCommand(selectQuerry, dBCon.GetCon());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox_category.DataSource = table;
            comboBox_category.ValueMember = "name";
            
        }

        private void getTable()
        {
            string selectQuerry = "SELECT name, price FROM product";
            MySqlCommand command = new MySqlCommand(selectQuerry, dBCon.GetCon());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_product.DataSource = table;
        }
        private void getSellTable()
        {
            string selectQuerry = "SELECT * FROM sales";
            MySqlCommand command = new MySqlCommand(selectQuerry, dBCon.GetCon());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_sellList.DataSource = table;
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            label_date.Text = DateTime.Today.ToShortDateString();
            getTable();
            getCategory();
            getSellTable();
        }

        private void DataGridView_product_Click(object sender, EventArgs e)
        {
            name.Text = DataGridView_product.SelectedRows[0].Cells[0].Value.ToString();
            price.Text = DataGridView_product.SelectedRows[0].Cells[1].Value.ToString();
        }

        int grandTotal = 0, n = 0;

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Bill VALUES(" + TextBox_id.Text + "','" + label_date.Text + "'," + grandTotal.ToString() + ")";
                MySqlCommand command = new MySqlCommand(insertQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Order Added Successfully", "Order Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getSellTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            //We need DGVPrinter helper For PDF file
            printer.Title = "DCIT308 INVENTORY SYSTEM";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "foxlearn";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_sellList);
        }


        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void comboBox_category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuerry = "SELECT ProdName, ProdPrice FROM Product WHERE ProdCat='" + comboBox_category.SelectedValue.ToString() + "'";
            MySqlCommand command = new MySqlCommand(selectQuerry, dBCon.GetCon());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_product.DataSource = table;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_addOrder_Click(object sender, EventArgs e)
        {
            if(name.Text != "" && productPrice.Text != "" && quantity.Text != "")
            {
                try
                {
                    private int total = 0;
                    private int price = Int32.Parse(productPrice.Text);

                    string insertQuery = "INSERT INTO sales(product, price, quantity, total) VALUES('" + name.Text + "', '" + pproductPricerice.Text + "', '" + quantity.Text + "', '" + total + "')";
                    MySqlCommand command = new MySqlCommand(insertQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Sales Item Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    getTable();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
    }
}
