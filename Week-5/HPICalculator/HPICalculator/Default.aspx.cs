using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace HPICalculator
{
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
            }

        }

        protected void Button_checkhouseprice_Click(object sender, EventArgs e)
        {
            string queryArea = DropDownList_area.SelectedItem.Text.ToString();
            string queryYear = DropDownList_year.SelectedItem.Text.ToString();


            string cmdText = "select [Period], [PercentageAnnualChange] from [Harrow$] where [Name]='" + queryArea + "'" + " AND [Period]>='" + queryYear + "'";
            estimateValue(cmdText);

            //switch (queryArea)
            //{
            //    case "Harrow":
            //        cmdText = "select PercentageAnnualChange from [Harrow$] where ([Period] >= '" + queryYear + "')";
            //        estimateValue(cmdText);
            //        break;

            //    case "City of London":
            //        cmdText = "select PercentageAnnualChange from [London$] where ([Period] >= '" + queryYear + "')";
            //        estimateValue(cmdText);
            //    break;

            //    case "Brent":
            //        cmdText = "select PercentageAnnualChange from [Brent$] where ([Period] >= '" + queryYear + "')";
            //        estimateValue(cmdText);
            //    break;

            //    case "Ealing":
            //        cmdText = "select PercentageAnnualChange from [Ealing$] where ([Period] >= '" + queryYear + "')";
            //        estimateValue(cmdText);
            //    break;

            //    case "Kensington and Chealsea":
            //        cmdText = "select PercentageAnnualChange from [Kensington$] where ([Period] >= '" + queryYear + "')";
            //        estimateValue(cmdText);
            //    break;
            //}
            //DataSet ds = new DataSet();
            //OleDbDataAdapter oledbAdp = new OleDbDataAdapter(command);
            //oledbAdp.Fill(ds);
            //GridView1.DataSource = ds.Tables[0];


        }

        private void estimateValue(string cmdText)
        {
            double purchaseprice;
            double[] percentage;
            double[] estimateValue;
            decimal[] yearList;
            int rowCount;

            purchaseprice = double.Parse(SliderValue.Text);


            string path = Server.MapPath("~/App_Data/HPI_data.xlsx");

            //string connectionStr = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "; Extended Properties=\"Excel 12.0 Xml; HDR=YES;IMEX = 1; ImportMixedTypes=Text;\";";
            string connectionStr = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "; Extended Properties=\"Excel 12.0 Xml; HDR=YES;IMEX = 1; ImportMixedTypes=Text;\";";
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
                    estimateValue = new double[rowCount];
                    //double sum=0;
                    double estimateValueYearly = purchaseprice;
                    int i;
                    for (i = 0; i < rowCount; i++)
                    {


                        //yearList[i] = year;
                        //year++;



                        //for (int j = 0; j < table.Rows[i].ItemArray.Length; j++)
                        //{
                        //    sum+= double.Parse(table.Rows[i].ItemArray[j].ToString());
                        //    //adding into array for use of graph
                        //    percentage[i] = double.Parse(table.Rows[i].ItemArray[j].ToString());
                        //    //adding into array for use of graph
                        //    estimateValueYearly = (estimateValueYearly + (estimateValueYearly * percentage[i]) / 100);
                        //    estimateValue[i] = Math.Round(estimateValueYearly);
                        //    excelLabel.Text += "<br>" + estimateValue[i] + "--"+ percentage[i] +"--"+yearList[i];
                        //    excelLabel.ForeColor = System.Drawing.Color.White;
                        //    Label_valuation2017.Text = sum.ToString();
                        //    //current valuation
                        //    Label_valuation2016.Text = estimateValue[i].ToString();

                        //----------------||New code for alternate solution||------------------
                        //sum += double.Parse(table.Rows[i].ItemArray[0].ToString());
                        yearList[i] = decimal.Parse(table.Rows[i].ItemArray[0].ToString());

                        percentage[i] = double.Parse(table.Rows[i].ItemArray[1].ToString());
                        estimateValueYearly = (estimateValueYearly + (estimateValueYearly * percentage[i]) / 100);
                        estimateValue[i] = Math.Round(estimateValueYearly);
                        //excelLabel.Text += "<br>" + estimateValue[i] + "--" + percentage[i] + "--" + yearList[i];
                        //excelLabel.ForeColor = System.Drawing.Color.White;
                        //Label_valuation2017.Text = sum.ToString();
                        //current valuation
                        valuation2017.Text = estimateValue[i].ToString();
                        
                    }
                    
                    valuation2016.Text = estimateValue[i - 2].ToString();

                }



            }
            for (int i = 0; i < rowCount; i++)
            {
                Chart1.Series["Series1"].Points.AddXY(yearList[i], estimateValue[i]);

            }


        }
    }
}