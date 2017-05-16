using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace HPICalculator
{
    //public class HPIdata
    //{
    //    public string area { get; set; }
    //    public decimal purchaseprice { get; set; }
    //    public decimal percentage { get; set; }
    //    public decimal valuation2016 { get; set; }
    //    public decimal valuation2017 { get; set; }

    //    public decimal year { get; set; }

    //}

    public partial class Default : System.Web.UI.Page
    {
        private void BindXml()
        {
            string filePath = Server.MapPath("~/App_Data/Arealist.xml");
            using (DataSet ds = new DataSet())
            {
                ds.ReadXml(filePath);
                DropDownList_area.DataSource = ds;
                DropDownList_area.DataTextField = "name";
                DropDownList_area.DataValueField = "id";
                DropDownList_area.DataBind();
            }
            string filePath1 = Server.MapPath("~/App_Data/Yearlist.xml");
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
                //LastUpdate.Text = "(max. £2000000)";

                //initialise the set purchase value of property in local area.
                //string InitialPurchase = "250000";
                SliderValue.Text = "250000";


                string queryArea = DropDownList_area.SelectedItem.Text;
                string queryYear = DropDownList_year.SelectedItem.Text;

                //data query to retrieve data 
                string cmdText = "select [Period], [PercentageAnnualChange] from [Harrow$] where [Name]='" + queryArea +
                                 "'" + " AND [Period]>='" + queryYear + "'";
                estimateValue(cmdText);
            }

        }

        //invocked when you click to calculate btn
        protected void Button_checkhouseprice_Click(object sender, EventArgs e)
        {
            string queryArea = DropDownList_area.SelectedItem.Text;
            string queryYear = DropDownList_year.SelectedItem.Text;

            //data query to retrieve data 
            string cmdText = "select [Period], [PercentageAnnualChange] from [Harrow$] where [Name]='" + queryArea +
                             "'" + " AND [Period]>='" + queryYear + "'";
            estimateValue(cmdText);

        }

        //method to get current valuation and display on asp.net chart control
        private void estimateValue(string cmdText)
        {
            double purchaseprice;
            double[] percentage;
            double[] estimateValue1;
            decimal[] yearList;
            int rowCount;

            purchaseprice = Convert.ToDouble(SliderValue.Text);

            string path = Server.MapPath("~/App_Data/HPI_data.xlsx");

            //string connectionStr = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "; Extended Properties=\"Excel 12.0 Xml; HDR=YES;IMEX = 1; ImportMixedTypes=Text;\";";
            string connectionStr = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + path +
                                   "; Extended Properties=\"Excel 12.0 Xml; HDR=YES;IMEX = 1; ImportMixedTypes=Text;\";";
            Console.WriteLine(connectionStr);


            using (var connection = new OleDbConnection(connectionStr))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                //retrieve data since purchase date
                command.CommandText = cmdText;
                //  command.CommandText = "select PercentageAnnualChange from [Sheet1$] where ([Name] = '" + queryArea + "') && ([Period] >= '" + queryYear+"')";
                var table = new DataTable();
                using (var reader = command.ExecuteReader())
                {
                    table.Load(reader);
                    //calculate total percentage change since purchase date

                    rowCount = table.Rows.Count;
                    //decimal year = Convert.ToDecimal(DropDownList_year.Text.ToString());
                    yearList = new decimal[rowCount];
                    percentage = new double[rowCount];
                    estimateValue1 = new double[rowCount];
                    //double sum=0;
                    double estimateValueYearly = purchaseprice;
                    int i;
                    for (i = 0; i < rowCount; i++)
                    {

                        yearList[i] = decimal.Parse(table.Rows[i].ItemArray[0].ToString());

                        percentage[i] = double.Parse(table.Rows[i].ItemArray[1].ToString());
                        estimateValueYearly = (estimateValueYearly + (estimateValueYearly * percentage[i]) / 100);
                        estimateValue1[i] = Math.Round(estimateValueYearly);
                        //-----------testing code---------//
                        //excelLabel.Text += "<br>" + estimateValue[i] + "--" + percentage[i] + "--" + yearList[i];
                        //excelLabel.ForeColor = System.Drawing.Color.White;
                        //Label_valuation2017.Text = sum.ToString();

                        //current valuation
                        valuation2017.Text = "£" + estimateValue1[i];

                    }
                    //previous year valuation
                    valuation2016.Text = "£" + estimateValue1[i - 2];


                }

            }

            for (int i = 0; i < rowCount; i++)
            {
                Chart1.Series["Series1"].Points.AddXY(yearList[i], estimateValue1[i]);

            }
            
            ClientScript.RegisterStartupScript(GetType(), "drawChart",
                "drawChart('" + rowCount + "','" + yearList + "', '" + estimateValue1 + "');", true);

        }
        
        //[WebMethod]
        //private object GetChartData()
        //{
        //    List<HPIdata> hpiList = new List<HPIdata>();

        //    string queryArea = DropDownList_area.SelectedItem.Text.ToString();
        //    string queryYear = DropDownList_year.SelectedItem.Text.ToString();

        //    //data query to retrieve data 
        //    string cmdText = "select [Period], [PercentageAnnualChange] from [Harrow$] where [Name]='" + queryArea + "'" + " AND [Period]>='" + queryYear + "'";
        //    decimal purchaseprice;
        //    decimal[] percentage;
        //    // decimal[] estimateValue;
        //    // decimal[] yearList;
        //    int rowCount;

        //    purchaseprice = Convert.ToDecimal(SliderValue.Text);

        //    string path = Server.MapPath("~/App_Data/HPI_data.xlsx");

        //    //string connectionStr = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "; Extended Properties=\"Excel 12.0 Xml; HDR=YES;IMEX = 1; ImportMixedTypes=Text;\";";
        //    string connectionStr = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "; Extended Properties=\"Excel 12.0 Xml; HDR=YES;IMEX = 1; ImportMixedTypes=Text;\";";
        //    Console.WriteLine(connectionStr);


        //    using (var connection = new OleDbConnection(connectionStr))
        //    using (var command = connection.CreateCommand())
        //    {
        //        connection.Open();
        //        //retrieve data since purchase date
        //        command.CommandText = cmdText;
        //        //  command.CommandText = "select PercentageAnnualChange from [Sheet1$] where ([Name] = '" + queryArea + "') && ([Period] >= '" + queryYear+"')";
        //        var table = new DataTable();
        //        using (var reader = command.ExecuteReader())
        //        {
        //            table.Load(reader);
        //            //calculate total percentage change since purchase date

        //            rowCount = table.Rows.Count;
        //            //decimal year = Convert.ToDecimal(DropDownList_year.Text.ToString());
        //            // yearList = new decimal[rowCount];
        //            percentage = new decimal[rowCount];
        //            //  estimateValue = new decimal[rowCount];
        //            //double sum=0;
        //            decimal estimateValueYearly = purchaseprice;
        //            int i;
        //            for (i = 0; i < rowCount; i++)
        //            {
        //                HPIdata hpi = new HPIdata();

        //                hpi.year = decimal.Parse(table.Rows[i].ItemArray[0].ToString());
        //                //yearList[i] = decimal.Parse(table.Rows[i].ItemArray[0].ToString());
        //                hpi.percentage = decimal.Parse(table.Rows[i].ItemArray[1].ToString());
        //                //percentage[i] = double.Parse(table.Rows[i].ItemArray[1].ToString());
        //                hpi.valuation2017 = Math.Round((estimateValueYearly + (estimateValueYearly * percentage[i]) / 100));
        //                //estimateValueYearly = (estimateValueYearly + (estimateValueYearly * percentage[i]) / 100);
        //                //estimateValue[i] = Math.Round(estimateValueYearly);
        //                //-----------testing code---------//
        //                //excelLabel.Text += "<br>" + estimateValue[i] + "--" + percentage[i] + "--" + yearList[i];
        //                //excelLabel.ForeColor = System.Drawing.Color.White;
        //                //Label_valuation2017.Text = sum.ToString();

        //                hpiList.Add(hpi);
        //            }

        //        }

        //        }

        //        return hpiList;
        //    }
        //}
    }
}