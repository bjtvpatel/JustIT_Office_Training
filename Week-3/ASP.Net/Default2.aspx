<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

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
    <div>
        <div class="rightSide">
                    
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
    
    </div>
    </form>
</body>
</html>
