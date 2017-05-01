using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Demo4
{
    public partial class LotteryForm1 : Form
    {
        Random random = new Random();
                      
        public LotteryForm1()
        {
            InitializeComponent();
            //string[][] Array = new string[59][];
            //DataTable dt = new DataTable();
            //int l = Array.Length;
            //for (int i = 0; i < l; i++)
            //{
            //    //dt.LoadDataRow(Array[i], false); //Pass array object to LoadDataRow method
            //}
            //dataGridView1.DataSource = dt;

        }

        private void buttonLotteryClick_Click(object sender, EventArgs e)
        {
            int[] lotteryNumber = new int[6];

            showAnimatedPictureBox(pictureBox1);

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
    }
}

