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
    public partial class changeFacQuestions : Form
    {
        List<string> list = new List<string>();
        string qGroup2 = " I.   Course Overall Experience";
        string fq7 = "I was aware of the course educational outcomes/objectives.";
        string fq8 = "Course topics were clearly outlined in the course syllabus.";
        string fq9 = "The course increased my interest in the subject.";
        string fq10 = "In this course I have learned something I consider valuable.";
        string fq11 = "Assessment and grading policy were clearly outlined in the course syllabus.";
        string fq12 = "The amount of work required is appropriate for the credits received.";
        string fq13 = "Rate the overall quality of the course.";
        string qGroup1 = " I.  Instructor Teaching Effectiveness";
        string fq1 = "The Instructor was well prepared and knowledgeable about the subject.";
        string fq2 = "The Instructor Stimulated interest in the course subject.";
        string fq3 = "The instructor communicated his/her subject well.";
        string fq4 = "The instructor encouraged students to think for themselves.";
        string fq5 = "Rate instructor's overall teaching effectiveness.";
        string fq6 = "Course topics were clearly outlined in the course syllabus.";
        string qGroup3 = " III.  Course Additional Items";
        string fq14 = "I learnt the fundamental principles, generalizations, or theories.";
        string fq15 = "I gained factual knowledge ( terminology, classifications, methods, trends ).";
        string fq16 = "I applied course materials to improve thinking and solve problems.";
        string fq17 = "I developed skills & competencies needed by professionals in the field";
        string fq18 = "I acquired skills in working with others as a member of a team.";
        string fq19 = "I learnt how to find and use resources for answering critical questions.";
        string fq20 = "The course made a valuable contribution to my professional development.";
        string fq21 = "I developed a greater sense of personal responsibility.";
        string fq22 = "I developed creative capacities (inventing, designing).";
        string fq23 = "I acquired an interest in learning by asking questions and seeking answers.";
        bool submit = false;
        public changeFacQuestions()
        {
            InitializeComponent();
        }

        private void changeFacQuestions_Load(object sender, EventArgs e)
        {
            changeFacQuestionsPanel.Height = 4*(this.Height)/5;
            qGroup1Q1.Text = fq1;
            qGroup1Q2.Text = fq2;
            qGroup1Q3.Text = fq3;
            qGroup1Q4.Text = fq4;
            qGroup1Q5.Text = fq5;
            qGroup1Q6.Text = fq6;
            qGroup2Q1.Text = fq7;
            qGroup2Q2.Text = fq8;
            qGroup2Q3.Text = fq9;
            qGroup2Q4.Text = fq10;
            qGroup2Q5.Text = fq11;
            qGroup2Q6.Text = fq12;
            qGroup2Q7.Text = fq13;
            qGroup3Q1.Text = fq14;
            qGroup3Q2.Text = fq15;
            qGroup3Q3.Text = fq16;
            qGroup3Q4.Text = fq17;
            qGroup3Q5.Text = fq18;
            qGroup3Q6.Text = fq19;
            qGroup3Q7.Text = fq20;
            qGroup3Q8.Text = fq21;
            qGroup3Q9.Text = fq22;
            qGroup3Q10.Text = fq23;

        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            submit = true;
            surveyMainForm test = new surveyMainForm();
            this.Hide();
            //test.Show();
        }
        public List<string> returnList()
        {
            list.Add(qGroup1Q1.Text);
            list.Add(qGroup1Q2.Text);
            list.Add(qGroup1Q3.Text);
            list.Add(qGroup1Q4.Text);
            list.Add(qGroup1Q5.Text);
            list.Add(qGroup1Q6.Text);
            list.Add(qGroup2Q1.Text);
            list.Add(qGroup2Q2.Text);
            list.Add(qGroup2Q3.Text);
            list.Add(qGroup2Q4.Text);
            list.Add(qGroup2Q5.Text);
            list.Add(qGroup2Q6.Text);
            list.Add(qGroup2Q7.Text);
            list.Add(qGroup3Q1.Text);
            list.Add(qGroup3Q2.Text);
            list.Add(qGroup3Q3.Text);
            list.Add(qGroup3Q4.Text);
            list.Add(qGroup3Q5.Text);
            list.Add(qGroup3Q6.Text);
            list.Add(qGroup3Q7.Text);
            list.Add(qGroup3Q8.Text);
            list.Add(qGroup3Q9.Text);
            list.Add(qGroup3Q10.Text);
            return list;
        }
        public bool returnSubmitState()
        {
            return submit;
        }
    }
}
