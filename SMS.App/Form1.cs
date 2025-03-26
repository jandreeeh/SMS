using SMS.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createStudent(1, "Johnny Test", "johnnytest@yahoo.com");
        }


        private void buttonShow_Click(object sender, EventArgs e)
        {
            createStudent(2, "Johnny Bravo", "johhnybravo@hotmail.com");
        }
        private void createStudent(int id, string name, string email)
        {
            var student = new Student
            {
                StudentId = id,
                StudentName = name,
                Email = email
            };

            textBoxStudentId.Text = student.StudentId.ToString();
            textBoxName.Text = student.StudentName;
            textBoxEmail.Text = student.Email;

        }
    }
}
