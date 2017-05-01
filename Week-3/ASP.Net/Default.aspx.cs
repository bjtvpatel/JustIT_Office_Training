using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = DateTime.Now.Date.Day.ToString() + "  " + DateTime.Now.Date.ToString();
        
        
    }



    protected void buttonClick_Click(object sender, EventArgs e)
    {
        lableDisplayname.Text = inputName.Value;
        lableDisplayname.BackColor = System.Drawing.Color.Aqua;
    }

    protected void buttonCheckbox1_Click(object sender, EventArgs e)
    {
        if (checkbox1.Checked)
        {
            labelCheckMessage.Text = "The Check box was ticked";
            labelCheckMessage.BackColor = System.Drawing.Color.Aqua;
        }
        else
        {
            labelCheckMessage.Text = "The Check box was Un-ticked";
            labelCheckMessage.BackColor = System.Drawing.Color.Red;

        }
    }



    protected void buttonRadio1_Click(object sender, EventArgs e)
    {
             

        if (radio1.Checked)
        {
            labelRadioMessage.Text = "Radio button was selected";
            labelRadioMessage.BackColor = System.Drawing.Color.Aqua;
           
        }
       
    }

    protected void buttonRadioList_Click(object sender, EventArgs e)
    {
        int _index = radiobuttonlist.SelectedIndex;
        labelRadioList.Text = _index.ToString() + " was selected";
        labelRadioMessage.BackColor = System.Drawing.Color.Aqua;
    }
}