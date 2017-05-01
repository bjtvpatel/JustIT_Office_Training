using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HousePriceCalculator
{


    public partial class Default : System.Web.UI.Page
    {
        private void BindXml()
        {
            string filePath = Server.MapPath("~/Data/Arealist.xml");
            using (DataSet ds = new DataSet())
            {
                ds.ReadXml(filePath);
                DropDownList_area.DataSource = ds;
                DropDownList_area.DataTextField = "name";
                DropDownList_area.DataValueField = "id";
                DropDownList_area.DataBind();
            }

            string filePath1 = Server.MapPath("~/Data/Yearlist.xml");
            using (DataSet ds = new DataSet())
            {
                ds.ReadXml(filePath1);
                DropDownList_year.DataSource = ds;
                DropDownList_year.DataTextField = "name";
                DropDownList_year.DataValueField = "id";
                DropDownList_year.DataBind();
            }




        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.BindXml();
                LastUpdate.Text = "(max. £2000000)";
            }

        }


    }
}