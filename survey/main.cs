using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace survey
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void createSurveyBTN_Click(object sender, EventArgs e)  //if Create Survey Form is clicked
        {
            surveyMainForm surveyMain = new surveyMainForm();   //open a new survey creation form
            this.Hide();
            surveyMain.Show();
        }

        private void createMCQBTN_Click(object sender, EventArgs e) //if Create MCQ Exam button is clicked
        {
            mcqMain mcqForm = new mcqMain();    //open a new MCQ creation form
            this.Hide();
            mcqForm.Show();
        }
    }
}
