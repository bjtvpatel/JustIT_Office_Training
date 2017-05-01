using System;
using System.Collections;
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
    public partial class FormSelectNumbers : Form
    {
        public FormSelectNumbers()
        {
            InitializeComponent();
            int count = 0;
            int[,] num = new int[9,7];

           // int[] count = new int[59];       

            for(int i=0; i<9; i++)
            {

                for(int j=0; j<7; j++)
                {
                    num[i, j] = count++;

                    labelCount.Text += num[i,j];
                            
                }
            }
                        
            dataGridView1.DataSource = num;
            
        }

        private void buttonCheckResult_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1.FormState.previouspage.StartPosition = FormStartPosition.CenterParent;
            Form1.FormState.previouspage.Show();

            Form1.FormState.previouspage = this;


        }
    }
}
