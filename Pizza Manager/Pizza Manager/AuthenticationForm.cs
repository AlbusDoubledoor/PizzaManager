using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Pizza_Manager
{
    public partial class AuthenticationForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["PizzaManagerConnectionString"].ConnectionString;
        public AuthenticationForm()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {

            using
                 (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                }
                catch
                {
                    MessageBox.Show("Ошибка подключения к базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SqlCommand requestauth = new SqlCommand("SELECT dbo.AuthUser('" +
                    LoginTextbox.Text + "','" + PasswordTextbox.Text + "')", connection);
                string result = requestauth.ExecuteScalar().ToString();
                connection.Close();
                if (result == "Fail")
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    InitiateNewForm(result);
                    this.Hide();
                }
                LoginTextbox.Clear();
                PasswordTextbox.Clear();
                LoginTextbox.Focus();
            }
        }

        private void InitiateNewForm(string result)
        {
            if (result == "headmanager")
            {
                HeadmanagerForm headmanagerForm = new HeadmanagerForm();
                headmanagerForm.Owner = this;
                headmanagerForm.Show();
            }
            if (result == "manager")
            {
                ManagerForm managerForm = new ManagerForm();
                managerForm.Owner = this;
                string officecode = "";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT dbo.GetOfficeCode('" + LoginTextbox.Text + "')",connection);
                    officecode = (string)command.ExecuteScalar();
                    connection.Close();
                }
                managerForm.officeCodePropagation = officecode;
                managerForm.Show();
            }
            if (result == "admin")
                Application.Exit();
        }
    }
}
