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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void regUserNameField_Enter(object sender, EventArgs e)
        {
            if (regUserNameField.Text == "Логин")
            {
                regUserNameField.ForeColor = Color.Black;
                regUserNameField.Text = "";
            }
        }

        private void regUserNameField_Leave(object sender, EventArgs e)
        {
            if (regUserNameField.Text == "")
            {
                regUserNameField.ForeColor = Color.Gray;
                regUserNameField.Text = "Логин";
            }
        }

        private void regPasswordField_Enter(object sender, EventArgs e)
        {
            if (regPasswordField.Text == "Пароль")
            {
                regPasswordField.UseSystemPasswordChar = true;
                regPasswordField.ForeColor = Color.Black;
                regPasswordField.Text = "";
            }
        }

        private void regPasswordField_Leave(object sender, EventArgs e)
        {
            if (regPasswordField.Text == "")
            {
                regPasswordField.UseSystemPasswordChar = false;
                regPasswordField.ForeColor = Color.Gray;
                regPasswordField.Text = "Пароль";
            }
        }

        private void secondPasswordField_Enter(object sender, EventArgs e)
        {
            if (secondPasswordField.Text == "Повторите пароль")
            {
                secondPasswordField.UseSystemPasswordChar = true;
                secondPasswordField.ForeColor = Color.Black;
                secondPasswordField.Text = "";
            }
        }

        private void secondPasswordField_Leave(object sender, EventArgs e)
        {
            if (secondPasswordField.Text == "")
            {
                secondPasswordField.UseSystemPasswordChar = false;
                secondPasswordField.ForeColor = Color.Gray;
                secondPasswordField.Text = "Повторите пароль";
            }
        }

        private void emailField_Enter(object sender, EventArgs e)
        {
            if (emailField.Text == "Email")
            {
                emailField.ForeColor = Color.Black;
                emailField.Text = "";
            }
        }

        private void emailField_Leave(object sender, EventArgs e)
        {
            if (emailField.Text == "")
            {
                emailField.ForeColor = Color.Gray;
                emailField.Text = "Email";
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (regUserNameField.Text == "Логин")
            {
                MessageBox.Show("Вы забыли ввести имя");
                return;
            }

            if (regPasswordField.Text == "Пароль")
            {
                MessageBox.Show("Вы забыли ввести пароль");
                return;
            }

            if (emailField.Text == "Email")
            {
                MessageBox.Show("Вы забыли ввести email");
                return;
            }
            else if (!emailField.Text.Contains("@") || !emailField.Text.Contains("."))
            {
                MessageBox.Show("Email введён некорректно");
                return;
            }

            if (secondPasswordField.Text == "Повторить пароль")
            {
                MessageBox.Show("Вы забыли ввести пароль ещё раз");
                return;
            }
            else if (secondPasswordField.Text != regPasswordField.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }

            if (CheckUserExist())
                return;

            dataBase DB = new dataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `email`) VALUES (@login, @password, @email);", DB.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = regUserNameField.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = regPasswordField.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = emailField.Text;

            // создаём форму с указанным значением
            var dialogForm = new System.Windows.Forms.Form
            {
                Size = new Size(203, 110),
                ShowIcon = false,
                Name = "DialogForm",
                Text = @"Введите код подтверждения",
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog,
                MinimizeBox = false,
                MaximizeBox = false
            };

            // поле ввода
            var textBox = new System.Windows.Forms.TextBox 
            { 
                Name = "InputText", Size = new Size(165, 20) 
            };
            // кладём не форму
            dialogForm.Controls.Add(textBox);
            // положение на форме
            textBox.Location = new Point(12, 12);
            // кнопка ok
            var okButton = new System.Windows.Forms.Button 
            {
                Name = "OKButton", Text = @"OK", Size = new Size(75, 23) 
            };
            // кладём не форму
            dialogForm.Controls.Add(okButton);
            // положение на форме
            okButton.Location = new Point(20, 38);
            // обработка события
            okButton.Click += (delegate 
            {
                dialogForm.DialogResult = System.Windows.Forms.DialogResult.OK; 
            });
            // кнопка отмены
            var cancelButton = new System.Windows.Forms.Button 
            {
                Name = "CancelButton", Text = @"Отмена", Size = new Size(75, 23) 
            };
            // кладём не форму
            dialogForm.Controls.Add(cancelButton);
            // положение на форме
            cancelButton.Location = new Point(100, 38);
            // обработка события
            cancelButton.Click += delegate 
            {
                dialogForm.DialogResult = System.Windows.Forms.DialogResult.Cancel; 
            };
            // показывем форму
            var dialogResult = dialogForm.ShowDialog();

            // если не было отмены диалога
            //if (dialogResult != System.Windows.Forms.DialogResult.Cancel) return RegisterForm.Variables["sms"].Value = textBox.Text.ToString();
            //project.SendErrorToLog("", "Данные не введены", true);
            //throw new Exception("Данные не введены");

            DB.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт был создан");

            }
            else
                MessageBox.Show("Аккаунт не был создан");

            DB.closeConnection();

            this.Hide();//Обращемся к текущему окну и скрываем его
            LoginForm LF = new LoginForm();
            LF.Show();
        }

        public Boolean CheckUserExist()
        {
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            dataBase DB = new dataBase();
            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login = @nU ", DB.getConnection());

            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = regUserNameField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует, введите другой");
                return true;
            }
            else

                return false;

        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            this.Hide();//Обращемся к текущему окну и скрываем его
            LoginForm LF = new LoginForm();
            LF.Show();
        }

        private void loginLabel_MouseEnter(object sender, EventArgs e)
        {
            loginLabel.ForeColor = Color.Black;
        }

        private void loginLabel_MouseLeave(object sender, EventArgs e)
        {
            loginLabel.ForeColor = Color.Gray;
        }
    }
}
