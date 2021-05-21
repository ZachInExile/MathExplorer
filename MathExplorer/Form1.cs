using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public int intWrongEasy = 0; //Points subtracted for wrong answer in Easy

        public int intPointsMedium = 10;
        public int intWrongMedium = 5;

        public int intPointsHard = 20;
        public int intWrongHard = 10;

        public bool boolAddEnabled;
        public bool boolSubEnabled;
        public bool boolMultiEnabled;

        public string strQuestion;
        public int intQuestion;

        public int RInt;

        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(radioButtonEasy, "Gain " + intPointsEasy.ToString() + " points per correct answer, lose " + intWrongEasy.ToString() + " points per incorrect answer.");
            toolTip1.SetToolTip(radioButtonMedium, "Gain " + intPointsMedium.ToString() + " points per correct answer, lose " + intWrongMedium.ToString() + " points per incorrect answer.");
            toolTip1.SetToolTip(radioButtonHard, "Gain " + intPointsHard.ToString() + " points per correct answer, lose " + intWrongHard.ToString() + " points per incorrect answer.");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
        public void GenerateQuestion()
        {

        }
        public void GenerateQuestionType()
        {
            Random R = new Random();
            RInt = R.Next(0, 3);
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (checkBoxAddition.Checked == false && checkBoxSubtraction.Checked == false && checkBoxMultiplication.Checked == false)
            {
                MessageBox.Show("You have to enable at least one of addition, subtraction, or multiplication.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
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
            }
            GenerateQuestionType();
            listBox1.Items.Add(RInt.ToString());
            listBox1.SelectedIndex += 1;
        }
    }
}
