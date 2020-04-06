using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    enum FormType
    {
        LOG,
        REG,
        ADMIN,
        STUDENT
    }

    class FormManager
    {
        private static FormManager instance;

        public Form1 formReg;
        public Form2 formLog;
        public Form3 formAdmin;
        public Form4 formStudent;

        public static FormManager Instance
        {
            get
            {
                if(FormManager.instance == null)
                {
                    FormManager.instance = new FormManager();
                }
                return FormManager.instance;
            }
        }

        public void InitForms(Form1 formReg, Form2 formLog, Form3 formAdmin, Form4 formStudent)
        {
            this.formReg = formReg;
            this.formLog = formLog;
            this.formAdmin = formAdmin;
            this.formStudent = formStudent;
        }

        public void ShowForm(FormType type, string surname = "")
        {
            switch(type)
            {
                case FormType.REG:
                    this.formReg.Show();
                    this.formLog.Hide();
                    this.formAdmin.Hide();
                    this.formStudent.Hide();
                    break;
                case FormType.LOG:
                    this.formReg.Hide();
                    this.formLog.Show();
                    this.formAdmin.Hide();
                    this.formStudent.Hide();
                    break;
                case FormType.ADMIN:
                    this.formReg.Hide();
                    this.formLog.Hide();
                    this.formAdmin.Show();
                    this.formStudent.Hide();
                    break;
                case FormType.STUDENT:
                    this.formReg.Hide();
                    this.formLog.Hide();
                    this.formAdmin.Hide();
                    this.formStudent.Show();

                    if(surname != "")
                    {
                        this.formStudent.SetName(surname);
                    }
                    break;
            }
        }

        public void CloseForm(FormType type)
        {
            switch (type)
            {
                case FormType.REG:
                    return;
                case FormType.LOG:
                    this.formLog = new Form2();
                    this.formReg.Show();
                    this.formLog.Hide();
                    this.formAdmin.Hide();
                    this.formStudent.Hide();
                    break;
                case FormType.ADMIN:
                    this.formAdmin = new Form3();
                    this.formReg.Hide();
                    this.formLog.Show();
                    this.formAdmin.Hide();
                    this.formStudent.Hide();
                    break;
                case FormType.STUDENT:
                    this.formStudent = new Form4();
                    this.formReg.Hide();
                    this.formLog.Show();
                    this.formAdmin.Hide();
                    this.formStudent.Hide();
                    break;
            }
        }
    }

}
