using AccountRegistration.Delegates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class Form2 : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        public Form2()
        {
            InitializeComponent();
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);

            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);

            // Display data
            label9.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            label10.Text = DelProgram(StudentInfoClass.Program);
            label11.Text = DelLastName(StudentInfoClass.LastName);
            label12.Text = DelFirstName(StudentInfoClass.FirstName);
            label13.Text = DelMiddleName(StudentInfoClass.MiddleName);
            label14.Text = DelNumAge(StudentInfoClass.Age).ToString();
            label15.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            label16.Text = DelAddress(StudentInfoClass.Address);
            panel1.BackColor = Color.FromArgb(100, Color.WhiteSmoke);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
