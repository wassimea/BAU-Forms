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
    public partial class mcqMain : Form
    {
        Image newImage; //image to be drawn in
        Point aboveLeft = new Point(0, 1450);               //Points
        Point aboveRight = new Point(4961, 1450);           //that
        Point marginLeftTop = new Point(472, 1403);         //are
        Point marginLeftBelow = new Point(472, 7016);       //used for
        Point marginRightTop = new Point(4489, 1403);       //design 
        Point marginRightBelow = new Point(4489, 7016);     //purposes (drawing lines and positions of images)
        int distanceBetweenColumns;                         //used to separate columns from each other according to number of questions
        int columnWidth;                                    //determines width of columns according to number of options per question
        List<int> cvleCode = new List<int>();               
        List<int> comeCode = new List<int>();               
        List<int> compCode = new List<int>();
        List<int> poweCode = new List<int>();
        List<int> inmeCode = new List<int>();
        List<int> mcheCode = new List<int>();               //These lists contain
        List<int> ptreCode = new List<int>();               //The binary encoding of each course code
        List<int> mathCode = new List<int>();               
        List<int> physCode = new List<int>();
        List<int> enviCode = new List<int>();
        List<int> englCode = new List<int>();
        List<int> mgmtCode = new List<int>();
        List<int> chemCode = new List<int>();
        List<int> geolCode = new List<int>();               //
        List<int> zeroCode = new List<int>();               //These lists contain
        List<int> oneCode = new List<int>();                //The binary encoding of numbers    
        List<int> twoCode = new List<int>();                //from 0 to 9
        List<int> threeCode = new List<int>();
        List<int> fourCode = new List<int>();
        List<int> fiveCode = new List<int>();
        List<int> sixCode = new List<int>();
        List<int> sevenCode = new List<int>();
        List<int> eightCode = new List<int>();
        List<int> nineCode = new List<int>();               //
        List<int> nameList = new List<int>();               //This list will contain the binary encoding of the SELECTED course code
        List<int> num1 = new List<int>();                   //List contains the binary encoding of the first digit in the code number
        List<int> num2 = new List<int>();                   //List contains the binary encoding of the second digit in the code number
        List<int> num3 = new List<int>();                   //List contains the binary encoding of the third digit in the code number
        Point codeCoordinates = new Point(1600, 650);       //coordinates of the starting point of the encoded circle representation of the course
        char codeNum1;  //first digit of the given course number
        char codeNum2;  //second digit of the given course number
        char codeNum3;  //third digit of the given course number
        public mcqMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  //create button clicked
        {
            if (errorLabel.Text != "")  //if an error has been detected RETURN
                return;
            if (crsNameCombo.SelectedItem == "COMP")        //initialize nameList according to the given course code
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
                nameList = geolCode;                            //
            /*
             * The following are strings and variables used to create the sample
             * Variables such as the faculty name,program, information about the exam....
             * 
             */
            string facultyOf = "Faculty Of " + faculty.SelectedItem.ToString(); //faculty name(entered by user)
            string pro = program.SelectedItem.ToString();     //department(entered by user)
            string crsNAME = crsNameCombo.SelectedItem + " " + crsNumber.Text + " : " + description.Text;   //course name
            string whatExam = exam.SelectedItem.ToString(); //exam(entered by user)
            Image logo = Image.FromFile("BAULogo.png");     //BAU logo
            string bau = "Beirut Arab University";
            string bau2 ="جامعة بيروت العربية";
            string two = "2";   //used to draw on the ID Sample
            string zero = "0";
            string one = "1";   //
            string studentName = "Name : "; 
            string id = "ID : ";
            string doc = "Instructor : Dr. " + instructor.Text; //Name of the instructor(entered by user)
            string timetext = "Time :" + time.Text + " Minutes";//time of the exam(etered by user)
            newImage = new Bitmap(4961, 7016);  //create image to be drawn at
            Rectangle ImageSize = new Rectangle(0,0,4961,7016); //used to give the image a white background
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
            Brush brush = new SolidBrush(Color.Black);  //brush to color circles with
            int idInitialSquareX = 3620;    //coordinates of the squares where the student will WRITE his ID
            int idInitialSquareY = 150;     //
            int idInitialCircleX = 3640;    //coordinates of the circles where the student will COLOR his ID
            int idInitialCircleY = 290;     //  
            Rectangle[] recArray = new Rectangle[9];    //ID rectangles
            for (int i = 0; i < 9; i++) //put the nine squares where the student will WRITE his id in an array
            {
                recArray[i] = new Rectangle(idInitialSquareX, idInitialSquareY, 120, 120);
                idInitialSquareX = idInitialSquareX + 120;
            }
            g.DrawRectangles(pen, recArray);    //draw array of rectangles where student will WRITE his/her ID 
            g.DrawString(bau, font2, brush, 550, 150);  //draw BAU
            g.DrawString(bau2, font2, brush, 700, 300); //draw BAU in Arabic
            g.DrawLine(pen, new Point(500, 500), new Point(2000, 500)); //draw line under BAU Arabic
            g.DrawString(studentName, font4, brush, new PointF(2200, 428)); //draw student Name
            g.DrawLine(pen2, new Point(2500, 500), new Point(3500, 500));   //draw line for student to write his/her name
            g.DrawString(id, font5, brush, new PointF(3425, 160));  //draw "ID: "
            g.DrawString(two,font,brush,new Point(3645,175));   //fill first three squares with default values of 201
            g.DrawString(zero, font, brush, new Point(3765, 175));//
            g.DrawString(one, font, brush, new Point(3885, 175));//
            g.DrawString(facultyOf,font3,brush,new PointF(200,650));    //draw faculty name
            g.DrawString(pro, font4, brush, new PointF(200, 800));      //draw department name
            g.DrawString(crsNAME, font4, brush, new PointF(200, 920));  //draw Course name
            g.DrawString(whatExam, font5, brush, new PointF(2200, 1080));   //draw what exam this is      
            g.DrawString(doc, font4, brush, new PointF(200, 1040));         //draw instructor name
            g.DrawString(timetext, font5, brush, new PointF(2100, 1200));   //draw time allowed for exam
            if (mark.Text != "")    //if user entered a total mark for the exam, draw it
            {
                string totalMARK = "Total Mark :" + " " + mark.Text;
                g.DrawString(totalMARK, font5, brush, new PointF(2125, 1320));
            }
            for (int i = 0; i < 10; i++)    //here we draw the ID circles where the student will color his/her ID
            {
                for (int j = 0; j < 9; j++)
                {
                    g.DrawEllipse(pen, idInitialCircleX, idInitialCircleY, 80, 80);
                    idInitialCircleX = idInitialCircleX + 120;
                }
                idInitialCircleX = 3640;
                g.DrawString(i.ToString(), font, brush, new PointF(4605 + 120 , idInitialCircleY)); //numbers drawn to each the right of each circles row to inform the student of the circle number he is about to color
                idInitialCircleY = idInitialCircleY + 110;
            }
            g.FillEllipse(brush, 3760, 290, 80, 80);    //color three given circles
            g.FillEllipse(brush, 3880, 400, 80, 80);    //
            g.FillEllipse(brush, 3640, 510, 80, 80);    //
            for (int i = 0; i < 15; i++)    //draw 15 empty circles that represent the encoded represenation of the given course
            {
                g.DrawEllipse(pen, codeCoordinates.X, codeCoordinates.Y, 80, 80);
                codeCoordinates.X = codeCoordinates.X + 120;
            }
            codeCoordinates = new Point(1600, 650); //reset the starting point of the code circles
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
                codeCoordinates.X = codeCoordinates.X + 120;    //increment the circle position by 120 pixels
            }
            for (int j = 0; j < 4; j++) //color the final 4 circles according to the encoding of the third digit of the given course Number
            {
                if (num3[j] == 1)
                {
                    g.FillEllipse(brush, codeCoordinates.X, codeCoordinates.Y, 80, 80);
                }
                codeCoordinates.X = codeCoordinates.X + 120;    //increment the circle position by 120 pixels
            }
            g.DrawRectangle(pen, 1550, 600, 1850, 180); //draw a rectangle around the course encoding
            columnWidth = (250 * (int)numberOfOptions.Value) + 200; //give a value of column width according to the number of options
            List<string> options = new List<string>();  //list that contains the options per question
            if (numberOfOptions.Value == 2) //if the user wants 2 options per question
            {
                options.Add("A");
                options.Add("B");
            }
            else if (numberOfOptions.Value == 3)    //if the user wants 3 options per question
            {
                options.Add("A");
                options.Add("B");
                options.Add("C");
            }
            else if (numberOfOptions.Value == 4)    //if the user wants 4 options per question
            {
                options.Add("A");
                options.Add("B");
                options.Add("C");
                options.Add("D");
            }
            else if (numberOfOptions.Value == 5)    //if the user wants 5 options per question
            {
                options.Add("A");
                options.Add("B");
                options.Add("C");
                options.Add("D");
                options.Add("E");
            }
            if (numberOfQuestions.Value <= 40)  //if the number given by user is less than 40
            {
                int initialPointX = (4961 - columnWidth) / 2;   //coordinates of the number of each question
                int initialPointY = 1650; //
                int initialOptionsX = initialPointX + 200;      //coordinates of the options to be drawn(ex: A B C D)
                int initialOptionsY = 1530; //
                int circleStartX = initialOptionsX; //coordinates of the circles to be drawn
                int circleStartY = initialPointY;   //
                int optionsX = initialOptionsX;     //Position where to start drawing the options
                int questionsY = initialPointY;     //Y coordinate of where to draw the number of each question
                List <string> questions = new List<string>();   //list thatcontains the number of questions given by user
                for(int j = 1 ; j<=numberOfQuestions.Value ; j++)   //it should contain all numbers from 1 to number of questions given
                    questions.Add(j.ToString());
                for (int i = 0; i < numberOfQuestions.Value; i++)   //draw each question number
                {
                    g.DrawString(questions[i], font, brush, new PointF(initialPointX, questionsY));
                    questionsY = questionsY + 130;  //increment the Y coordiante of where we draw each number
                }
                for (int i = 0; i < numberOfOptions.Value; i++) //draw the options per question(draw once on top of each column)
                {
                    g.DrawString(options[i], font, brush, new PointF(optionsX, initialOptionsY));
                    optionsX = optionsX + 250;  //increment the X of where we draw each option
                }
                for (int m = 0; m < numberOfQuestions.Value; m++)   //draw the circles 
                {
                    for (int k = 0; k < numberOfOptions.Value; k++)
                    {
                        g.DrawEllipse(pen, circleStartX, circleStartY, 75, 75);
                        circleStartX = circleStartX + 250;  //increment the X position of each circle of a question by 250 pixels
                    }
                    circleStartX = initialOptionsX; //when we move to another question, reset the X coordinate of the circle
                    circleStartY = circleStartY + 130;  // and increment the Y coordinate by 130 pixels
                }
            }
            else if (numberOfQuestions.Value > 40 && numberOfQuestions.Value <= 80) //if number of questions is between 41 and 80
            {
                int initialPointX = (4961 - (2*columnWidth) - distanceBetweenColumns) / 3;  //same vairables with different values
                int initialPointY = 1650;   //
                int initialOptionsX = initialPointX + 200;  //
                int initialOptionsY = 1530;     //
                int circleStartX = initialOptionsX;//
                int circleStartY = initialPointY;//
                int optionsX = initialOptionsX;//
                int questionsY = initialPointY;//
                if (numberOfQuestions.Value > 40 && numberOfQuestions.Value <= 60) //if the number of questions is between 41 and 60
                {   //increase the Y coordinate of where we draw everything(for a better design)
                    initialOptionsY = 2030; 
                    circleStartY = initialPointY = questionsY = 2150;
                }
                distanceBetweenColumns = 1063;  //distance that separates the two columns
                int x = (int)numberOfQuestions.Value / 2;   //x will be used to separate the drawing of circles and questions numbers between the two columns
                List<string> questionsSet1 = new List<string>();    //questionsSet1 contains all the numbers from 1 to number of given questions
                for (int j = 1; j <= numberOfQuestions.Value; j++)
                    questionsSet1.Add(j.ToString());
                for (int i = 0; i < numberOfOptions.Value; i++) //draw the number of options on top of the first column
                {
                    g.DrawString(options[i], font, brush, new PointF(optionsX, initialOptionsY));
                    optionsX = optionsX + 250;
                }
                for (int j = 0; j < x; j++) //on the first column
                {
                    g.DrawString(questionsSet1[j], font, brush, new PointF(initialPointX, questionsY));//draw the number of questions 
                    questionsY = questionsY + 130;//increment the Y of each question drawn
                    for (int k = 0; k < numberOfOptions.Value; k++) //draw circles for each question according to the number of options
                    {
                        g.DrawEllipse(pen, circleStartX, circleStartY, 75, 75);
                        circleStartX = circleStartX + 250;  //increment the X of each circle drawn
                    }
                     circleStartX = initialOptionsX;    //give X it's initial X coordinate
                     circleStartY = circleStartY + 130; //increment the Y coordinate of the circles when we move to another question
                }
                initialPointX = initialPointX + distanceBetweenColumns + columnWidth;   //as we move to another column
                initialOptionsX = initialPointX + 200;      //all the previous values will change;
                circleStartX = initialOptionsX;
                circleStartY = initialPointY;
                optionsX = initialOptionsX;
                questionsY = initialPointY;
                for (int i = 0; i < numberOfOptions.Value; i++)     //then the same process will be repeated
                {
                    g.DrawString(options[i], font, brush, new PointF(optionsX, initialOptionsY));   
                    optionsX = optionsX + 250;
                }
                for (int j = x; j < numberOfQuestions.Value; j++)   //but this time on the second column
                {
                    g.DrawString(questionsSet1[j], font, brush, new PointF(initialPointX, questionsY));
                    questionsY = questionsY + 130;
                    for (int k = 0; k < numberOfOptions.Value; k++)
                    {
                        g.DrawEllipse(pen, circleStartX, circleStartY, 75, 75);
                        circleStartX = circleStartX + 250;
                    }
                    circleStartX = initialOptionsX;
                    circleStartY = circleStartY + 130;
                }
            }
                /*
                 * Same algorithm applies when number of questions is between 80 and 120. We move from
                 * column to column and change the values accordingly
                 * And on each column we draw the number of questions in it, number of options on it's top,
                 * And the circles per question
                */
            else if (numberOfQuestions.Value > 80 && numberOfQuestions.Value <= 120)
            {
                distanceBetweenColumns = 531;
                int initialPointX = (4961 - (2 * columnWidth) - (distanceBetweenColumns)) / 2 - 200;
                int initialPointY = 1650;
                int initialOptionsX = initialPointX + 200;
                int initialOptionsY = 1530;
                int circleStartX = initialOptionsX;
                int circleStartY = initialPointY;
                int optionsX = initialOptionsX;
                int questionsY = initialPointY;
                if (numberOfQuestions.Value > 80 && numberOfQuestions.Value <= 100)
                {
                    initialOptionsY = 2030;
                    circleStartY = initialPointY = questionsY = 2150;
                }
                int x = (int)numberOfQuestions.Value / 3;
                List<string> questionsSet1 = new List<string>();
                for (int j = 1; j <= numberOfQuestions.Value; j++)
                    questionsSet1.Add(j.ToString());
                for (int i = 0; i < numberOfOptions.Value; i++)
                {
                    g.DrawString(options[i], font, brush, new PointF(optionsX, initialOptionsY));
                    optionsX = optionsX + 150;
                }
                for (int j = 0; j < x; j++)
                {
                    g.DrawString(questionsSet1[j], font, brush, new PointF(initialPointX, questionsY));
                    questionsY = questionsY + 130;
                    for (int k = 0; k < numberOfOptions.Value; k++)
                    {
                        g.DrawEllipse(pen, circleStartX, circleStartY, 75, 75);
                        circleStartX = circleStartX + 150;
                    }
                    circleStartX = initialOptionsX;
                    circleStartY = circleStartY + 130;
                }
                initialPointX = (4961 - (2 * columnWidth) - (distanceBetweenColumns)) / 2 + columnWidth - 200;
                initialOptionsX = initialPointX + 200;
                circleStartX = initialOptionsX;
                circleStartY = initialPointY;
                optionsX = initialOptionsX;
                questionsY = initialPointY;
                for (int i = 0; i < numberOfOptions.Value; i++)
                {
                    g.DrawString(options[i], font, brush, new PointF(optionsX, initialOptionsY));
                    optionsX = optionsX + 150;
                }
                for (int j = x; j < 2 * x; j++)
                {
                    g.DrawString(questionsSet1[j], font, brush, new PointF(initialPointX, questionsY));
                    questionsY = questionsY + 130;
                    for (int k = 0; k < numberOfOptions.Value; k++)
                    {
                        g.DrawEllipse(pen, circleStartX, circleStartY, 75, 75);
                        circleStartX = circleStartX + 150;
                    }
                    circleStartX = initialOptionsX;
                    circleStartY = circleStartY + 130;
                }
                initialPointX = (4961 - (2 * columnWidth) - (distanceBetweenColumns)) / 2 + (2*columnWidth) - 200;
                initialOptionsX = initialPointX + 200;
                circleStartX = initialOptionsX;
                circleStartY = initialPointY;
                optionsX = initialOptionsX;
                questionsY = initialPointY;
                for (int i = 0; i < numberOfOptions.Value; i++)
                {
                    g.DrawString(options[i], font, brush, new PointF(optionsX, initialOptionsY));
                    optionsX = optionsX + 150;
                }
                for (int j = 2 * x; j < numberOfQuestions.Value; j++)
                {
                    g.DrawString(questionsSet1[j], font, brush, new PointF(initialPointX, questionsY));
                    questionsY = questionsY + 130;
                    for (int k = 0; k < numberOfOptions.Value; k++)
                    {
                        g.DrawEllipse(pen, circleStartX, circleStartY, 75, 75);
                        circleStartX = circleStartX + 150;
                    }
                    circleStartX = initialOptionsX;
                    circleStartY = circleStartY + 130;
                }
            }
            /*
             * Same algorithm applies when number of questions is between 120 and 160. We move from
             * column to column and change the values accordingly
             * And on each column we draw the number of questions in it, number of options on it's top,
             * And the circles per question
            */
            else if (numberOfQuestions.Value > 120 && numberOfQuestions.Value <= 160)
            {
                distanceBetweenColumns = 177;
                int initialPointX = (4961 - (2 * columnWidth) - (distanceBetweenColumns)) / 2 - 750;
                int initialPointY = 1650;
                int initialOptionsX = initialPointX + 200;
                int initialOptionsY = 1530;
                int circleStartX = initialOptionsX;
                int circleStartY = initialPointY;
                int optionsX = initialOptionsX;
                int questionsY = initialPointY;
                if (numberOfQuestions.Value > 120 && numberOfQuestions.Value <= 140)
                {
                    initialOptionsY = 2030;
                    circleStartY = initialPointY = questionsY = 2150;
                }
                int x = (int)numberOfQuestions.Value / 4;
                List<string> questionsSet1 = new List<string>();
                for (int j = 1; j <= numberOfQuestions.Value; j++)
                    questionsSet1.Add(j.ToString());
                for (int i = 0; i < numberOfOptions.Value; i++)
                {
                    g.DrawString(options[i], font, brush, new PointF(optionsX, initialOptionsY));
                    optionsX = optionsX + 150;
                }
                for (int j = 0; j < x; j++)
                {
                    g.DrawString(questionsSet1[j], font, brush, new PointF(initialPointX, questionsY));
                    questionsY = questionsY + 130;
                    for (int k = 0; k < numberOfOptions.Value; k++)
                    {
                        g.DrawEllipse(pen, circleStartX, circleStartY, 75, 75);
                        circleStartX = circleStartX + 150;
                    }
                    circleStartX = initialOptionsX;
                    circleStartY = circleStartY + 130;
                }
                initialPointX = (4961 - (3 * columnWidth) - (distanceBetweenColumns)) / 2 + columnWidth - 300;
                initialOptionsX = initialPointX + 200;
                circleStartX = initialOptionsX;
                circleStartY = initialPointY;
                optionsX = initialOptionsX;
                questionsY = initialPointY;
                for (int i = 0; i < numberOfOptions.Value; i++)
                {
                    g.DrawString(options[i], font, brush, new PointF(optionsX, initialOptionsY));
                    optionsX = optionsX + 150;
                }
                for (int j = x; j < 2 * x; j++)
                {
                    g.DrawString(questionsSet1[j], font, brush, new PointF(initialPointX, questionsY));
                    questionsY = questionsY + 130;
                    for (int k = 0; k < numberOfOptions.Value; k++)
                    {
                        g.DrawEllipse(pen, circleStartX, circleStartY, 75, 75);
                        circleStartX = circleStartX + 150;
                    }
                    circleStartX = initialOptionsX;
                    circleStartY = circleStartY + 130;
                }
                initialPointX = (4961 - (3 * columnWidth) - (distanceBetweenColumns)) / 2 + (2 * columnWidth) - 450;
                initialOptionsX = initialPointX + 200;
                circleStartX = initialOptionsX;
                circleStartY = initialPointY;
                optionsX = initialOptionsX;
                questionsY = initialPointY;
                for (int i = 0; i < numberOfOptions.Value; i++)
                {
                    g.DrawString(options[i], font, brush, new PointF(optionsX, initialOptionsY));
                    optionsX = optionsX + 150;
                }
                for (int j = 2 * x; j < 3 * x; j++)
                {
                    g.DrawString(questionsSet1[j], font, brush, new PointF(initialPointX, questionsY));
                    questionsY = questionsY + 130;
                    for (int k = 0; k < numberOfOptions.Value; k++)
                    {
                        g.DrawEllipse(pen, circleStartX, circleStartY, 75, 75);
                        circleStartX = circleStartX + 150;
                    }
                    circleStartX = initialOptionsX;
                    circleStartY = circleStartY + 130;
                }
                initialPointX = (4961 - (2*columnWidth) - (distanceBetweenColumns)) / 2 + (2 * columnWidth) ;
                initialOptionsX = initialPointX + 200;
                circleStartX = initialOptionsX;
                circleStartY = initialPointY;
                optionsX = initialOptionsX;
                questionsY = initialPointY;
                for (int i = 0; i < numberOfOptions.Value; i++)
                {
                    g.DrawString(options[i], font, brush, new PointF(optionsX, initialOptionsY));
                    optionsX = optionsX + 150;
                }
                for (int j = 3 * x; j < numberOfQuestions.Value; j++)
                {
                    g.DrawString(questionsSet1[j], font, brush, new PointF(initialPointX, questionsY));
                    questionsY = questionsY + 130;
                    for (int k = 0; k < numberOfOptions.Value; k++)
                    {
                        g.DrawEllipse(pen, circleStartX, circleStartY, 75, 75);
                        circleStartX = circleStartX + 150;
                    }
                    circleStartX = initialOptionsX;
                    circleStartY = circleStartY + 130;
                }
            }
            mcqImage((Bitmap)newImage); //send the final image to a new form 
            codeCoordinates = new Point(1600, 650); //reset the code coordinates in case the user chose to return and edit the exam info
        }
        

        private void mcqMain_Load(object sender, EventArgs e)   //occurs when the form loads
        {
            this.ActiveControl = crsNumber; //have the user enter the crsNumber since it is the only input that has conditions
            errorLabel.Hide();  //do not show an error label
            /*
             * Here we are encoding each course Code to it's relative binary representation
            */
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
             * Here we are adding the type of the exam
             * In the exam type drop down menu
            */
            exam.Items.Add("Quiz");
            exam.Items.Add("Midterm 1");
            exam.Items.Add("Midterm 2");
            exam.Items.Add("Final Exam");
            exam.SelectedIndex = 1;
        }
        private void mcqImage(Bitmap image) //function that loads the created sample
        {
            mcqImage test = new mcqImage(image);
            test.Show();
        }
        private void backToMainBTN_Click(object sender, EventArgs e)    //when Back button is clicked
        {
            this.Close();   //close this form
            main main = new main();
            main.Show();    //return to main menu
        }

        private void crsNumber_Leave(object sender, EventArgs e)    //event when the user has left the course number field
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
                    return;
            }
        }

        private void crsNumber_TextChanged(object sender, EventArgs e)  //when the user changes the text inside the courseNumber textBox
        {
            errorLabel.Text = "";   //remove error message
            errorLabel.Hide();
        }
    }
}
