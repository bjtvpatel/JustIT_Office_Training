<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HPICalculator.Default" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<%@ Register assembly="System.Web.DataVisualization, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

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

        
    <%--custom stylesheet--%>
    <link href="App_CSS/hpi.css" rel="stylesheet" />

</head>
<%--    <body style="background-color:#2C3E50">--%>
<body style="background-image: url('http://localhost:65244/App_Image/reichstag.jpg')">
    <form id="form1" runat="server">
      <asp:ScriptManager ID="asm" runat="server" />
        <%--bootstrap container--%>
        <div class="container" >
            <%--Header section--%>
            <div class="jumbotron jumbotron-header">
                <h1 class="well well-header">House Price Calculator</h1>
                <h2>Find the current estimate of house price in your local area.</h2>
            </div>
            <%--main content section--%>
            <section class="selection-container">
                <%--content header section--%>
                <article>
                    <%--house price selection--%>
                   
                            <div class="row jumbotron-selection"">
                                <div class="col-md-8 col-sm-12 well-internal selection" style="padding-left:1px; padding-right:2px">
                                    <div class="row well well-selection">
                                            
                                        <%--<p>Property Price</p>  --%>  
                                       
                                       <div class="col-md-10 col-sm-12 handleRail ">

                                           <div  class="row propertyprice">
                                               <div class="col-md-12 col-sm-12 selection-text"><asp:Label ID="Label1" runat="server" Text="Property Price" ForeColor="White"></asp:Label></div></div> 
                                         <div class="row slider-row">
                                        
                                             <div class="col-md-1 col-sm-1 triagle" ><i class="glyphicon glyphicon-triangle-left "></i></div>
                                             <div class="col-md-10 col-sm-10 slide-input" > 
                                                 <ajaxToolkit:SliderExtender ID="se1" runat="server" HandleCssClass="sliderhandle"  HandleImageUrl="~/App_Image/marker.png" RailCssClass="sliderrail" EnableHandleAnimation="true" TargetControlID="Slider1" BoundControlID="SliderValue" Minimum="0" Maximum="1000000" />
                                                 <asp:TextBox ID="Slider1" runat="server" AutoPostBack="false" CssClass="slide-input" Enabled="true" /></div>
                                             <div class="col-md-1 col-sm-1 triagle"> <i class="glyphicon glyphicon-triangle-right"></i></div>
                                         </div>
                                            
                                           
                                           

                                     </div>
                                        <%-- <i class="glyphicon glyphicon-gbp"></i>--%>
                                        <div class="col-md-2 col-sm-12 priceLabel">
                                            <asp:Textbox ID="SliderValue"  AutoPostBack="false" CssClass="btn btn-info priceText" width="110px" runat="server" /> 
                                         
                                             </div><div  class="maxPrice"><p >(max. £1000000)</p></div>
                                        <%--<asp:Label ID="LastUpdate"  runat="server" ForeColor="White"   Font-Size="8" />--%>
                                   </div>

                                      <%--Location and Purchase Year selection--%>
                                     <div class="row well well-selection">
                                        <div class="col-md-6 col-sm-12 selection-text">
                                            <asp:Label ID="Label_area" runat="server" Text="Local Area" ForeColor="White" ></asp:Label>
                                            <asp:DropDownList ID="DropDownList_area" CssClass="form-control select-area" runat="server" ></asp:DropDownList>

                                            <%--<asp:DropDownList ID="DropDownList1" CssClass="btn btn-default btn-sm" runat="server" ></asp:DropDownList>--%>
                                         </div>
                                        <div class="col-md-6 col-sm-12 selection-text">
                                            <asp:Label ID="Label_year" runat="server" Text="Purchase year" ForeColor="White"></asp:Label>
                                             <asp:DropDownList ID="DropDownList_year" CssClass="form-control select-year" runat="server"></asp:DropDownList>
                                        </div>
                                        </div>
                               </div>
                                    
                                    
                                        
                            <%--valuation 2017 and 2016 section--%>
                                <div class="col-md-4 col-sm-12 well-internal valuation" style="padding-left:1px; padding-right:2px">
                                             <div class =" row well well-selection row-valuation">
                                                <div class="col-md-6 col-sm-12 selection-text nopadding label-valution ">
                                                   <asp:Label ID="Label_valuation2017" runat="server" CssClass="label-valution-in" Text="Valuation 2017" ForeColor="White">
                                                    </asp:Label>
                                                     
                                                 </div>
                                   
                                                <div class="col-md-6 col-sm-12 selection-text btnvaluation">
                                                     <asp:TextBox ID="valuation2017" runat="server" CssClass="btn form-control-updated btnvaluation-in btn-info"></asp:TextBox>
                                                    <%-- <asp:TextBox ID="Button_valuation2017" runat="server" CssClass="btn form-control-updated btnvaluation-in btn-info" />--%>
                                                    
                                                </div>
                                            </div>
                                            <div class =" row well well-selection row-valuation">
                                                <div class="col-md-6 col-sm-12 selection-text nopadding label-valution"> 
                                                    
                                                    <asp:Label ID="Label_valuation2016"  CssClass="label-valution-in" runat="server" Text="Valuation 2016" ForeColor="White"></asp:Label>
                                                </div>
                                                <div class="col-md-6 col-sm-12 selection-text btnvaluation" > 
                                                  <asp:Textbox ID="valuation2016" CssClass="btn form-control-updated btnvaluation-in btn-info" runat="server"  />

                                                </div>
                                             </div>
                                             
                            <%-------------------||Calculate Button||---------------------------%>
                                     <div class="row well well-selection row-calculate">
                                         <div class="col-md-12 col-sm-12 btncalculate" role="button">
                                         <asp:Button ID="Button_checkhouseprice" runat="server"   CssClass="btn btn-primary btncalculate-in" Text="CALCULATE" Enabled="True" OnClick="Button_checkhouseprice_Click" />
                                     </div>
                                    </div>
                                  </div>
                               </div> 
                </article>

                <%------------------------||Chart section||-------------%>
                <div class="row">
                <div class="col-md-12 col-sm-12">

                       <%--asp.net chart application--%>
                                    
                          <div id="chartContainer">
                              <asp:Chart ID="Chart1"   runat="server"  AntiAliasing="all"  BackGradientStyle="TopBottom" BackImageTransparentColor="91, 192, 222" BackSecondaryColor="192, 192, 255" BorderlineColor="Transparent" BorderlineWidth="0" Palette="Berry" TextAntiAliasingQuality="SystemDefault" Width="1100px">
                                  <Titles>
                                      <asp:Title Text="House Price Growth"  Alignment="TopCenter">
                                          
                                      </asp:Title>
                                  </Titles>
                                  <Series>
                                      <asp:Series Name="Series1" ChartType="Line"  Legend="legend1">
                                      </asp:Series>
                                  </Series>
                                  <ChartAreas>
                                      <asp:ChartArea  Name="ChartArea1" >
                                          <AxisX  Title="Year" TitleForeColor="Black" >
                                              <LabelStyle Font="Trebuchet MS, 20pt" />
                                              <MajorGrid LineColor="64, 64, 64, 64" />
                                          </AxisX>
                                          <AxisY Title="House Price" TitleForeColor="Black">
                                              <LabelStyle Font="Trebuchet MS, 20pt" />
                                              <MajorGrid  LineColor="64, 64, 64, 64" />
                                              
                                          </AxisY>
                                      </asp:ChartArea>
                                  </ChartAreas>
                                  <BorderSkin BackColor="Transparent" BorderColor="Transparent" BorderDashStyle="DashDotDot" />
                              </asp:Chart>   
                          </div>
                        </div>
                    </div>
                <div class="row well well-header"> <div class="col-md-12 col-sm-12" style="color:#fff; font-size: 14px; font-family: 'Century Gothic'; font-weight: bolder; text-align:center">
                        <p>Developed by: Baldev Patel</p>
                        <p>Resource: Land Registry Data</p>
                    </div></div>
           </section>
            
        
        </div>
        <%---------------------||example of JSONData||--------------------------%>
        <div id="divChart" class="JSONdata">
            <%--<asp:Label ID="excelLabel" Text="JSON_Data_Chart" runat="server"></asp:Label>--%>
        </div>

       
        <%---------------------------||script links||--------------------%>
        
       
        <script src="Scripts/bootstrap.min.js"></script>
        <script src="Scripts/bootstrap.js"></script>
        <script src="Scripts/jquery-1.9.1.js"></script>
        <script src="Scripts/jquery-1.9.1.min.js"></script>
        <script type="text/javascript" src="/canvasJS/canvasjs.min.js"></script>
        <script src="App_Script/hpi.js"></script>
         
    </form>
 
</body>
</html>
