using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryNumberGenerator
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLotteryClick_Click(object sender, EventArgs e)
        {
            int[] lotteryNumber = new int[6];

            showAnimatedPictureBox(pictureBox2);

            foreach (Control control in Controls)
            {
                Label numberLable = control as Label;

                if (numberLable != null)
                {

                    for (int i = 0; i < 5; i++)
                    {
                        int lNumber = 0;
                        do
                        {
                            lNumber = random.Next(1, 59);
                        }
                        while (lotteryNumber.Contains(lNumber));

                        lotteryNumber[i] = lNumber;

                        numberLable.Text = lNumber.ToString();

                    }
                }
            }
        }

        public void showAnimatedPictureBox(PictureBox thePicture)
        {
            Image[] img = new Image[6];

            img[0] = Properties.Resources.Image1;
            img[1] = Properties.Resources.Image2;
            img[2] = Properties.Resources.Image3;
            img[3] = Properties.Resources.Image4;
            img[4] = Properties.Resources.Image5;
            img[5] = Properties.Resources.Image6;

            int i = random.Next(0, 5);
            thePicture.Image = img[i];
            thePicture.Refresh();
            thePicture.Visible = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTryyourLuck_Click(object sender, EventArgs e)
        {

            FormSelectNumbers form1 = new FormSelectNumbers();

            form1.Show();
            
            this.Hide();
            FormState.previouspage = this;

            

        }

        public static class FormState
        {
            public static Form previouspage;

        }

    }
}
