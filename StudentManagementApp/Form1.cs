using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementApp;


namespace StudentManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                string username = Username.Text;
                string password = Password.Text;

                // Check if the user provided both username and password
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    Error.Text = "Please enter both username and password.";
                    Error.ForeColor = Color.Red;
                    return;
                }

                // Validate the user credentials using the SQLHelper class
                if (SQLHelper.ValidateUser(username, password))
                {
                    // If login is successful, show the StudentForm and hide the LoginForm
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StudentForm studentForm = new StudentForm();
                    studentForm.Show(); // Show the student management form
                    this.Hide(); // Hide the login form
                }
                else
                {
                    // If login fails, show an error message
                    Error.Text = "Invalid username or password.";
                    Error.ForeColor = Color.Red;
                }
            }
        }
    }
}