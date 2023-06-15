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
    public partial class FrmStudentRecord : Form
    {
        Thread th;
        private string path;
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        //Opens the FrmRegistration window form, then closes the current window form
        public void openRegistration(object obj)
        {
            Application.Run(new FrmRegistration());
        }

        private void btRegister_Click_1(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openRegistration);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public void DisplayToList()
        {
            openFileDialog1.InitialDirectory = @"C:\"; openFileDialog1.Title = "Browse Text Files"; openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            using (StreamReader streamReader = File.OpenText(path))
            {
                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText); lvShowText.Items.Add(_getText);
                }
            }

        }

        private void btFind_Click(object sender, EventArgs e)
        {
            DisplayToList();
        }

        private void btUpload_Click(object sender, EventArgs e)
        {
            lvShowText.Clear();
            MessageBox.Show("Successfully Uploaded!");
        }
    }
}
