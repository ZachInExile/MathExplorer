using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathExplorer
{
    public partial class Form1 : Form
    {
        public int intPointsEasy = 5; //Points gained for a right answer in Easy
        public int intWrongEasy = 1; //Points subtracted for wrong answer in Easy

        public int intPointsMedium = 20;
        public int intWrongMedium = 10;

        public int intPointsHard = 50;
        public int intWrongHard = 50;

        public int intPoints = 0; //The points you have

        public bool boolAddEnabled;
        public bool boolSubEnabled;
        public bool boolMultiEnabled;

        public int intQuestionType;
        public int intQuestionP1;
        public int intQuestionP2;
        public string strQuestion;

        public int intRightAnswer; //The actual answer to the generated question
        public int intAnswer; //The user's answer
        public string strAnswer;
        
        public int RInt;

        public bool boolPlaying = false; //Whether the game is actually being played at any given time

        public int intTimePerAnswer;
        public int intTimeLeft = 0;

        public int intLightningTime;

        public Stopwatch stopWatch = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(radioButtonEasy, "Gain " + intPointsEasy.ToString() + " points per correct answer, lose " + intWrongEasy.ToString() + " points per incorrect answer.");
            toolTip1.SetToolTip(radioButtonMedium, "Gain " + intPointsMedium.ToString() + " points per correct answer, lose " + intWrongMedium.ToString() + " points per incorrect answer.");
            toolTip1.SetToolTip(radioButtonHard, "Gain " + intPointsHard.ToString() + " points per correct answer, lose " + intWrongHard.ToString() + " points per incorrect answer.");
            toolTip1.SetToolTip(textBoxLightning, "In lightning mode, your remaining time doesn't reset when you answer. Instead, you want to answer as many questions as possibl. (In seconds, entered here.)");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            intTimeLeft -= 1;
            labelTimeRemaining.Text = "Time Remaining: " + intTimeLeft.ToString();
            labelPoints.Text = "Points: " + intPoints.ToString();

            if (intTimeLeft <= 0)
            {
                TimesUp();
            }
        }
        public void GenerateQuestion()
        {
            GenerateQuestionType();

            Random R = new Random();

            if (radioButtonEasy.Checked)
            {
                intQuestionP1 = R.Next(1, 5);
                intQuestionP2 = R.Next(1, 5);
            }
            else if (radioButtonMedium.Checked)
            {
                intQuestionP1 = R.Next(1, 20);
                intQuestionP2 = R.Next(1, 20);
            }
            else if (radioButtonHard.Checked)
            {
                intQuestionP1 = R.Next(1, 100);
                intQuestionP2 = R.Next(1, 100);
            }

            if (intQuestionType == 0) //Addition
            {
                intRightAnswer = intQuestionP1 + intQuestionP2;
                strQuestion = intQuestionP1.ToString() + " + " + intQuestionP2.ToString() + " = ?";
            }
            else if (intQuestionType == 1) //Subtraction
            {
                intRightAnswer = Math.Max(intQuestionP1, intQuestionP2) - Math.Min(intQuestionP1, intQuestionP2);
                strQuestion = Math.Max(intQuestionP1, intQuestionP2).ToString() + " - " + Math.Min(intQuestionP1, intQuestionP2).ToString() + " = ?";
            }
            else if (intQuestionType == 2) //Multiplication
            {
                intRightAnswer = intQuestionP1 * intQuestionP2;
                strQuestion = intQuestionP1.ToString() + " x " + intQuestionP2.ToString() + " = ?";
            }
        }
        public void GenerateQuestionType()
        {
            bool QuestionTypeGenerated = false;

            while (QuestionTypeGenerated == false)
            {
                Random R = new Random();
                RInt = R.Next(0, 3);

                if (RInt == 0 && boolAddEnabled)
                {
                    //addition question
                    QuestionTypeGenerated = true;
                    intQuestionType = 0;
                }
                else if (RInt == 1 && boolSubEnabled)
                {
                    //subtraction question
                    QuestionTypeGenerated = true;
                    intQuestionType = 1;
                }
                else if (RInt == 2 && boolMultiEnabled)
                {
                    //multiplication question
                    QuestionTypeGenerated = true;
                    intQuestionType = 2;
                }
            }
        }
        public void SubmitAnswer()
        {
            strAnswer = textBoxAnswer.Text;
            textBoxAnswer.Text = "";

            bool success = Int32.TryParse(strAnswer, out intAnswer);
            if (success)
            {
                Console.WriteLine("Converted '{0}' to {1}.", strAnswer, intAnswer);

                if (intAnswer == intRightAnswer)
                {
                    if (radioButtonEasy.Checked)
                    {
                        listBox1.Items.Add("Correct! +" + intPointsEasy + " points");
                        intPoints += intPointsEasy;
                        listBox1.SelectedIndex += 1;
                    }
                    if (radioButtonMedium.Checked)
                    {
                        listBox1.Items.Add("Correct! +" + intPointsMedium + " points");
                        intPoints += intPointsMedium;
                        listBox1.SelectedIndex += 1;
                    }
                    if (radioButtonHard.Checked)
                    {
                        listBox1.Items.Add("Correct! +" + intPointsHard + " points");
                        intPoints += intPointsHard;
                        listBox1.SelectedIndex += 1;
                    }
                }
                else
                {
                    if (radioButtonEasy.Checked)
                    {
                        listBox1.Items.Add("Incorrect, lost " + intWrongEasy + " points. Correct answer was " + intRightAnswer.ToString() + ", you answered " + intAnswer.ToString());
                        intPoints -= intWrongEasy;
                        listBox1.SelectedIndex += 1;
                    }
                    if (radioButtonMedium.Checked)
                    {
                        listBox1.Items.Add("Incorrect, lost " + intWrongMedium + " points. Correct answer was " + intRightAnswer.ToString() + ", you answered " + intAnswer.ToString());
                        intPoints -= intWrongMedium;
                        listBox1.SelectedIndex += 1;
                    }
                    if (radioButtonHard.Checked)
                    {
                        listBox1.Items.Add("Incorrect, lost " + intWrongHard + " points. Correct answer was " + intRightAnswer.ToString() + ", you answered " + intAnswer.ToString());
                        intPoints -= intWrongHard;
                        listBox1.SelectedIndex += 1;
                    }
                }
            }
            else
            {
                MessageBox.Show("Tryparse error");
            }

            Play();
        }
        public void TimesUp()
        {
            boolPlaying = false;
            timer1.Enabled = false;
            if (radioButtonLightningOFF.Checked)
            {
                if (intPoints <= 0)
                {
                    MessageBox.Show("Time to study! You got " + intPoints.ToString() + " points... You played for: " + stopWatch.Elapsed.ToString());
                }
                else if (intPoints > 0 & intPoints < 100)
                {
                    MessageBox.Show("Good job!! you managed to score " + intPoints.ToString() + " points. You played for: " + stopWatch.Elapsed.ToString());
                }
                else if (intPoints >= 100 & intPoints < 500)
                {
                    MessageBox.Show("Awesome!!! You got " + intPoints.ToString() + " points. You played for: " + stopWatch.Elapsed.ToString());
                }
                else if (intPoints >= 500 & intPoints < 1000)
                {
                    MessageBox.Show("Wow!!!! " + intPoints.ToString() + " points! You played for: " + stopWatch.Elapsed.ToString());
                }
                else if (intPoints >= 1000)
                {
                    MessageBox.Show("You are a true Math Explorer!!!!! " + intPoints.ToString() + " points. You played for: " + stopWatch.Elapsed.ToString());
                }
            }
            else
            {
                if (intPoints <= 0)
                {
                    MessageBox.Show("Time to study! You got " + intPoints.ToString() + " points... (" + intLightningTime.ToString() + " second Lightning Mode)");
                }
                else if (intPoints > 0 & intPoints < 100)
                {
                    MessageBox.Show("Good job!! You managed to score " + intPoints.ToString() + " points. (" + intLightningTime.ToString() + " second Lightning Mode)");
                }
                else if (intPoints >= 100 & intPoints < 500)
                {
                    MessageBox.Show("Awesome!!! You gotou got " + intPoints.ToString() + " points. (" + intLightningTime.ToString() + " second Lightning Mode)");
                }
                else if (intPoints >= 500 & intPoints < 1000)
                {
                    MessageBox.Show("Wow!!!! " + intPoints.ToString() + " points! (" + intLightningTime.ToString() + " second Lightning Mode)");
                }
                else if (intPoints >= 1000)
                {
                    MessageBox.Show("You are a true Math Explorer!!!!! " + intPoints.ToString() + " points. (" + intLightningTime.ToString() + " second Lightning Mode)");
                }
            }

        }
        public void Play()
        {
            GenerateQuestion();

            listBox1.Items.Add(strQuestion);
            listBox1.SelectedIndex += 1;
            if (radioButtonLightningOFF.Checked)
            {
                intTimeLeft = intTimePerAnswer;
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (boolPlaying)
            {
                stopWatch.Stop();
                timer1.Enabled = false;
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to quit early?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    TimesUp();
                }
                else if (dialogResult == DialogResult.No)
                {
                    timer1.Enabled = true;
                    stopWatch.Start();
                }
            }
            else
            {
                stopWatch.Reset();
                stopWatch.Start();

                if (radioButtonLightningON.Checked)
                {
                    bool success = Int32.TryParse(textBoxLightning.Text, out intLightningTime);
                    if (success)
                    {
                        intTimeLeft = intLightningTime;
                    }
                    else
                    {
                        MessageBox.Show("Invalid time (in seconds) in the Lightning Mode text box. Enter a valid time in seconds or disable Lightning Mode", "Error");
                    }
                }

                if (checkBoxAddition.Checked == false && checkBoxSubtraction.Checked == false && checkBoxMultiplication.Checked == false)
                {
                    MessageBox.Show("You have to enable at least one of addition, subtraction, or multiplication.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (radioButton10s.Checked)
                    {
                        intTimePerAnswer = 10;
                    }
                    else if (radioButton20s.Checked)
                    {
                        intTimePerAnswer = 20;
                    }
                    else if (radioButton60s.Checked)
                    {
                        intTimePerAnswer = 60;
                    }

                    if (checkBoxAddition.Checked)
                    {
                        boolAddEnabled = true;
                    }
                    else
                    {
                        boolAddEnabled = false;
                    }
                    if (checkBoxSubtraction.Checked)
                    {
                        boolSubEnabled = true;
                    }
                    else
                    {
                        boolSubEnabled = false;
                    }
                    if (checkBoxMultiplication.Checked)
                    {
                        boolMultiEnabled = true;
                    }
                    else
                    {
                        boolMultiEnabled = false;
                    }

                    boolPlaying = true;
                    intPoints = 0;

                    if (radioButtonLightningOFF.Checked)
                    {
                        intTimeLeft = intTimePerAnswer;
                    }

                    Play();
                }
            }
        }
        private void textBoxAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SubmitAnswer();
            }
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            SubmitAnswer();
        }

        private void timer2_OnTick(object sender, EventArgs e)
        {
            if (boolPlaying)
            {
                buttonPlay.Text = "Quit";
                timer1.Enabled = true;
                labelTimeRemaining.Visible = true;
                labelPoints.Visible = true;
                labelPoints.Text = "Points: " + intPoints.ToString();
                textBoxAnswer.Enabled = true;
                buttonAnswer.Enabled = true;
                labelElapsed.Visible = true;
                labelElapsed.Text = "Time elapsed: " + stopWatch.Elapsed.ToString();

                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
            }
            else
            {
                buttonPlay.Text = "Play";
                timer1.Enabled = false;
                labelTimeRemaining.Visible = false;
                labelPoints.Visible = false;
                listBox1.Items.Clear();
                textBoxAnswer.Text = "";
                textBoxAnswer.Enabled = false;
                buttonAnswer.Enabled = false;
                labelElapsed.Visible = false;

                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
            }
            if (radioButtonLightningOFF.Checked)
            {
                textBoxLightning.Text = "";
                textBoxLightning.Enabled = false;
            }
            else
            {
                textBoxLightning.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }
    }
}
