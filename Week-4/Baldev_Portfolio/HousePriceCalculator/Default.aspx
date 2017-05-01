<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HousePriceCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>House Price Calculator</title>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
    <!-- jQuery library -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.0/jquery.min.js"></script>
    <!-- Latest compiled JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

    <%--<%--my javascrip--%>
    <%--<script src="Scripts/hpi.js"></script>--%>
    <%--custom stylesheet--%>
    <link href="css/hpc.css" rel="stylesheet" />

</head>
<body style="background-image: url('http://localhost:49871/img/reichstag-1615165_1920.jpg');">
    <form id="form1" runat="server">
      <asp:ScriptManager ID="asm" runat="server" />
        <%--bootstrap container--%>
        <div class="container" >
            <%--Header section--%>
            <div class="jumbotron">
                <h2 class="well">House Price Calculator</h2>
                <p>Find the current estimate of house price in your local area.</p>
            </div>
            <%--main content section--%>
            <section>
                <%--content header section--%>
                <article>
                    <div class="row" style="height: 60px; height: 100px; font-size: 18px; font-family: Arial, Helvetica, sans-serif; ">

                    <div class="col-md-3">
                        <asp:Label ID="Label_area" runat="server" Text="Select Area" ForeColor="White" ></asp:Label>
                        <asp:DropDownList ID="DropDownList_area" runat="server"></asp:DropDownList>
                    </div>
                    <div class="col-md-3">
                        <asp:Label ID="Label_year" runat="server" Text="Select Purchase year" ForeColor="White"></asp:Label>
                        <asp:DropDownList ID="DropDownList_year" runat="server"></asp:DropDownList>
                    </div>
                     <div class="col-md-6">
                    </div>

                    </div>
                </article>
                <%--selection content section--%>
               
                <div class="row" style="height: 300px">
                    <div class="col-md-6">
                            
                            <%--house price selection--%>
                            <div class="row" style="height: 100px; font-size: 18px; font-family: Arial, Helvetica, sans-serif; ">
                                 
                                <div class="col-md-3"> <asp:Label ID="Label1" runat="server" Text=" Select Price" ForeColor="White"></asp:Label>
                                </div>
                                <div class="col-md-4"><ajaxtoolkit:sliderextender ID="se1" runat="server" TargetControlId="Slider1" BoundControlID="SliderValue"  Minimum="0" Maximum="2000000" Length="200" />
                                    
                                    <asp:TextBox ID="Slider1" runat="server" AutoPostBack="true" BorderColor="#666699" Height="20px"  Wrap="False" /></div>
                                <div class="col-md-5">
                                    
                                    <asp:TextBox ID="SliderValue" runat="server" AutoPostBack="true" Width="70px" BorderStyle="None" Wrap="False" /> 
                                    
                                    <asp:Label ID="LastUpdate" runat="server" ForeColor="White"   Font-Size="8" />  </div>
                                                    
                            </div>
                                          
                                
                        

                            <%--valuation 2017 and 2016 section--%>
                             <div class =" row" style="height: 70px">
                                 <div class="col-md-6">
                                     <asp:Button ID="Button_valuation2017" runat="server" Text="Valuation 2017" Enabled="false" />
                                 </div>
                                   
                                 <div class="col-md-6">
                                     <asp:Label ID="Label_valuation2017" runat="server" Text="Label" ForeColor="White">
                                         </asp:Label>
                                 </div>
                             </div>

                             <div class =" row" style="height: 70px">
                                 <div class="col-md-6"> <asp:Button ID="Button_valuation2016" runat="server" Text="Valuation 2016" Enabled="false" /></div>
                                   <div class="col-md-6"> <asp:Label ID="Label_valuation2016" runat="server" Text="Label" ForeColor="White"></asp:Label></div>
                             </div>
                   </div>
              
                <%--Chart section--%>
                <div class="col-md-6">
                       <%--asp.net chart application--%>
                       <%-- <asp:Chart ID="Chart1" runat="server" DataSourceID="ObjectDataSource1">
                            <Series>
                                <asp:Series ChartType="Line" Name="Series1">
                                </asp:Series>
                            </Series>
                            <ChartAreas>
                                <asp:ChartArea Name="ChartArea1">
                                </asp:ChartArea>
                            </ChartAreas>
                        </asp:Chart>--%>
                       
                          <div id="chartContainer" style="height: 300px; width: 100%;"></div>
                  
                    
               </div>
          </div>
                <%--bottom content section--%>
                <div class="row" style="height: 100px">
                    <div class="col-md-6" role="button">
                        <asp:Button ID="Button_checkhouseprice" runat="server" Text="Check House Price" BackColor="#CCFF33" BorderColor="#FF9900" BorderStyle="Ridge" BorderWidth="2px" Enabled="True" Font-Bold="True" Font-Size="Larger" Height="40px" Width="200px" />
                    </div>
                    <div class="col-md-6" style="color: #CCFF33; font-size: 20px; font-family: 'Century Gothic'; font-weight: bolder;">
                        <p>Developed by: Baldev Patel</p>
                        <p>Resource: Land Registry Data</p>
                    </div>
                 </div>
           </section>
        </div>
        <%--example of JSONData--%>
        <div class="JSONdata">
            
        </div>
       
        <script>



            $(document).ready(function () {
                $("#Button_checkhouseprice").click(function () {
                    $.getJSON("/Data/Test.json", function (data) {
                        console.log("success");
                    });

                });
            });


            //        $.ajax({
            //            type: "GET",
            //            url: "/Data/Test.json",
            //            //beforeSend: function () {

            //            //    $.blockUI({
            //            //        fadeIn: 0,
            //            //        fadeOut: 0,
            //            //        showOverlay: false

            //            //    });
            //            //},
            //            datatype: JSON,

            //            done: function (data) {
            //                console.log(data);
            //                $("#JSONdata").html(data);
            //            },
            //           fail: function (XMLHttpRequest, textStatus, errorThrown) {
            //                alert("Request: " + XMLHttpRequest.toString() + "\n\nStatus: " + textStatus + "\n\nError: " + errorThrown);
            //            },
            //            //complete: function () {
            //            //    $.unblockUI();
            //        });
            //    });
            //});
       

        </script>
        <%--script for chart in CanvasJS--%>
        <script type="text/javascript">
            window.onload = function () {
            var chart = new CanvasJS.Chart("chartContainer",
            {
      
                axisX: {
                            valueFormatString: "MM-YYYY",
                            interval:1,
                            intervalType: "year"
                        },
                axisY:  {
                            includeZero: false

                        },
                data:[  {
                            type: "line",

                            dataPoints: [
                                        { x: new Date(2012, 00, 1), y: 450 },
                                        { x: new Date(2012, 01, 1), y: 414},
                                        { x: new Date(2012, 02, 1), y: 520, indexLabel:                                 "highest",markerColor: "red", markerType: "triangle"},
                                        { x: new Date(2012, 03, 1), y: 460 },
                                        { x: new Date(2012, 04, 1), y: 450 },
                                        { x: new Date(2012, 05, 1), y: 500 },
                                        { x: new Date(2012, 06, 1), y: 480 },
                                        { x: new Date(2012, 07, 1), y: 480 },
                                        { x: new Date(2012, 08, 1), y: 410 , indexLabel: "lowest",markerColor: "DarkSlateGrey", markerType: "cross"},
                                        { x: new Date(2012, 09, 1), y: 500 },
                                        { x: new Date(2012, 10, 1), y: 480 },
                                        { x: new Date(2012, 11, 1), y: 510 }
                                        ]
                        }
                    ]
                });

            chart.render();
            }



  </script>
    <script type="text/javascript" src="/canvasJS/canvasjs.min.js"></script>
        <script src="Scripts/jquery-1.10.2.min.js"></script>
        <script src="Scripts/jquery-1.10.2.js"></script>
        <script src="Scripts/modernizr-2.6.2.js"></script>
        <script src="Scripts/bootstrap.min.js"></script>
        <script src="Scripts/bootstrap.js"></script>
         
    </form>
 
</body>
</html>
