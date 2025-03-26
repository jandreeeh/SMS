namespace SMS.App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxStudentId = new TextBox();
            textBoxEmail = new TextBox();
            label2 = new Label();
            textBoxName = new TextBox();
            label3 = new Label();
            buttonShow = new Button();
            labelAddedInformation = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 31);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            // 
            // textBoxStudentId
            // 
            textBoxStudentId.Location = new Point(143, 28);
            textBoxStudentId.Name = "textBoxStudentId";
            textBoxStudentId.Size = new Size(283, 23);
            textBoxStudentId.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(143, 138);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(283, 23);
            textBoxEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 141);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 2;
            label2.Text = "Student Email";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(143, 83);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(283, 23);
            textBoxName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 86);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 4;
            label3.Text = "Student Name";
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(95, 276);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(304, 69);
            buttonShow.TabIndex = 6;
            buttonShow.Text = "Load New Information";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // labelAddedInformation
            // 
            labelAddedInformation.AutoSize = true;
            labelAddedInformation.Location = new Point(143, 196);
            labelAddedInformation.Name = "labelAddedInformation";
            labelAddedInformation.Size = new Size(108, 15);
            labelAddedInformation.TabIndex = 7;
            labelAddedInformation.Text = "Added Information";
            // 
            // Form1
            // 
            AcceptButton = buttonShow;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 404);
            Controls.Add(labelAddedInformation);
            Controls.Add(buttonShow);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(textBoxEmail);
            Controls.Add(label2);
            Controls.Add(textBoxStudentId);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form2";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxStudentId;
        private TextBox textBoxEmail;
        private Label label2;
        private TextBox textBoxName;
        private Label label3;
        private Button buttonShow;
        private Label labelAddedInformation;
    }
}