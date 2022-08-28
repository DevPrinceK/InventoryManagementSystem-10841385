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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        // extra code
        private Form CurrentWindow = null;

        private void SetCurrentWindow(Form formWindow)
        {
            if (CurrentWindow != null) CurrentWindow.Close();

            CurrentWindow = formWindow;
            formWindow.TopLevel = false;
            formWindow.FormBorderStyle = FormBorderStyle.None;
            formWindow.Dock = DockStyle.Fill;


            mainContentPanel.Controls.Add(formWindow);
            mainContentPanel.Tag = formWindow;


            formWindow.BringToFront();
            formWindow.Show();
            
        }
            

        private void Home_Load(object sender, EventArgs e)
        {

        }


        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();

            Login loginPage = new Login();
            loginPage.Show();
        }


        // generic method for setting the child of the mainContentPanel
       

        private void mainContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productsTab_Click(object sender, EventArgs e)
        {
            currentPageLabel.Text = "Products";

            AddProduct addProduct = new AddProduct();
            SetCurrentWindow(addProduct);
        }

        private void categoryTab_Click_1(object sender, EventArgs e)
        {
            currentPageLabel.Text = "Product Category";
            ProductCategory productCategory = new ProductCategory();
            SetCurrentWindow(productCategory);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentPageLabel.Text = "User Management";
            Users userPage = new Users();
            SetCurrentWindow(userPage);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentPageLabel.Text = "Transactions";
            mainContentPanel.Controls.Clear();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            currentPageLabel.Text = "Sales";
            mainContentPanel.Controls.Clear();

        }
    }
}
