using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CFromBox.Clear();
            CToBox.Clear();
            AirFromBox.Clear();
            AirToBox.Clear();
            DurationBox.Clear();
            PriceBox.Clear();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter VacationPass = new StreamWriter("vacation pass.txt", true))
            {
                VacationPass.WriteLine($"{CFromBox.Text}:{CToBox.Text}:{AirFromBox.Text}:{AirToBox.Text}:{DurationBox.Text}:{PriceBox.Text}");
                CFromBox.Clear();
                CToBox.Clear();
                AirFromBox.Clear();
                AirToBox.Clear();
                DurationBox.Clear();
                PriceBox.Clear();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormManager.Instance.CloseForm(FormType.ADMIN);
        }
    }
}
