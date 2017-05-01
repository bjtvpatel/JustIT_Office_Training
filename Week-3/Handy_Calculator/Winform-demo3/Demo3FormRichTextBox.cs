using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Winform_demo3
{
    public partial class Demo3FormRichTextBox : Form
    {
        public Demo3FormRichTextBox()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog myOpendialog = new OpenFileDialog();
            myOpendialog.DefaultExt = "*.txt";
            myOpendialog.Filter = "Text files (*.txt)| *.txt|All files(*.*)|*.*";

            if ((myOpendialog.ShowDialog() == DialogResult.OK) && (myOpendialog.FileName.Length > 0))
            {

                richTextBoxDisplay.LoadFile(myOpendialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void buttonNextpage_Click(object sender, EventArgs e)
        {
            Demo3NewForm newform = new Demo3NewForm();
            newform.Show();
            this.Hide();

            //newform.startposition = formstartposition.centerparent;
            
            FormState.previousPage = this;
                    

        }

        private void buttonChangeBG_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
            }

        }

        private void buttonChangeBG_MouseHover(object sender, EventArgs e)
        {
            buttonChangeBG.BackColor = Color.Aqua;
        }

        private void buttonChangeBG_MouseLeave(object sender, EventArgs e)
        {
            buttonChangeBG.BackColor = Color.Gray;
        }

        public static class FormState
        {
            public static Form previousPage;
        }





    }
    
}

