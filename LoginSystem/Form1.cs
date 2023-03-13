using MySql.Data.MySqlClient;

namespace LoginSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            signupPanel.Visible = false;
            loginPanel.Visible = true;
        }

        private void loginlink_Click(object sender, EventArgs e)
        {
            signupPanel.Visible = true;
            loginPanel.Visible = false;
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {

            db.openConnection();
            MySqlCommand command;
            if (sNameTxt.Text != "" & sEmailTxt.Text != "" & sPasswordTxt.Text != "" & sPasswordCTxt.Text != "")
            {
                if (sPasswordTxt.Text.Length < 8)
                {
                    sErrorLbl.Visible = true;
                    sErrorLbl.Text = "Password must  at least be 8 characters ";
                }
                else if (sPasswordTxt.Text != sPasswordCTxt.Text)
                {
                    sErrorLbl.Visible = true;
                    sErrorLbl.Text = "Password mismatch";
                }
                else
                {
                    try
                    {

                        string countQuery = "select count(*) from user where Email = '" + sEmailTxt.Text + "'";
                        command = new MySqlCommand(countQuery, db.connection);
                        Int32 count = Convert.ToInt32(command.ExecuteScalar());

                        if (count > 0)
                        {
                            sErrorLbl.Visible = true;
                            sErrorLbl.Text = "User already exists";
                            db.closeConnection();
                        }
                        else
                        {
                            string query = "insert into user(Name, Email, Pass, Passc) values ('" + sNameTxt.Text + "', '" + sEmailTxt.Text + "', '" + sPasswordTxt.Text + "', '" + sPasswordCTxt.Text + "')";
                            command = new MySqlCommand(query, db.connection);
                            command.ExecuteNonQuery();
                            db.closeConnection();
                            sErrorLbl.Visible = false;
                            MessageBox.Show("User created successfully");


                        }
                    }
                    catch (Exception ex)

                    {
                        // sErrorLbl.Visible = true;
                        // sErrorLbl.Text = ex.Message;
                    }
                }
            }
            else
            {
                sErrorLbl.Visible = true;
                sErrorLbl.Text = "Complete every field";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            db.openConnection();
            MySqlCommand command;
            if (emailTxt.Text != "" & passwordTxt.Text != "")
            {
                string countQuery = "select count(*) from user where Email = '" + emailTxt.Text + "'";
                command = new MySqlCommand(countQuery, db.connection);
                Int32 count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {

                    string query = "select * from user where Email= '" + emailTxt.Text + "' and Pass = '" + passwordTxt.Text + "'";
                    command = new MySqlCommand(query, db.connection);
                    Int32 countUser = Convert.ToInt32(command.ExecuteScalar());


                    db.closeConnection();
                    if (countUser > 0)
                    {
                        MessageBox.Show("Landing Screen");
                    }
                    else
                    {
                        lErrorbl.Visible = true;
                        lErrorbl.Text = "Invalid email or password";
                    }
                }
                else
                {
                    lErrorbl.Visible = true;
                    lErrorbl.Text = "User doesn't exist";
                }
            }
            else
            {
                lErrorbl.Visible = true;
                lErrorbl.Text = "Complete every field";
            }
        }
    }
}