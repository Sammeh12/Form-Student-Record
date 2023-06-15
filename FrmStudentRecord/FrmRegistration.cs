using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmStudentRecord
{
    public partial class FrmRegistration : Form
    {
        static String[] _call_var;
        Thread th;
        public FrmRegistration()
        {
            InitializeComponent();
        }

        public static string SetFileName { get; private set; }

        public void _info()
        {
            String getInput_StudentNum = this.txtStudentNo.Text;
            String getInput_Program = this.cbProgram.Text;
            String getInput_LastName = this.txtLastName.Text;
            String getInput_FirstName = this.txtFirstName.Text;
            String getInput_MI = this.txtMI.Text;
            String getInput_Age = this.txtAge.Text;
            String getInput_Gender = this.cbGender.Text;
            String getInput_Bday = this.dtpBirthday.Text;
            String getInput_Contact = this.txtContactNumber.Text;

            SetFileName = getInput_StudentNum.ToString() + ".txt";

            _call_var = new string[] {"Student No. "+ getInput_StudentNum + "\nFullName: " + getInput_LastName + ", " + getInput_FirstName
                + ", " + getInput_MI +"\nProgram: "+getInput_Program+"\nGender: "+getInput_Gender+"\nAge: " + getInput_Age + "\nBirthday: "
                + getInput_Bday+"\nContact: " + getInput_Contact
            };
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            _info();
            string docPath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmRegistration.SetFileName)))
            {
                foreach (string _Info_ in _call_var)
                {
                    outputFile.WriteLine(_Info_);
                }
                Console.WriteLine("Done!");

            }


        }

        //Opens the FrmStudentRecord window form, then closes the current window form
        public void openStudentRecord(object obj)
        {
            Application.Run(new FrmStudentRecord());
        }

        private void btRecords_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openStudentRecord);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
