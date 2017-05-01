using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_demo3
{
    public partial class Demo3NewForm : Form
    {
        public Demo3NewForm()
        {
            InitializeComponent();
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Form1 form1 = new Form1();
            //form1.Show();
            //form1.StartPosition = FormStartPosition.CenterParent;
            
            Demo3FormRichTextBox.FormState.previousPage.StartPosition = FormStartPosition.CenterParent;
            Demo3FormRichTextBox.FormState.previousPage.Show();

            Demo3FormRichTextBox.FormState.previousPage = this;

        }
    }
}
