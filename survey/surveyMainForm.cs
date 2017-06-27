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
    public partial class surveyMainForm : Form
    {
        int startY = 1090;  //startY is the Y coordinate where each question and it's corresponding circles will be drawn
        int CirclesX = 4100;    //The X position of each circle Row
        /*
         * These lists contain the binary encoding of each course code
        */
        List<int> cvleCode = new List<int>();
        List<int> comeCode = new List<int>();
        List<int> compCode = new List<int>();
        List<int> poweCode = new List<int>();
        List<int> inmeCode = new List<int>();
        List<int> mcheCode = new List<int>();
        List<int> ptreCode = new List<int>();
        List<int> mathCode = new List<int>();
        List<int> physCode = new List<int>();
        List<int> enviCode = new List<int>();
        List<int> englCode = new List<int>();
        List<int> mgmtCode = new List<int>();
        List<int> chemCode = new List<int>();
        List<int> geolCode = new List<int>();
        /*
         * These lists contain the binary encoding of
         * Each number from 0 to 9
        */
        List<int> zeroCode = new List<int>();
        List<int> oneCode = new List<int>();
        List<int> twoCode = new List<int>();
        List<int> threeCode = new List<int>();
        List<int> fourCode = new List<int>();
        List<int> fiveCode = new List<int>();
        List<int> sixCode = new List<int>();
        List<int> sevenCode = new List<int>();
        List<int> eightCode = new List<int>();
        List<int> nineCode = new List<int>();
        List<int> nameList = new List<int>();
        List<int> num1 = new List<int>();   //List contains the binary encoding of the first digit in the code number
        List<int> num2 = new List<int>();   //List contains the binary encoding of the second digit in the code number
        List<int> num3 = new List<int>();   //List contains the binary encoding of the third digit in the code number
        char codeNum1;  //first digit of the given course number
        char codeNum2;  //second digit of the given course number
        char codeNum3;  //third digit of the given course number

        /*
             * The following are strings and variables used to create the sample
             * Variables such as the faculty name,program, information about the survey....
             * 
             */

        string bau = "Beirut Arab University";
        string bauArabic = "جامعة بيروت العربية";
        string title = " End of Term Course Evaluation";
        string dearStudents = " Dear Students:";
        string purpose1 = " The purpose of this survey is to obtain feedback on how well the course has prepared you to";
        string purpose2 = "succeed in your future career. Therefore, you are requested to fill it out with utmost objectivity and seriousness.";
        string legend = "5 = Strongly Agree ;   4 = Agree ;   3 = Neutral ;   2 = Disagree ;   1 = Strongly Disagree";
        string optionsLetters = "5     4     3     2     1";
        Point sQCoordinates2 = new Point(240, 4835);    //point where the second line of the question entered by the user will be drawn(if the user entered a two-line question
        Point sQY = new Point(240, 4735);   //point where the Question specific to the course will be drawn
        Point codeCoordinates = new Point(2900, 600);   //coordinates of the starting point of the encoded circle representation of the course
        Image newImage; //image to be drawn on
        Image logo = Image.FromFile("BAULogo.png"); //bau logo
        Point aboveLeft = new Point(0, 920);    //left starting point of the line to be drawn to separate the survey info from the survey
        Point aboveRight = new Point(4961, 920);//right ending point of the line to be drawn to separate the survey info from the survey
        /*
         * These are main titles
         * Of the questions of the survey
        */
        string qGroup1 = "I.  Instructor Teaching Effectiveness";
        string qGroup2 = " II.  Course Overall Experience";
        string qGroup3 = " III.  Course Additional items";
        string qGroup4 = " IV.  Course Intended Learning Outcomes";
        List<string> fQList1 = new List<string>();  //list that will contain the questions regarding the Instructor Teaching Effectiveness
        List<string> fQList2 = new List<string>();  //list that will contain the questions regarding the Instructor Teaching Effectiveness
        List<string> fQList3 = new List<string>();  //list that will contain the questions regarding the Course Additional items
        List<string> sQList = new List<string>();   //list that will contain the questions regarding the Course Intended Learning Outcomes
        /*
         * These are place holders for the faculty questions
        */
        string fq7 = "I was aware of the course educational outcomes/objectives.";
        string fq8 = "Course topics were clearly outlined in the course syllabus.";
        string fq9 = "The course increased my interest in the subject.";
        string fq10 = "In this course I have learned something I consider valuable.";
        string fq11 = "Assessment and grading policy were clearly outlined in the course syllabus.";
        string fq12 = "The amount of work required is appropriate for the credits received.";
        string fq13 = "Rate the overall quality of the course.";
        string fq1 = "The Instructor was well prepared and knowledgeable about the subject.";
        string fq2 = "The Instructor Stimulated interest in the course subject.";
        string fq3 = "The instructor communicated his/her subject well.";
        string fq4 = "The instructor encouraged students to think for themselves.";
        string fq5 = "Rate instructor's overall teaching effectiveness.";
        string fq6 = "Course topics were clearly outlined in the course syllabus.";
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
            
        public surveyMainForm()
        {
            InitializeComponent();
        }

        private void surveyMainForm_Load(object sender, EventArgs e)    //when the form loads
        {
            /*
             * Here we are encoding each course Code to it's relative binary representation
            */
            errorLabel.Hide();
            cvleCode.Add(0);
            cvleCode.Add(0);
            cvleCode.Add(0);
            cvleCode.Add(0);
            comeCode.Add(0);
            comeCode.Add(0);
            comeCode.Add(0);
            comeCode.Add(1);
            compCode.Add(0);
            compCode.Add(0);
            compCode.Add(1);
            compCode.Add(0);
            poweCode.Add(0);
            poweCode.Add(0);
            poweCode.Add(1);
            poweCode.Add(1);
            inmeCode.Add(0);
            inmeCode.Add(1);
            inmeCode.Add(0);
            inmeCode.Add(0);
            mcheCode.Add(0);
            mcheCode.Add(1);
            mcheCode.Add(0);
            mcheCode.Add(1);
            ptreCode.Add(0);
            ptreCode.Add(1);
            ptreCode.Add(1);
            ptreCode.Add(0);
            mathCode.Add(1);
            mathCode.Add(1);
            mathCode.Add(1);
            mathCode.Add(1);
            physCode.Add(1);
            physCode.Add(0);
            physCode.Add(0);
            physCode.Add(0);
            enviCode.Add(1);
            enviCode.Add(0);
            enviCode.Add(0);
            enviCode.Add(1);
            englCode.Add(1);
            englCode.Add(0);
            englCode.Add(1);
            englCode.Add(0);
            mgmtCode.Add(1);
            mgmtCode.Add(0);
            mgmtCode.Add(1);
            mgmtCode.Add(1);
            chemCode.Add(1);
            chemCode.Add(1);
            chemCode.Add(0);
            chemCode.Add(0);
            geolCode.Add(1);
            geolCode.Add(1);
            geolCode.Add(0);
            geolCode.Add(1);
            /*
             * The same here, we are giving each number from 0 to 9 it's 4 bit binary representation
            */ 
            zeroCode = cvleCode;
            oneCode = comeCode;
            twoCode = compCode;
            threeCode = poweCode;
            fourCode = inmeCode;
            fiveCode = mcheCode;
            sixCode = ptreCode;
            sevenCode = mathCode;
            eightCode = physCode;
            nineCode = enviCode;
            crsNameCombo.SelectedIndex = 0; //selected course name is COMP
            faculty.Items.Add("Engineering");   //add "Engineering" in the faculty drop down menu
            faculty.SelectedIndex = 0;
            /*
             * Here we are adding the departments
             * In the department drop down menu
            */
            program.Items.Add("Electrical and Computer Engineering");
            program.Items.Add("Civil Engineering");
            program.Items.Add("Mechanical Engineering");
            program.Items.Add("Industrial and Machines");
            program.Items.Add("Petroleum Engineering");
            program.Items.Add("General Engineering");
            program.SelectedIndex = 0;  //department of Electrical and Computer engineering is selected by default
            /*
             * Here we are assigning the text inside the
             * textboxes of the faculty questions
             * to their respective place holders
            */
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
            qGroup1TextBox.Text = qGroup1;
            qGroup2TextBox.Text = qGroup2;
            qGroup3TextBox.Text = qGroup3;
            qGroup4TextBox.Text = qGroup4;
        }


        private void createBtn_Click(object sender, EventArgs e)    //when Create Survey button is clicked
        {
            if (errorLabel.Text != "")  //if an error is displayed,return
                return;
            /*
             * We always clear the lists containing
             * The questions in case the user created the survey
             * Then returned and edited something in the survey main form
            */
            fQList1.Clear();
            fQList2.Clear();
            fQList3.Clear();
            sQList.Clear();
            /*
             * Here we are adding to each question list it's corresponding
             * Questions from the respective textboxes
            */
            fQList1.Add(qGroup1Q1.Text);
            fQList1.Add(qGroup1Q2.Text);
            fQList1.Add(qGroup1Q3.Text);
            fQList1.Add(qGroup1Q4.Text);
            fQList1.Add(qGroup1Q5.Text);
            fQList1.Add(qGroup1Q6.Text);
            fQList2.Add(qGroup2Q1.Text);
            fQList2.Add(qGroup2Q2.Text);
            fQList2.Add(qGroup2Q3.Text);
            fQList2.Add(qGroup2Q4.Text);
            fQList2.Add(qGroup2Q5.Text);
            fQList2.Add(qGroup2Q6.Text);
            fQList2.Add(qGroup2Q7.Text);
            fQList3.Add(qGroup3Q1.Text);
            fQList3.Add(qGroup3Q2.Text);
            fQList3.Add(qGroup3Q3.Text);
            fQList3.Add(qGroup3Q4.Text);
            fQList3.Add(qGroup3Q5.Text);
            fQList3.Add(qGroup3Q6.Text);
            fQList3.Add(qGroup3Q7.Text);
            fQList3.Add(qGroup3Q8.Text);
            fQList3.Add(qGroup3Q9.Text);
            fQList3.Add(qGroup3Q10.Text);
            sQList.Add(sq1Textbox.Text);
            sQList.Add(sq2Textbox.Text);
            sQList.Add(sq3Textbox.Text);
            sQList.Add(sq4Textbox.Text);
            sQList.Add(sq5Textbox.Text);
            sQList.Add(sq6Textbox.Text);
            sQList.Add(sq7Textbox.Text);
            sQList.Add(sq8Textbox.Text);
            /*
             * Here we remove any question that is empty from it's respective list
            */
            for (int i = 0; i < fQList1.Count; i++)
                if (fQList1[i] == "")
                    fQList1.RemoveAll(x => x == "");
            for (int i = 0; i < fQList2.Count; i++)
                if (fQList2[i] == "")
                    fQList2.RemoveAll(x => x == "");
            for (int i = 0; i < fQList3.Count; i++)
                if (fQList3[i] == "")
                    fQList3.RemoveAll(x => x == "");
            for (int i = 0; i < sQList.Count; i++)
                if (sQList[i] == "")
                    sQList.RemoveAll(x => x == "");
            /*
             * Here we are adding a number next to each question in each question list
            */
            for (int i = 1; i <= fQList1.Count; i++)
                fQList1[i - 1] = i.ToString() + "- " + fQList1[i - 1];
            for (int i = 1; i <= fQList2.Count; i++)
                fQList2[i - 1] = i.ToString() + "- " + fQList2[i - 1];
            for (int i = 1; i <= fQList3.Count; i++)
                fQList3[i - 1] = i.ToString() + "- " + fQList3[i - 1];
            for (int i = 1; i <= sQList.Count; i++)
                sQList[i - 1] = i.ToString() + "- " + sQList[i - 1];
            try
            {
                //initialize nameList according to the given course code
                if (crsNameCombo.SelectedItem == "COMP")
                    nameList = compCode;
                else if (crsNameCombo.SelectedItem == "CVLE")
                    nameList = cvleCode;
                else if (crsNameCombo.SelectedItem == "COME")
                    nameList = comeCode;
                else if (crsNameCombo.SelectedItem == "POWE")
                    nameList = poweCode;
                else if (crsNameCombo.SelectedItem == "INME")
                    nameList = inmeCode;
                else if (crsNameCombo.SelectedItem == "MCHE")
                    nameList = mcheCode;
                else if (crsNameCombo.SelectedItem == "PTRE")
                    nameList = ptreCode;
                else if (crsNameCombo.SelectedItem == "MATH")
                    nameList = mathCode;
                else if (crsNameCombo.SelectedItem == "PHYS")
                    nameList = physCode;
                else if (crsNameCombo.SelectedItem == "ENVI")
                    nameList = enviCode;
                else if (crsNameCombo.SelectedItem == "ENGL")
                    nameList = englCode;
                else if (crsNameCombo.SelectedItem == "MGMT")
                    nameList = mgmtCode;
                else if (crsNameCombo.SelectedItem == "CHEM")
                    nameList = chemCode;
                else if (crsNameCombo.SelectedItem == "GEOL")
                    nameList = geolCode;
                
                string fac = "Faculty of " + faculty.SelectedItem.ToString();   //selected faculty
                string pro = program.SelectedItem.ToString();   //selected program
                string crsName = "Course : " + crsNameCombo.SelectedItem + " " + crsNumber.Text + " - " + description.Text; //Given course
                Point optionsTop = new Point(4020, 1150);   //Coordinate of the upper starting point of the line drawn to separate the circles from their correponding question
                Point optionsBottom = new Point(4020, 7000);//Coordinate of the bottom ending point of the line drawn to separate the circles from their correponding question
                newImage = new Bitmap(4961, 7016);  //create image to be drawn at
                Rectangle ImageSize = new Rectangle(0, 0, 4961, 7016); //used to give the image a white background
                Graphics g = Graphics.FromImage(newImage);
                g.FillRectangle(Brushes.White, ImageSize);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;  //used to make drawing smoother
                Pen pen = new Pen(Color.Black, 10); //different pens to draw with
                Pen pen2 = new Pen(Color.Black, 5); //
                g.DrawLine(pen, aboveLeft, aboveRight); //draw line to separate exam info from the actual exam
                g.DrawImage(logo, new Point(100, 100)); //draw BAU logo
                FontFamily fontFamily = new FontFamily("Arial");
                Font font = new Font(fontFamily, 72, FontStyle.Regular, GraphicsUnit.Pixel);    //Different fonts used
                Font font2 = new Font(fontFamily, 130, FontStyle.Regular, GraphicsUnit.Pixel);  //
                Font font3 = new Font(fontFamily, 100, FontStyle.Regular, GraphicsUnit.Pixel);  //
                Font font4 = new Font(fontFamily, 80, FontStyle.Regular, GraphicsUnit.Pixel);   //
                Font font5 = new Font(fontFamily, 80, FontStyle.Bold, GraphicsUnit.Pixel);      //
                Font font6 = new Font(fontFamily, 110, FontStyle.Bold, GraphicsUnit.Pixel);     //
                Brush brush = new SolidBrush(Color.Black);  //brush to color circles with
                g.DrawString(bau, font2, brush, 550, 150);  //draw BAU
                g.DrawString(bauArabic, font2, brush, 700, 300);    //Draw BAU in Arabic
                g.DrawLine(pen, new Point(500, 500), new Point(2000, 500)); //draw line under BAU in Arabic
                g.DrawLine(pen, optionsTop, optionsBottom); //draw line separating circles from questions
                g.DrawString(fac, font4, brush, new PointF(2900, 150)); //draw faculty name
                g.DrawString(pro, font4, brush, new PointF(2900, 300)); //draw department name
                g.DrawString(crsName, font4, brush, new PointF(2900, 450)); //draw course name
                g.DrawString(title, font6, brush, new PointF(500, 570));    //draw " End of Term Course Evaluation"
                g.DrawString(dearStudents, font5, brush, new PointF(100, 700)); //draw "Dear students"
                g.DrawString(purpose1, font4, brush, new PointF(800, 700)); //draw first line of message to students
                g.DrawString(purpose2, font4, brush, new PointF(130, 800)); //draw second line of message to students
                g.DrawString(legend, font4, brush, new PointF(130, 950));   //draw legened
                g.DrawString(optionsLetters, font5, brush, new PointF(4100, 950));  //draw options (5 4 3 2 1)
                g.DrawString(qGroup1TextBox.Text, font5, brush, new PointF(110, startY));   //draw the title of the first group of faculty questions
                startY = startY + 135;  //increment startY by 135
                for (int i = 0; i < fQList1.Count; i++) //for each question inside the list of questions of the first group of faculty questions
                {
                    g.DrawString(fQList1[i], font4, brush, new PointF(240, startY));    //draw the question
                    for (int j = 0; j < 5; j++) 
                    {
                        g.DrawEllipse(pen, CirclesX, startY, 80, 80);//draw 5 circles
                        CirclesX = CirclesX + 180;  //increment the starting X point of each circle by 180
                    }
                    CirclesX = 4100;    //reset the circle starting X position to it's initial value
                    startY = startY + 135;  //increment start Y by 135 as we move from one question to the next
                }
                /*
                 * We repeat the exact same for the second group of faculty questions
                */
                g.DrawString(qGroup2TextBox.Text, font5, brush, new PointF(110, startY));   
                startY = startY + 135;
                for (int i = 0; i < fQList2.Count; i++)
                {
                    g.DrawString(fQList2[i], font4, brush, new PointF(240, startY));
                    for (int j = 0; j < 5; j++)
                    {
                        g.DrawEllipse(pen, CirclesX, startY, 80, 80);
                        CirclesX = CirclesX + 180;
                    }
                    CirclesX = 4100;
                    startY = startY + 135;
                }
                /*
                 * We repeat the exact same for the third group of faculty questions
                */
                g.DrawString(qGroup3TextBox.Text, font5, brush, new PointF(110, startY));
                startY = startY + 135;
                for (int i = 0; i < fQList3.Count; i++)
                {
                    g.DrawString(fQList3[i], font4, brush, new PointF(240, startY));
                    for (int j = 0; j < 5; j++)
                    {
                        g.DrawEllipse(pen, CirclesX, startY, 80, 80);
                        CirclesX = CirclesX + 180;
                    }
                    CirclesX = 4100;
                    startY = startY + 135;
                }
                g.DrawString(qGroup4TextBox.Text, font5, brush, new PointF(110, startY));//draw the title of the questions specific to the course
                startY = startY + 135;  //increment startY by 135
                sQY.Y = startY; //sQY(the point where the circles will be drawn for each course-specific question is given an initial value of startY
                sQCoordinates2.Y = sQY.Y + 100; //sQcoordinates2 is the point where the second line of the course-specific question will be drawn(if a second line exists)
                for (int i = 0; i < sQList.Count; i++)  //for each question specific to the course
                {
                    if (sQList[i] != "")    //if the question is not empty
                    {
                        char[] array = new char[185];   //array to store all the characters of the question
                        sQList[i].CopyTo(0, array, 0, sQList[i].Length);    //give the array it's values from the questions
                        string s = new string(array);   //s is a string that is derived from array
                        if (sQList[i].Length > 84)  //if the entered question has a length greater than 81
                        {
                            int var = 84;   //var is the character number where we wish to move to a second line
                            while (array[var] != ' ')   //keep incrementing var until a space is found indicating a new word(so we don't move to a new line breaking a word)
                                var++;
                            char[] array1 = new char[185];  //array1 will hold the first part of the question
                            for (int j = 0; j < var; j++)
                            {
                                array1[j] = array[j];
                            }
                            char[] array2 = new char[185];  //array 2 will hold the second part of the question
                            for (int j = var; j < sQList[i].Length + 3; j++)
                            {
                                array2[j] = array[j];
                            }
                            string s1 = new string(array1); //s1 is a string derived from array1(first part of the question)
                            string s2 = new string(array2); //s2 is a string derived from array2(second part of the question)
                            g.DrawString(s1, font4, brush, sQY);    //draw the first part of the question
                            g.DrawString(s2, font4, brush, sQCoordinates2); //draw the second part of the question
                        }
                        else    //if the entered question is less than 81 characters long
                        {
                            g.DrawString(s, font4, brush, sQY); //draw the question
                        }
                        for (int j = 0; j < 5; j++) //draw 5 circles next to each course-specific question
                        {
                            g.DrawEllipse(pen, CirclesX, sQY.Y, 80, 80);
                            CirclesX = CirclesX + 180;
                        }
                        CirclesX = 4100;
                        sQY.Y = sQY.Y + 280;    //increment sQY by 280
                        sQCoordinates2.Y = sQY.Y + 100;
                    }
                }
                for (int i = 0; i < 15; i++)    //draw 15 empty circles that represent the encoded represenation of the given course
                {
                    g.DrawEllipse(pen, codeCoordinates.X, codeCoordinates.Y, 80, 80);
                    codeCoordinates.X = codeCoordinates.X + 120;
                }
                codeCoordinates = new Point(2900, 600); //reset the starting point of the code circles
                for (int j = 0; j < 4; j++) //color the first 4 circles according to the encoding of the given course Name
                {
                    if (nameList[j] == 1)
                    {
                        g.FillEllipse(brush, codeCoordinates.X, codeCoordinates.Y, 80, 80);
                    }
                    codeCoordinates.X = codeCoordinates.X + 120;    //increment the circle position by 120 pixels
                }
                for (int j = 0; j < 3; j++) //color the second 3 circles according to the encoding of the first digit of the given course Number
                {
                    if (num1[j + 1] == 1)
                    {
                        g.FillEllipse(brush, codeCoordinates.X, codeCoordinates.Y, 80, 80);
                    }
                    codeCoordinates.X = codeCoordinates.X + 120;    //increment the circle position by 120 pixels
                }
                for (int j = 0; j < 4; j++) //color the third 4 circles according to the encoding of the second digit of the given course Number
                {
                    if (num2[j] == 1)
                    {
                        g.FillEllipse(brush, codeCoordinates.X, codeCoordinates.Y, 80, 80);
                    }
                    codeCoordinates.X = codeCoordinates.X + 120;    //increment the circle position by 120 pixel
                }
                for (int j = 0; j < 4; j++) //color the final 4 circles according to the encoding of the second digit of the given course Number
                {
                    if (num3[j] == 1)
                    {
                        g.FillEllipse(brush, codeCoordinates.X, codeCoordinates.Y, 80, 80);
                    }
                    codeCoordinates.X = codeCoordinates.X + 120;    //increment the circle position by 120 pixel
                }
                g.DrawRectangle(pen, 2870, 570, 1850, 130); //draw a rectangle around the course encoding
                surveyImage((Bitmap)newImage);  //send the created sample to a new form through function surveyImage
                errorLabel.Hide();  //hide the error label if creation has succeede
            }
            catch   //if creation of the sample failed
            {   //it is surely due to an invalid question entry
                if(errorLabel.Text == "")   //display error message
                    errorLabel.Text = "Invalid question entry.";
                errorLabel.ForeColor = Color.Red;
                errorLabel.Refresh();
                errorLabel.Show();
                startY = 1090;  //reset start Y and codeCoordinates in case the user edited the survey and clicked create survey again
                codeCoordinates = new Point(2900, 600);
            }
        }
        private void surveyImage(Bitmap image)  //send the created sample to a new form
        {
            //reset all important values in case the user edited the survey and clicked create survey again
            startY = 1090;
            codeCoordinates = new Point(2900, 600);
            fQList1.Clear();
            fQList2.Clear();
            fQList3.Clear();
            sQList.Clear();
            surveyImage test = new surveyImage(image);  //send created image to a new form
            test.Show();
        }

        private void backToMenuBTN_Click(object sender, EventArgs e)    //if the user clicked the Back button
        {
            this.Close();   //close surveyMainForm
            main main = new main();
            main.Show();    //show main menu
        }

        private void crsNumber_Leave(object sender, EventArgs e)
        {
            char[] arrayCode = new char[3]; //array to store the number entered by user
            crsNumber.Text.CopyTo(0, arrayCode, 0, crsNumber.TextLength);   //copy the number entered by user to arrayCode
            codeNum1 = arrayCode[0];    //codeNum1 is the first digit of the number entered by user
            codeNum2 = arrayCode[1];    //codeNum2 is the second digit of the number entered by user
            codeNum3 = arrayCode[2];    //codeNum3 is the third digit of the number entered by user
            /*
             * Here we are giving num1 it's binary representation
             * according to the first digit of the number entered by the user
            */
            switch (codeNum1)
            {
                case '0':
                    num1 = zeroCode;
                    break;
                case '1':
                    num1 = oneCode;
                    break;
                case '2':
                    num1 = twoCode;
                    break;
                case '3':
                    num1 = threeCode;
                    break;
                case '4':
                    num1 = fourCode;
                    break;
                case '5':
                    num1 = fiveCode;
                    break;
                case '6':
                    num1 = sixCode;
                    break;
                case '7':
                    num2 = sevenCode;
                    break;
                default:    //if the user entered a character that is not a number between 0 and 7
                    errorLabel.Text = "Invalid Course Number";  //display error message
                    errorLabel.ForeColor = Color.Red;
                    errorLabel.Show();
                    errorLabel.Refresh();
                    /*
                     * Clear the questions list so that the user can edit them with no problems arising
                    */
                    fQList1.Clear();
                    fQList2.Clear();
                    fQList3.Clear();
                    sQList.Clear();
                    return;
            }
            /*
             * Here we are giving num2 it's binary representation
             * according to the second digit of the number entered by the user
            */
            switch (codeNum2)
            {
                case '0':
                    num3 = zeroCode;
                    break;
                case '1':
                    num2 = oneCode;
                    break;
                case '2':
                    num2 = twoCode;
                    break;
                case '3':
                    num2 = threeCode;
                    break;
                case '4':
                    num2 = fourCode;
                    break;
                case '5':
                    num2 = fiveCode;
                    break;
                case '6':
                    num2 = sixCode;
                    break;
                case '7':
                    num2 = sevenCode;
                    break;
                case '8':
                    num2 = eightCode;
                    break;
                case '9':
                    num2 = nineCode;
                    break;
                default:    //if the user entered a character that is not a number between 0 and 9
                    errorLabel.Text = "Invalid Course Number";  //display error message
                    errorLabel.ForeColor = Color.Red;
                    errorLabel.Show();
                    errorLabel.Refresh();
                    fQList1.Clear();
                    fQList2.Clear();
                    fQList3.Clear();
                    sQList.Clear();
                    return;
            }
            /*
             * Here we are giving num3 it's binary representation
             * according to the third digit of the number entered by the user
            */
            switch (codeNum3)
            {
                case '0':
                    num3 = zeroCode;
                    break;
                case '1':
                    num3 = oneCode;
                    break;
                case '2':
                    num3 = twoCode;
                    break;
                case '3':
                    num3 = threeCode;
                    break;
                case '4':
                    num3 = fourCode;
                    break;
                case '5':
                    num3 = fiveCode;
                    break;
                case '6':
                    num3 = sixCode;
                    break;
                case '7':
                    num3 = sevenCode;
                    break;
                case '8':
                    num3 = eightCode;
                    break;
                case '9':
                    num3 = nineCode;
                    break;
                default:    //if the user entered a character that is not a number between 0 and 9
                    errorLabel.Text = "Invalid Course Number";  //display error message
                    errorLabel.ForeColor = Color.Red;
                    errorLabel.Show();
                    errorLabel.Refresh();
                    fQList1.Clear();
                    fQList2.Clear();
                    fQList3.Clear();
                    sQList.Clear();
                    return;
            }
        }

        private void crsNumber_TextChanged(object sender, EventArgs e)  //when the user changes the text inside the courseNumber textBox
        {
            errorLabel.Text = "";   //remove error message
            errorLabel.Hide();
        }

        private void sq1Textbox_TextChanged(object sender, EventArgs e) //when the user changes the text inside any course-specific question textBox
        {
            errorLabel.Text = "";
            errorLabel.Hide();
        }

    }
}
