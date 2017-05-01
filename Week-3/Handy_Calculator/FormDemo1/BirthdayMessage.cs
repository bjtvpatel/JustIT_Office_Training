using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDemo1
{
    public partial class BirthdayMessage : Form
    {
        public BirthdayMessage()
        {
            InitializeComponent();
        }

        private void btnShowMessage_Click(object sender, EventArgs e)
        {
            string name = textboxName.Text;
            DateTime today = DateTime.Now.Date;
            TimeSpan ageDays = today - dateTimeDOB.Value;
            int years = (int)(ageDays.TotalDays) / 365;
            int day = dateTimeDOB.Value.Day;

            string month = dateTimeDOB.Value.ToString("MMM");

            lableBirthdayMS.Text = "Hello " + name + "! You will be " + (years + 1) + " years old on " + day + " " + month + ".";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
