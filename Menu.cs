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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            diagramChart.Series[0].Points.AddXY(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
        }

        private void incomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();//Обращемся к текущему окну и скрываем его
            IncomeForm IF = new IncomeForm();
            IF.Show();
        }

        private void walletButton_Click(object sender, EventArgs e)
        {

        }

        private void expencesButton_Click(object sender, EventArgs e)
        {
            
        }

        private void statisticButton_Click(object sender, EventArgs e)
        {
            
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
