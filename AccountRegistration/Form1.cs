using AccountRegistration.Delegates;
using System.Data;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class Form1 : Form
    {




        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(100, Color.WhiteSmoke);


            comboBox1.Items.AddRange(new string[]
            {
                "BS Computer Science",
                "BS Information Technology",
                "BS Information Systems",
                "BS Software Engineering",
                "BS Data Science",
                "BS Civil Engineering",
                "BS Electrical Engineering",
                "BS Mechanical Engineering",
                "BS Architecture",
                "BS Accountancy",
                "BS Business Administration",
                "BS Marketing Management",
                "BS Psychology",
                "BS Nursing",
                "BS Medical Technology",
                "BS Pharmacy",
                "BS Biology",
                "BS Mathematics",
                "BA Communication",
                "BA Political Science",
                "BA Economics",
                "BA English Language Studies",
                "Bachelor of Elementary Education",
                "Bachelor of Secondary Education"
            });


            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) ||
     string.IsNullOrEmpty(comboBox1.Text) ||
     string.IsNullOrEmpty(textBox2.Text) ||
     string.IsNullOrEmpty(textBox3.Text) ||
     string.IsNullOrEmpty(textBox4.Text) ||
     string.IsNullOrEmpty(textBox5.Text) ||
     string.IsNullOrEmpty(textBox6.Text) ||
     string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("please Answer all the fields. ", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(textBox5.Text, out long age) ||
                !long.TryParse(textBox6.Text, out long contactNo) ||
                !long.TryParse(textBox1.Text, out long studentNo))
            {
                MessageBox.Show("Please type numbers only for Student Number, Age, and contact Number", "invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            StudentInfoClass.FirstName = textBox3.Text;
            StudentInfoClass.LastName = textBox2.Text;
            StudentInfoClass.MiddleName = textBox4.Text;
            StudentInfoClass.Address = textBox7.Text;
            StudentInfoClass.Age = long.Parse(textBox5.Text);
            StudentInfoClass.StudentNo = long.Parse(textBox1.Text);
            StudentInfoClass.ContactNo = long.Parse(textBox6.Text);
            StudentInfoClass.Program = comboBox1.Text;

            // Open FrmConfirm as dialog
            Form2 frm = new Form2();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Registration confirmed!", "Success");
                ClearControl(this);
            }
        }
        private void ClearControl(Control Parent)
        {
            foreach (Control Control in Parent.Controls)
            {
                if (Control is TextBox txtBox)
                    txtBox.Clear();
                else if (Control is ComboBox cmbBox)
                    cmbBox.SelectedIndex = -1;
                else if (Control.HasChildren)
                    ClearControl(Control);
            }

        }





        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
