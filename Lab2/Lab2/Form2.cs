using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form2 : Form
    {
        string login = "admin";
        string pass = "admin";

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormManager.Instance.ShowForm(FormType.REG);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormManager.Instance.CloseForm(FormType.LOG);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var surname = textBox1.Text;
            var password = textBox2.Text;
            textBox1.Text = "";
            textBox2.Text = "";
            if (IsAdmin(surname, password))
            {
                FormManager.Instance.ShowForm(FormType.ADMIN);
                return;
            }
            if (University.Instance.Login(surname, password))
                FormManager.Instance.ShowForm(FormType.STUDENT, surname);
            else
                MessageBox.Show("Error", "Please check the correct entry and try again.");
        }

        private bool IsAdmin(string surname, string password)
        {
            if(login.Equals(surname) && pass.Equals(password))
            {
                return true;
            }
            return false;
        }
    }
}
