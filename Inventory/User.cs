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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            Home home = new Home();
            home.Show();
        }

        private void createUser_Click(object sender, EventArgs e)
        {

        }

        private void clearTextBox_Click(object sender, EventArgs e)
        {
            firstName.Text = "";
            lastName.Text = "";
            username.Text = "";
            userPassword.Text = "";

        }
    }
}
