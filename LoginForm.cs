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
using System.Security.Cryptography.X509Certificates;

namespace ADOExam
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        public static int userType; 

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            sqlCommand1.CommandType = CommandType.Text;
            sqlConnection1.Open();
            sqlCommand1.CommandText = "SELECT UserPassword FROM Users WHERE UserName = '" + textBoxLogin.Text + "'";
            string pass = (string)sqlCommand1.ExecuteScalar();
            sqlCommand1.CommandText = "SELECT UserType FROM Users WHERE UserName = '" + textBoxLogin.Text + "'";
            userType = Convert.ToInt32(sqlCommand1.ExecuteScalar());


            if (textBoxPassword.Text == pass)
            {
                MainFormAdmin form = new MainFormAdmin();
                form.Show();
                this.Hide();
                sqlConnection1.Close();
            }           
            else
            {
                MessageBox.Show("Неверный логин и/или пароль!");
                sqlConnection1.Close();
            }
           
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }       
    }
}
