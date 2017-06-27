namespace survey
{
    partial class mcqMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.crsNameCombo = new System.Windows.Forms.ComboBox();
            this.backToMainBTN = new System.Windows.Forms.Button();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.drLabel = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.TextBox();
            this.instructor = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.isntructorLabel = new System.Windows.Forms.Label();
            this.note = new System.Windows.Forms.TextBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.crsNumber = new System.Windows.Forms.TextBox();
            this.courseNumberLabel = new System.Windows.Forms.Label();
            this.mark = new System.Windows.Forms.TextBox();
            this.markLabel = new System.Windows.Forms.Label();
            this.exam = new System.Windows.Forms.ComboBox();
            this.examLabel = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.courseLabel = new System.Windows.Forms.Label();
            this.programLabel = new System.Windows.Forms.Label();
            this.program = new System.Windows.Forms.ComboBox();
            this.facultyLabel = new System.Windows.Forms.Label();
            this.faculty = new System.Windows.Forms.ComboBox();
            this.numberOfOptions = new System.Windows.Forms.NumericUpDown();
            this.numberOfOptionsPerQuestionLabel = new System.Windows.Forms.Label();
            this.numberOfQuestions = new System.Windows.Forms.NumericUpDown();
            this.numberOfQuestionsLabel = new System.Windows.Forms.Label();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Exam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.errorLabel);
            this.controlPanel.Controls.Add(this.crsNameCombo);
            this.controlPanel.Controls.Add(this.backToMainBTN);
            this.controlPanel.Controls.Add(this.courseNameLabel);
            this.controlPanel.Controls.Add(this.button1);
            this.controlPanel.Controls.Add(this.drLabel);
            this.controlPanel.Controls.Add(this.time);
            this.controlPanel.Controls.Add(this.instructor);
            this.controlPanel.Controls.Add(this.timeLabel);
            this.controlPanel.Controls.Add(this.isntructorLabel);
            this.controlPanel.Controls.Add(this.note);
            this.controlPanel.Controls.Add(this.noteLabel);
            this.controlPanel.Controls.Add(this.crsNumber);
            this.controlPanel.Controls.Add(this.courseNumberLabel);
            this.controlPanel.Controls.Add(this.mark);
            this.controlPanel.Controls.Add(this.markLabel);
            this.controlPanel.Controls.Add(this.exam);
            this.controlPanel.Controls.Add(this.examLabel);
            this.controlPanel.Controls.Add(this.description);
            this.controlPanel.Controls.Add(this.descriptionLabel);
            this.controlPanel.Controls.Add(this.courseLabel);
            this.controlPanel.Controls.Add(this.programLabel);
            this.controlPanel.Controls.Add(this.program);
            this.controlPanel.Controls.Add(this.facultyLabel);
            this.controlPanel.Controls.Add(this.faculty);
            this.controlPanel.Controls.Add(this.numberOfOptions);
            this.controlPanel.Controls.Add(this.numberOfOptionsPerQuestionLabel);
            this.controlPanel.Controls.Add(this.numberOfQuestions);
            this.controlPanel.Controls.Add(this.numberOfQuestionsLabel);
            this.controlPanel.Location = new System.Drawing.Point(26, 12);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(261, 467);
            this.controlPanel.TabIndex = 1;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(65, 29);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 15);
            this.errorLabel.TabIndex = 43;
            // 
            // crsNameCombo
            // 
            this.crsNameCombo.FormattingEnabled = true;
            this.crsNameCombo.Items.AddRange(new object[] {
            "COMP",
            "COME",
            "CVLE",
            "POWE",
            "INME",
            "MCHE",
            "PTRE",
            "MATH",
            "PHYS",
            "GEOL",
            "ENVI",
            "ENGL",
            "MGMT",
            "CHEM"});
            this.crsNameCombo.Location = new System.Drawing.Point(119, 228);
            this.crsNameCombo.Name = "crsNameCombo";
            this.crsNameCombo.Size = new System.Drawing.Size(59, 21);
            this.crsNameCombo.TabIndex = 42;
            // 
            // backToMainBTN
            // 
            this.backToMainBTN.Location = new System.Drawing.Point(6, 3);
            this.backToMainBTN.Name = "backToMainBTN";
            this.backToMainBTN.Size = new System.Drawing.Size(75, 23);
            this.backToMainBTN.TabIndex = 29;
            this.backToMainBTN.Text = "Back";
            this.backToMainBTN.UseVisualStyleBackColor = true;
            this.backToMainBTN.Click += new System.EventHandler(this.backToMainBTN_Click);
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Location = new System.Drawing.Point(122, 212);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(35, 13);
            this.courseNameLabel.TabIndex = 28;
            this.courseNameLabel.Text = "Name";
            // 
            // drLabel
            // 
            this.drLabel.AutoSize = true;
            this.drLabel.Location = new System.Drawing.Point(96, 392);
            this.drLabel.Name = "drLabel";
            this.drLabel.Size = new System.Drawing.Size(21, 13);
            this.drLabel.TabIndex = 27;
            this.drLabel.Text = "Dr.";
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(123, 360);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(55, 20);
            this.time.TabIndex = 10;
            // 
            // instructor
            // 
            this.instructor.Location = new System.Drawing.Point(123, 389);
            this.instructor.Name = "instructor";
            this.instructor.Size = new System.Drawing.Size(100, 20);
            this.instructor.TabIndex = 26;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(3, 363);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(81, 13);
            this.timeLabel.TabIndex = 9;
            this.timeLabel.Text = "Time in Minutes";
            // 
            // isntructorLabel
            // 
            this.isntructorLabel.AutoSize = true;
            this.isntructorLabel.Location = new System.Drawing.Point(3, 392);
            this.isntructorLabel.Name = "isntructorLabel";
            this.isntructorLabel.Size = new System.Drawing.Size(51, 13);
            this.isntructorLabel.TabIndex = 25;
            this.isntructorLabel.Text = "Instructor";
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(123, 420);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(100, 20);
            this.note.TabIndex = 24;
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(3, 423);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(76, 13);
            this.noteLabel.TabIndex = 23;
            this.noteLabel.Text = "Note (optional)";
            // 
            // crsNumber
            // 
            this.crsNumber.Location = new System.Drawing.Point(182, 228);
            this.crsNumber.MaxLength = 3;
            this.crsNumber.Name = "crsNumber";
            this.crsNumber.Size = new System.Drawing.Size(39, 20);
            this.crsNumber.TabIndex = 22;
            this.crsNumber.Text = "210";
            this.crsNumber.TextChanged += new System.EventHandler(this.crsNumber_TextChanged);
            this.crsNumber.Leave += new System.EventHandler(this.crsNumber_Leave);
            // 
            // courseNumberLabel
            // 
            this.courseNumberLabel.AutoSize = true;
            this.courseNumberLabel.Location = new System.Drawing.Point(179, 212);
            this.courseNumberLabel.Name = "courseNumberLabel";
            this.courseNumberLabel.Size = new System.Drawing.Size(44, 13);
            this.courseNumberLabel.TabIndex = 21;
            this.courseNumberLabel.Text = "Number";
            // 
            // mark
            // 
            this.mark.Location = new System.Drawing.Point(124, 325);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(39, 20);
            this.mark.TabIndex = 20;
            // 
            // markLabel
            // 
            this.markLabel.AutoSize = true;
            this.markLabel.Location = new System.Drawing.Point(2, 328);
            this.markLabel.Name = "markLabel";
            this.markLabel.Size = new System.Drawing.Size(104, 13);
            this.markLabel.TabIndex = 19;
            this.markLabel.Text = "Total Mark (optional)";
            // 
            // exam
            // 
            this.exam.FormattingEnabled = true;
            this.exam.Location = new System.Drawing.Point(123, 292);
            this.exam.Name = "exam";
            this.exam.Size = new System.Drawing.Size(100, 21);
            this.exam.TabIndex = 18;
            // 
            // examLabel
            // 
            this.examLabel.AutoSize = true;
            this.examLabel.Location = new System.Drawing.Point(3, 295);
            this.examLabel.Name = "examLabel";
            this.examLabel.Size = new System.Drawing.Size(33, 13);
            this.examLabel.TabIndex = 17;
            this.examLabel.Text = "Exam";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(123, 261);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(100, 20);
            this.description.TabIndex = 16;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(2, 264);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 15;
            this.descriptionLabel.Text = "Course Title";
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Location = new System.Drawing.Point(3, 231);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(40, 13);
            this.courseLabel.TabIndex = 11;
            this.courseLabel.Text = "Course";
            // 
            // programLabel
            // 
            this.programLabel.AutoSize = true;
            this.programLabel.Location = new System.Drawing.Point(3, 177);
            this.programLabel.Name = "programLabel";
            this.programLabel.Size = new System.Drawing.Size(62, 13);
            this.programLabel.TabIndex = 8;
            this.programLabel.Text = "Department";
            // 
            // program
            // 
            this.program.FormattingEnabled = true;
            this.program.Location = new System.Drawing.Point(123, 174);
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(121, 21);
            this.program.TabIndex = 7;
            // 
            // facultyLabel
            // 
            this.facultyLabel.AutoSize = true;
            this.facultyLabel.Location = new System.Drawing.Point(3, 135);
            this.facultyLabel.Name = "facultyLabel";
            this.facultyLabel.Size = new System.Drawing.Size(41, 13);
            this.facultyLabel.TabIndex = 6;
            this.facultyLabel.Text = "Faculty";
            // 
            // faculty
            // 
            this.faculty.FormattingEnabled = true;
            this.faculty.Location = new System.Drawing.Point(125, 132);
            this.faculty.Name = "faculty";
            this.faculty.Size = new System.Drawing.Size(121, 21);
            this.faculty.TabIndex = 5;
            // 
            // numberOfOptions
            // 
            this.numberOfOptions.Location = new System.Drawing.Point(207, 86);
            this.numberOfOptions.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberOfOptions.Name = "numberOfOptions";
            this.numberOfOptions.Size = new System.Drawing.Size(39, 20);
            this.numberOfOptions.TabIndex = 3;
            this.numberOfOptions.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numberOfOptionsPerQuestionLabel
            // 
            this.numberOfOptionsPerQuestionLabel.AutoSize = true;
            this.numberOfOptionsPerQuestionLabel.Location = new System.Drawing.Point(3, 93);
            this.numberOfOptionsPerQuestionLabel.Name = "numberOfOptionsPerQuestionLabel";
            this.numberOfOptionsPerQuestionLabel.Size = new System.Drawing.Size(167, 13);
            this.numberOfOptionsPerQuestionLabel.TabIndex = 2;
            this.numberOfOptionsPerQuestionLabel.Text = "Number of Options per Question : ";
            // 
            // numberOfQuestions
            // 
            this.numberOfQuestions.Location = new System.Drawing.Point(207, 50);
            this.numberOfQuestions.Maximum = new decimal(new int[] {
            160,
            0,
            0,
            0});
            this.numberOfQuestions.Name = "numberOfQuestions";
            this.numberOfQuestions.Size = new System.Drawing.Size(39, 20);
            this.numberOfQuestions.TabIndex = 1;
            this.numberOfQuestions.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // numberOfQuestionsLabel
            // 
            this.numberOfQuestionsLabel.AutoSize = true;
            this.numberOfQuestionsLabel.Location = new System.Drawing.Point(3, 52);
            this.numberOfQuestionsLabel.Name = "numberOfQuestionsLabel";
            this.numberOfQuestionsLabel.Size = new System.Drawing.Size(115, 13);
            this.numberOfQuestionsLabel.TabIndex = 0;
            this.numberOfQuestionsLabel.Text = "Number of Questions : ";
            // 
            // mcqMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(312, 477);
            this.Controls.Add(this.controlPanel);
            this.Name = "mcqMain";
            this.Text = "mcqMain";
            this.Load += new System.EventHandler(this.mcqMain_Load);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfQuestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.NumericUpDown numberOfOptions;
        private System.Windows.Forms.Label numberOfOptionsPerQuestionLabel;
        private System.Windows.Forms.NumericUpDown numberOfQuestions;
        private System.Windows.Forms.Label numberOfQuestionsLabel;
        private System.Windows.Forms.ComboBox faculty;
        private System.Windows.Forms.Label facultyLabel;
        private System.Windows.Forms.ComboBox program;
        private System.Windows.Forms.Label programLabel;
        private System.Windows.Forms.Label examLabel;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.ComboBox exam;
        private System.Windows.Forms.TextBox mark;
        private System.Windows.Forms.Label markLabel;
        private System.Windows.Forms.TextBox crsNumber;
        private System.Windows.Forms.Label courseNumberLabel;
        private System.Windows.Forms.TextBox note;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Label drLabel;
        private System.Windows.Forms.TextBox instructor;
        private System.Windows.Forms.Label isntructorLabel;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.Button backToMainBTN;
        private System.Windows.Forms.ComboBox crsNameCombo;
        private System.Windows.Forms.Label errorLabel;
    }
}

