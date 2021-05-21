﻿
namespace MathExplorer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonHard = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonEasy = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxAddition = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton60s = new System.Windows.Forms.RadioButton();
            this.radioButton20s = new System.Windows.Forms.RadioButton();
            this.radioButton10s = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.labelPoints = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBoxAddition);
            this.groupBox1.Controls.Add(this.radioButtonHard);
            this.groupBox1.Controls.Add(this.radioButtonMedium);
            this.groupBox1.Controls.Add(this.radioButtonEasy);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Difficulty";
            // 
            // radioButtonHard
            // 
            this.radioButtonHard.AutoSize = true;
            this.radioButtonHard.Location = new System.Drawing.Point(6, 72);
            this.radioButtonHard.Name = "radioButtonHard";
            this.radioButtonHard.Size = new System.Drawing.Size(99, 19);
            this.radioButtonHard.TabIndex = 2;
            this.radioButtonHard.Text = "Math Explorer";
            this.radioButtonHard.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.Location = new System.Drawing.Point(6, 47);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(92, 19);
            this.radioButtonMedium.TabIndex = 1;
            this.radioButtonMedium.Text = "Intermediate";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonEasy
            // 
            this.radioButtonEasy.AutoSize = true;
            this.radioButtonEasy.Checked = true;
            this.radioButtonEasy.Location = new System.Drawing.Point(6, 22);
            this.radioButtonEasy.Name = "radioButtonEasy";
            this.radioButtonEasy.Size = new System.Drawing.Size(72, 19);
            this.radioButtonEasy.TabIndex = 1;
            this.radioButtonEasy.TabStop = true;
            this.radioButtonEasy.Text = "Beginner";
            this.radioButtonEasy.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // checkBoxAddition
            // 
            this.checkBoxAddition.AutoSize = true;
            this.checkBoxAddition.Location = new System.Drawing.Point(110, 22);
            this.checkBoxAddition.Name = "checkBoxAddition";
            this.checkBoxAddition.Size = new System.Drawing.Size(72, 19);
            this.checkBoxAddition.TabIndex = 1;
            this.checkBoxAddition.Text = "Addition";
            this.checkBoxAddition.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(110, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 19);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Subtraction";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(110, 72);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(100, 19);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Multiplication";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton10s);
            this.groupBox2.Controls.Add(this.radioButton20s);
            this.groupBox2.Controls.Add(this.radioButton60s);
            this.groupBox2.Location = new System.Drawing.Point(228, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time";
            // 
            // radioButton60s
            // 
            this.radioButton60s.AutoSize = true;
            this.radioButton60s.Checked = true;
            this.radioButton60s.Location = new System.Drawing.Point(6, 21);
            this.radioButton60s.Name = "radioButton60s";
            this.radioButton60s.Size = new System.Drawing.Size(84, 19);
            this.radioButton60s.TabIndex = 2;
            this.radioButton60s.TabStop = true;
            this.radioButton60s.Text = "60 Seconds";
            this.radioButton60s.UseVisualStyleBackColor = true;
            // 
            // radioButton20s
            // 
            this.radioButton20s.AutoSize = true;
            this.radioButton20s.Location = new System.Drawing.Point(6, 46);
            this.radioButton20s.Name = "radioButton20s";
            this.radioButton20s.Size = new System.Drawing.Size(84, 19);
            this.radioButton20s.TabIndex = 2;
            this.radioButton20s.Text = "20 Seconds";
            this.radioButton20s.UseVisualStyleBackColor = true;
            // 
            // radioButton10s
            // 
            this.radioButton10s.AutoSize = true;
            this.radioButton10s.Location = new System.Drawing.Point(6, 71);
            this.radioButton10s.Name = "radioButton10s";
            this.radioButton10s.Size = new System.Drawing.Size(84, 19);
            this.radioButton10s.TabIndex = 2;
            this.radioButton10s.Text = "10 Seconds";
            this.radioButton10s.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 184);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(348, 124);
            this.listBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 315);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 23);
            this.textBox1.TabIndex = 4;
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.Location = new System.Drawing.Point(140, 315);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(75, 23);
            this.buttonAnswer.TabIndex = 5;
            this.buttonAnswer.Text = "Answer";
            this.buttonAnswer.UseVisualStyleBackColor = true;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(12, 118);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(348, 60);
            this.buttonPlay.TabIndex = 6;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Location = new System.Drawing.Point(228, 318);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(115, 15);
            this.labelPoints.TabIndex = 7;
            this.labelPoints.Text = "Points: 1,000,000,000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 350);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonAnswer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonHard;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonEasy;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBoxAddition;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton10s;
        private System.Windows.Forms.RadioButton radioButton20s;
        private System.Windows.Forms.RadioButton radioButton60s;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAnswer;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label labelPoints;
    }
}

