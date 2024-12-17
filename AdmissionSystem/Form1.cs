using AdmissionSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmissionSystem
{
    public partial class Form1 : Form
    {
        StudentManager studentManager;
        public Form1()
        {
            InitializeComponent();
            studentManager = new StudentManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = studentManager.GetStudents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(textBox1.Text);
            string n = textBox2.Text;
            int m = int.Parse(textBox3.Text);

            Student student = new Student();
            student.RollNumber = r;
            student.Name = n;
            student.Marks = m;

            studentManager.Add(student);

            var studentsList = studentManager.GetStudents();
            dataGridView1.DataSource = studentsList.ToArray();
        }
    }
}
