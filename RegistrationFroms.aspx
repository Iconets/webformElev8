<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationFroms.aspx.cs" Inherits="webformElev8.RegistrationFroms" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 30px;
        }
        .auto-style2 {
            width: 100%;
            margin-bottom: 24px;
        }
        .auto-style3 {
            height: 21px;
        }
        .auto-style4 {
            margin-left: 2px;
            margin-right: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style2">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Surname"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtSurname" runat="server" Width="318px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label2" runat="server" Text="OtherNames"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtOtherNames" runat="server" Width="318px"></asp:TextBox>
                    </td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="ddpGender" runat="server" >
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="MobileNo"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtMobileNo" runat="server" Width="318px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Email Address"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtemail" runat="server" Width="318px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Address"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAddress" runat="server" Width="318px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Date Employed"></asp:Label>
                    </td>
                    <td>
                        <asp:Calendar ID="dtEmployed" runat="server"></asp:Calendar>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label8" runat="server" Text="Date of birth"></asp:Label>
                    </td>
                    <td>
                        <asp:Calendar ID="dtBirth" runat="server"></asp:Calendar>
                        <asp:Button ID="bttnsave" runat="server" Font-Bold="True" Font-Size="15pt" OnClick="Button1_Click" Text="Save Details" Width="261px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="lblDisplay" runat="server" Text="lblDisplay" Font-Bold="True" Font-Size="15pt" ForeColor="Lime"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="bttnread" runat="server" Font-Bold="True" Font-Size="15pt" OnClick="Button1_Click" Text="Read Details" Width="261px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="bttnupdate" runat="server" Font-Bold="True" Font-Size="15pt" OnClick="Button1_Click" Text="Update Details" Width="261px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:GridView ID="dgView" runat="server" CssClass="auto-style4" >
                            <Columns>
                                <asp:BoundField />
                            </Columns>
                        </asp:GridView>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
