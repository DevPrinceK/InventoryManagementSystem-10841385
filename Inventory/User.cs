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
            if (username.Text != "" && userPassword.Text != "" && userRole.Text != "")
            {
                // My sql connections
                DBCON.OpenConnection();
                MySqlCommand cmd;
                try
                {
                    string query = "INSERT INTO user(username, password, firstName, lastName, userRole, gender) values ('" + username.Text + "',  '" + userPassword.Text + "', '" + firstName.Text + "', '" + lastName.Text + "', '" + userRole.Text + "', '" + gender.Text + "')";
                    cmd = new MySqlCommand(query, DBCON.conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New User Created Successfully!");
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
                MessageBox.Show("Username, Password and Role fields must not be empty.");
            }
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
