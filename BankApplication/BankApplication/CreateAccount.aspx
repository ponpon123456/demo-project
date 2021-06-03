<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateAccount.aspx.cs" Inherits="BankApplication.CreateAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/lodash.min.js"></script>
    <script src="Scripts/jquery.min.js"></script>
    <script src="Scripts/mapp4.js"></script>
    <script>
        $('document').ready(function () {
            var iban = buildIbans('Netherlands');
            document.getElementById('<%=lblIBAN.ClientID%>').innerHTML = iban;
            document.getElementById('<%=hidIBAN.ClientID%>').value = iban;
        });

        function save() {
            document.getElementById('<%=btnSave.ClientID%>').click();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:HiddenField ID="hidIBAN" runat="server" />
        <div>
            <table>
                <tr>
                    <td style="width: 100px">IBAN</td>
                    <td>
                        <asp:Label ID="lblIBAN" runat="server" BackColor="Yellow"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 100px">Account type</td>
                    <td>
                        <asp:DropDownList ID="ddlAccountType" runat="server">
                            <asp:ListItem Value=""> -- Please select --</asp:ListItem>
                            <asp:ListItem Value="1" Text="Saving Deposit"></asp:ListItem>
                            <asp:ListItem Value="2" Text="Current Deposit "></asp:ListItem>
                            <asp:ListItem Value="3" Text="Fixed Deposit"></asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="reqAccountType" runat="server" ErrorMessage="Account type cannot be blank" ControlToValidate="ddlAccountType" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 100px">First name</td>
                    <td>
                        <asp:TextBox ID="txtFirstname" runat="server" MaxLength="50"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqFirstname" runat="server" ErrorMessage="First name cannot be blank" ControlToValidate="txtFirstname" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 100px">Last name</td>
                    <td>
                        <asp:TextBox ID="txtLastname" runat="server" MaxLength="50"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqLastname" runat="server" ErrorMessage="Last name cannot be blank" ControlToValidate="txtLastname" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr style="vertical-align: top;">
                    <td style="width: 100px">Address</td>
                    <td>
                        <asp:TextBox ID="txtAddress" TextMode="MultiLine" Rows="4" MaxLength="200" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 100px">Mobile</td>
                    <td>
                        <asp:TextBox ID="txtMobile" runat="server" MaxLength="20"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSave" Text="Create" runat="server" OnClick="btnSave_Click" Style="display: none" />
                        &nbsp;
                        <input type="button" value="Save" onclick="save();" />
                        <input type="button" value="Cancel" onclick="location.href = 'Home.aspx'" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
