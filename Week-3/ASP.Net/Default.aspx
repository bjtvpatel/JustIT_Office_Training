<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 141px;
        }
        .auto-style4 {
            width: 141px;
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style6 {
            width: 120px;
        }
        .auto-style7 {
            width: 120px;
            height: 23px;
        }
    </style>
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div>
    <h1>My first ASP Page</h1>
        <asp:Label ID="Label1" runat="server" ></asp:Label>
    </div>
        <div>
            <h2> Enter your detail</h2>
            <asp:Label ID="labelName" runat="server">Your name:</asp:Label><input type="text" runat="server" id="inputName"/><asp:Button ID="buttonClick" Text="Click me!" OnClick="buttonClick_Click" runat="server" />
            <br />
            <br />
        <div>
            <asp:Label ID="lableDisplayname" runat="server"></asp:Label>                
            </div>
            <br />
            <br />

             <div>
                    
                    <table class="auto-style1">
                        <tr>
                            <td colspan="3"><h3>Please get in touch using this form</h3></td>
                        </tr>
                        <tr>
                            <td class="auto-style3">Name</td>
                            <td class="auto-style6">
                                <asp:TextBox ID="Name" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Name" CssClass="ErrorMessage" ErrorMessage="Please enter your name">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">Email</td>
                            <td class="auto-style7">
                                <asp:TextBox ID="Email" runat="server"></asp:TextBox>
                            </td>
                            <td class="auto-style5"></td>
                        </tr>
                        <tr>
                            <td class="auto-style3">&nbsp;</td>
                            <td class="auto-style6">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style3">&nbsp;</td>
                            <td class="auto-style6">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style3">&nbsp;</td>
                            <td class="auto-style6">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style3">&nbsp;</td>
                            <td class="auto-style6">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style3">&nbsp;</td>
                            <td class="auto-style6">
                                <asp:Button ID="SendButton" runat="server" Text="Send Button" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                    
                </div>

             <asp:Panel ID="Panel1" runat="server">
                        <p>You can put anything you like into a panel control - text, images, ASP.NET commands, etc.</p>

                  <asp:Wizard ID="Wizard1" runat="server" Width="456px" ActiveStepIndex="0" >
                            <WizardSteps>
                                <asp:WizardStep runat="server" title="About You">
                                    <asp:Label ID="Label2" runat="server" Text="Type your name:"></asp:Label>
                                    <asp:TextBox ID="YourName" runat="server"></asp:TextBox>
                                </asp:WizardStep>
                                <asp:WizardStep runat="server" title="Favourite Sport" StepType="Finish">
                                    <asp:DropDownList ID="FavouriteSport" runat="server">
                                        <asp:ListItem>Football</asp:ListItem>
                                        <asp:ListItem>Tennis</asp:ListItem>
                                        <asp:ListItem>Cricket</asp:ListItem>
                                        <asp:ListItem>Chilling Out</asp:ListItem>
                                    </asp:DropDownList>
                                </asp:WizardStep>
                                <asp:WizardStep runat="server" StepType="Complete" Title="Ready">
                                    <asp:Label ID="Result" Text="text" runat="server" />
                                </asp:WizardStep>
                            </WizardSteps>
                        </asp:Wizard>

                                      </asp:Panel>

            <asp:DropDownList ID="ddl" runat="server" AutoPostBack="false">
                <asp:ListItem Value="Baldev" Selected="True"></asp:ListItem>

                 <asp:ListItem Value="Patel" Enabled="true"></asp:ListItem>
                 <asp:ListItem Value="Suprian" Enabled="true"></asp:ListItem>

            </asp:DropDownList>
            
             <asp:BulletedList ID="BulletedListMarilynMovies" runat="server" BulletImageUrl="~/marilynTiny.jpg" BulletStyle="CustomImage">
                    <asp:ListItem Value="SomeLike">Some Like it Hot</asp:ListItem>
                    <asp:ListItem Value="Gentlemen">Gentlemen Prefer Blondes</asp:ListItem>
                    <asp:ListItem Value="Niagara">Niagara</asp:ListItem>
                  </asp:BulletedList>
             <asp:ListBox ID="ChelseaManagerListBox" runat="server" AutoPostBack="false" SelectionMode="Multiple">
                    <asp:ListItem>Pep Guardiola</asp:ListItem>
                    <asp:ListItem>Diego Simeone</asp:ListItem>
                    <asp:ListItem>Antonio Conte</asp:ListItem>
                    <asp:ListItem>John Terry</asp:ListItem>
                </asp:ListBox>

            <div>
                                <asp:Label ID="label" runat="server">Please check or uncheck the box</asp:Label><br />
                <br />

                <asp:CheckBox ID="checkbox1" runat="server" />
                <br />
                <br />
                <asp:Button ID="buttonCheckbox1" runat="server" OnClick="buttonCheckbox1_Click"  Text="Check box button"/>
                <br />
                 <asp:Label ID="labelCheckMessage" runat="server"></asp:Label><br />
                <br />
                <asp:Label ID="label3" runat="server">Please click radio button</asp:Label><br /><br />
                <br />
                <asp:RadioButton ID="radio1" runat="server" />
                <br /><br />
                <asp:Button ID="buttonRadio1" OnClick="buttonRadio1_Click" runat="server"  Text="Radio button"/>
                
                <asp:HyperLink id="hyperlink1" runat="server"  NavigateUrl="http://www.google.co.uk"  Target="_parent"> <asp:Label ID="labelRadioMessage" runat="server"></asp:Label></asp:HyperLink><br /><br />

                <asp:UpdatePanel ID="Updatepanel1" runat="server"><ContentTemplate>
                <asp:RadioButtonList ID="radiobuttonlist" Visible="true"  RepeatDirection="Vertical" RepeatLayout="Flow" TabIndex="3" AutoPostBack="true" runat="server">
                 
                 <asp:ListItem Value="At Work">At Work</asp:ListItem>
                <asp:ListItem Value="At Home">At Home</asp:ListItem></asp:RadioButtonList></ContentTemplate></asp:UpdatePanel>
                <br />
                 <asp:Button ID="buttonRadioList" OnClick="buttonRadioList_Click" runat="server"  Text="Radio button"/>
              
                <br /><br />
                <asp:Label ID="labelRadioList"  runat="server"></asp:Label><br /><br />
                
               <%-- <asp:ImageButton ID="imageBtn1" runat="server"  AlternateText="My image" ImageUrl="https://www.w3schools.com/html/pic_mountain.jpg" PostBackUrl="http://www.yahoo.com" />
               --%> <br />

                <asp:ImageMap ID="imagemapID1" runat="server"  ImageUrl="https://www.w3schools.com/html/pic_mountain.jpg" >
                   <%-- <asp:CircleHotSpot X="145" Y="100" Radius="55"  HotSpotMode="PostBack" PostBackValue="stone" />--%>
                    <asp:PolygonHotSpot Coordinates="80,10,110,10,110,30,80,30,80,10" 
                        HotSpotMode="PostBack" PostBackValue="Moon" />
                                    </asp:ImageMap>
                <br />

                <asp:TextBox ID="textbox1" runat="server" TextMode="MultiLine"  CausesValidation="true"></asp:TextBox>
                <br />

                <asp:Calendar ID="calender1" runat="server"  Visible="true" ShowGridLines="true" ></asp:Calendar>
            <br />



    <asp:linkbutton id="LinkButton1" 
      text="Post back to this page"
      runat="Server">
    </asp:linkbutton>

    <br /><br />

    <asp:linkbutton id="LinkButton2"
      text="Post value to another page" 
      postbackurl="http://www.google.com"
      runat="Server">
    </asp:linkbutton>


               


 
            </div>

        </div>
    </form>
</body>
</html>
