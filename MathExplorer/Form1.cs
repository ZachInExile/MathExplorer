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
        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(radioButtonEasy, "Gain " + intPointsEasy.ToString() + " points per correct answer, lose " + intWrongEasy.ToString() + " points per incorrect answer.");
            toolTip1.SetToolTip(radioButtonMedium, "Gain " + intPointsMedium.ToString() + " points per correct answer, lose " + intWrongMedium.ToString() + " points per incorrect answer.");
            toolTip1.SetToolTip(radioButtonHard, "Gain " + intPointsHard.ToString() + " points per correct answer, lose " + intWrongHard.ToString() + " points per incorrect answer.");
        }
    }
}
