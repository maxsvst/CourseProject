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
    public partial class IncomeForm : Form
    {
        public IncomeForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void IncomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void sumField_Enter(object sender, EventArgs e)
        {
            sumField.ForeColor = Color.Black;
            if (sumField.Text == "Сумма")
            {
                sumField.Text = "";
            }
        }

        private void sumField_Leave(object sender, EventArgs e)
        {
            if (sumField.Text == "")
            {
                sumField.Text = "Сумма";
            }
        }

        private void commentField_Leave(object sender, EventArgs e)
        {
            if (commentField.Text == "")
            {
                commentField.Text = "Комментарий";
            }
        }

        private void commentField_Enter(object sender, EventArgs e)
        {
            if (commentField.Text == "Комментарий")
            {
                commentField.Text = "";
            }
        }

        private void addIncomeButton_Click(object sender, EventArgs e)
        {
            dataBase DB = new dataBase();

            MySqlCommand getIdCommand = new MySqlCommand("SELECT 'user_id' FROM users WHERE 'login' = @login");
            getIdCommand.Parameters.Add("@login", MySqlDbType.VarChar).Value = LoginForm. ;

            MySqlCommand command = new MySqlCommand("INSERT INTO `operations` (`money_type`, `type`, `sum`, `date`, `category`, `comment`) VALUES (@money_type, @type, @sum, @date, @category, @comment);", DB.getConnection());

            if (cardCheck.Checked == true)
                command.Parameters.Add("@money_type", MySqlDbType.VarChar).Value = "card";
            else
                command.Parameters.Add("@money_type", MySqlDbType.VarChar).Value = "cash";


            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = "income";

            bool sum_check;
            try
            {
                Convert.ToDouble(sumField.Text);
                sum_check = true;
            }
            catch (FormatException)
            {
                sum_check = false;
            }
            command.Parameters.Add("@sum", MySqlDbType.VarChar).Value = sumField.Text;
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = dateField.Value.ToShortDateString();
            command.Parameters.Add("@category", MySqlDbType.VarChar).Value = sourceField.Text;
            command.Parameters.Add("@comment", MySqlDbType.VarChar).Value = commentField.Text;

            if (sum_check) { 
            DB.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Доход был успешно добавлен");

            }
            else
                MessageBox.Show("Доход добавлен не был");

            DB.closeConnection();

            this.Hide();//Обращемся к текущему окну и скрываем его
            Menu LF = new Menu();
            LF.Show();
            }
            else
            {
                MessageBox.Show("Сумма была введена некорректно!");
                sumField.ForeColor = Color.Red;
            }
        }

        private void cardCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cardCheck.Checked == true)
            cashCheck.Checked = false;
        }

        private void cashCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cashCheck.Checked == true)
            cardCheck.Checked = false;
        }
    }
}
