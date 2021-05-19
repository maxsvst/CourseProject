using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProj
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Логин")
            {
                userNameField.ForeColor = Color.Black;
                userNameField.Text = "";
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.ForeColor = Color.Gray;
                userNameField.Text = "Логин";
             }
        }

        private void passwordField_Enter(object sender, EventArgs e)
        {
            if (passwordField.Text == "Пароль")
            {
                passwordField.UseSystemPasswordChar = true;
                passwordField.ForeColor = Color.Black;
                passwordField.Text = "";
            }
        }

        private void passwordField_Leave(object sender, EventArgs e)
        {
            if (passwordField.Text == "")
            {
                passwordField.UseSystemPasswordChar = false;
                passwordField.ForeColor = Color.Gray;
                passwordField.Text = "Пароль";
            }
        }

        private void createAccountLabel_Click(object sender, EventArgs e)
        {
            this.Hide();//Обращемся к текущему окну и скрываем его
            RegisterForm RF = new RegisterForm();
            RF.Show();
        }

        private void createAccountLabel_MouseEnter(object sender, EventArgs e)
        {
           createAccountLabel.ForeColor = Color.Black;
        }

        private void createAccountLabel_MouseLeave(object sender, EventArgs e)
        {
            createAccountLabel.ForeColor = Color.Gray;
        }

        public void Login_Click(object sender, EventArgs e)
        {
            
            string userLogin = userNameField.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            dataBase DB = new dataBase();
            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login = @nU and password = @pF", DB.getConnection());
            command.Parameters.Add("@pF", MySqlDbType.VarChar).Value = passwordField.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = userNameField.Text;

            
            adapter.SelectCommand = command;
            adapter.Fill(table);
            DB.openConnection();
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                User.applicationUser.id = reader.GetInt32(0);
                this.Hide();//Обращемся к текущему окну и скрываем его
                Menu M = new Menu();
                M.Show();
                DB.closeConnection();
            }
            else
                MessageBox.Show("Аккаунт не найден");
        }
    }
}  

