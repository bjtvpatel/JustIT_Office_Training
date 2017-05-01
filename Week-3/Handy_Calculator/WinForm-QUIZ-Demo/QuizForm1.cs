using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_QUIZ_Demo
{
    public partial class Quiz : Form
    {
        int timeLeft = 30;
        bool q1Correct = false;
        bool q2Correct = false;
        bool q3Correct = false;

        public Quiz()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;

            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;


        }

        private void rbQ1A1_Click(object sender, EventArgs e)
        {
            if (rbQ1A1.Checked)
            {
                labelFeedbackQ1.ForeColor = Color.Red;
                labelFeedbackQ1.Text = "\u00fb"; //unicode for wrong
                q1Correct = false;
            }
            else
            {
                labelFeedbackQ1.Text = "";

            }

        }

        private void rbQ1A2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbQ1A2.Checked)
            {
                labelFeedbackQ1.ForeColor = Color.Red;
                labelFeedbackQ1.Text = "\u00fb";        //unicode for wrong
                q1Correct = false;
            }
            else
            {
                labelFeedbackQ1.Text = "";

            }
        }

        private void rbQ1A3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbQ1A3.Checked)
            {
                labelFeedbackQ1.ForeColor = Color.Green;
                labelFeedbackQ1.Text= "\u00fc";             //unicode for tick
                q1Correct = true;
            }
            else
            {
                labelFeedbackQ1.Text = "";

            }
        }

        private void rbQ2A1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbQ2A1.Checked)
            {
                labelFeedbackQ2.ForeColor = Color.Red;
                labelFeedbackQ2.Text = "\u00fb";    //unicode for wrong
                q2Correct = false;
            }
            else
            {
                labelFeedbackQ2.Text = "";

            }
        }

        private void rbQ2A2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbQ2A2.Checked)
            {
                labelFeedbackQ2.ForeColor = Color.Green;
                labelFeedbackQ2.Text = "\u00fc";            //unicode for tick
                q2Correct = true;
            }
            else
            {
                labelFeedbackQ2.Text = "";

            }
        }

        private void rbQ2A3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbQ2A3.Checked)
            {
                labelFeedbackQ2.ForeColor = Color.Red;
                labelFeedbackQ2.Text = "\u00fb";    //unicode for wrong
                q2Correct = false;
            }
            else
            {
                labelFeedbackQ2.Text = "";

            }

        }

        private void rbQ3A1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbQ3A1.Checked)
            {
                labelFeedbackQ3.ForeColor = Color.Red;
                labelFeedbackQ3.Text = "\u00fb";    //unicode for wrong
                q3Correct = false;
            }
            else
            {
                labelFeedbackQ3.Text = "";

            }

        }

        private void rbQ3A2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbQ3A2.Checked)
            {
                labelFeedbackQ3.ForeColor = Color.Red;
                labelFeedbackQ3.Text = "\u00fb";    //unicode for wrong
                q3Correct = false;
            }
            else
            {
                labelFeedbackQ3.Text = "";

            }

        }

        private void rbQ3A3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbQ3A3.Checked)
            {
                labelFeedbackQ3.ForeColor = Color.Green;
                labelFeedbackQ3.Text = "\u00fc";   //unicode for tick
                q3Correct = true;
            }
            else
            {
                labelFeedbackQ3.Text = "";

            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;

            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            timer1.Start();

            buttonStart.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(q1Correct && q2Correct && q3Correct)
            {
                timer1.Stop();
                MessageBox.Show("You got all the answers correct", "Well done!");

            }
            else if (timeLeft > 0)
            {
                //update and display time
                timeLeft--;
                labelTimeLeft.Text = timeLeft + " seconds";

            }
            else
            {
                timer1.Stop();
                labelTimeLeft.Text = "Time's up!";
                MessageBox.Show("You ran out of time.", "Sorry");

            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
