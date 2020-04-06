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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormManager.Instance.CloseForm(FormType.STUDENT);
        }

        public void SetName(string name)
        {
            labelName.Text = name.ToUpper();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            using (StreamReader stream = new StreamReader("vacation pass.txt"))
            {
                string[] str = new string[6];
                List<VacationPass> vacations = new List<VacationPass>();

                do
                {
                    str = stream.ReadLine().Split(':');

                    VacationPass vactionPass = new VacationPass(str[0], str[1], str[2], str[3], Int32.Parse(str[4]), Int32.Parse(str[5]));
                    vacations.Add(vactionPass);
                } while (!stream.EndOfStream);

                University.Instance.Vacations = vacations;
            }
            foreach (VacationPass vacation in University.Instance.Vacations)
            {
                vacationList.Items.Add($"{vacation.CountryFrom} - {vacation.CountryTo} : {vacation.Price}");
            }
            if(vacationList.Items.Count > 0)
                vacationList.SelectedIndex = 0;
        }

        private void vacationList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (vacationList.SelectedIndex < 0)
            {
                CFromBox.Text = "";
                CToBox.Text = "";
                AirFromBox.Text = "";
                AirToBox.Text = "";
                DurationBox.Text = "";
                PriceBox.Text = "";
                return;
            }
            VacationPass vacationPass = University.Instance.GetVacationPass(vacationList.SelectedItem.ToString());
            CFromBox.Text = vacationPass.CountryFrom;
            CToBox.Text = vacationPass.CountryTo;
            AirFromBox.Text = vacationPass.AirportFrom;
            AirToBox.Text = vacationPass.AirportTo;
            DurationBox.Text = vacationPass.Duration.ToString();
            PriceBox.Text = vacationPass.Price.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (vacationList.SelectedIndex < 0)
            {
                MessageBox.Show("Please check the correct entry and try again.", "Error!");
            }
            VacationPass vacationPass = University.Instance.GetVacationPass(vacationList.SelectedItem.ToString());
            MessageBox.Show($"You have offer vacation pass to {vacationPass.CountryTo} for {vacationPass.Price}.", "Congrats");
            vacationList.SelectedIndex = -1;
        }
    }
}
