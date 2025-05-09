﻿using SMS.Domain;
using SMS.Infrastructure.Data;
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
            //createStudent(1, "Johnny Test", "johnnytest@yahoo.com");
          
        }


        private void buttonShow_Click(object sender, EventArgs e)
        {

            using (var dbContext = new AppDbContext())
            {
                Random rnd = new Random();
                int x = rnd.Next(1, 6);

                var program = dbContext.Programs.Where(p => p.ProgramId == x).FirstOrDefault();
                createStudent(program.ProgramId, program.ProgramName, program.Description);
            }
        }
        private void createStudent(int id, string name, string email)
        {
            var student = new Student
            {
                StudentId = id,
                StudentName = name,
                Email = email,
                DateAdded = DateTime.Now,
                AddedBy = "Admin"
            };

            textBoxStudentId.Text = student.StudentId.ToString();
            textBoxName.Text = student.StudentName;
            textBoxEmail.Text = student.Email;

            //labelAddedInformation.Text = "Added by: " + student.AddedBy + " " + student.DateAdded;  //Must avoid this
            labelAddedInformation.Text = $"Added by: {student.AddedBy} {student.DateAdded}";

        }
    }
}
