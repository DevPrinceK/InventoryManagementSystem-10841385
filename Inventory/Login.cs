using MySql.Data.MySqlClient;

namespace Inventory
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            
            if (username.Text != "" && Password.Text != "")
            {
                // My sql connections
                DBCON.OpenConnection();
                MySqlCommand cmd;

                try
                {
                    bool userExist;
                    string query = "Select * from user where username = '" + username.Text + "' && password ='" + userPassword.Text + "'";

                    cmd = new MySqlCommand(query, DBCON.conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    if (reader.HasRows)
                    {
                        userExist = true;
                    } else
                    {
                        userExist = false;
                    }
                    reader.Close();

                    if (userExist)
                    {
                        // hide current screen and navigate to the next
                        this.Hide();
                        Home home = new Home();
                        home.Show();

                    }
                    else
                    {
                        MessageBox.Show("No User Found For these Credentials");
                    }
                }
                catch(MySqlException ex)
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
                MessageBox.Show("Username and Password Must Be Entered");
            }
            


        }

        private void home_Click(object sender, EventArgs e)
        {
            // hide current screen and navigate to the next
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}