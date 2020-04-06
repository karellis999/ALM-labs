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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var formReg = this;
            var formLog = new Form2();
            var formAdmin = new Form3();
            var formStudent = new Form4();
            FormManager.Instance.InitForms(formReg, formLog, formAdmin, formStudent);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormManager.Instance.ShowForm(FormType.LOG);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var surname = SurnameBox.Text;
                var name = NameBox.Text;
                var course = Int32.Parse(CourseBox.Text);
                var group = GroupBox.Text;
                var password = PasswordBox.Text;
                Student student = new Student(surname, name, course, group, password);
                University.Instance.RegisterStudent(student);
                FormManager.Instance.ShowForm(FormType.STUDENT, surname);
            } catch (Exception ex) {
                MessageBox.Show("Please check the correct entry and try again.", "Error!");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.File.WriteAllText("students.txt", string.Empty);
            using (StreamWriter stream = new StreamWriter("students.txt", true))
            {
                foreach (Student student in University.Instance.students)
                {
                    stream.WriteLine($"{student.Surname}:{student.Name}:{student.Course}:{student.Group}:{student.Password}");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (StreamReader stream = new StreamReader("students.txt"))
            {
                string[] str = new string[5];
                List<Student> students = new List<Student>();

                do
                {
                    str = stream.ReadLine().Split(':');
                    Student student = new Student(str[0], str[1], Int32.Parse(str[2]), str[3], str[4]);
                    students.Add(student);
                } while (!stream.EndOfStream);

                University.Instance.students = students;
            }

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
        }
    }
}
