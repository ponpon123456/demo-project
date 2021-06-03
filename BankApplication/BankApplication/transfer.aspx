<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="transfer.aspx.cs" Inherits="BankApplication.transfer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>

        function save() {
            if (document.getElementById('txtAmount').value == "") {
                return;
            }
            document.getElementById('<%=hidAmount.ClientID%>').value = document.getElementById('txtAmount').value;
            document.getElementById('<%=btnSave.ClientID%>').click();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:HiddenField ID="hidAmount" runat="server" />
        <div>
            <h1>Transfer</h1>
            <table>
                <tr>
                    <td style="width: 100px">IBAN</td>
                    <td>
                        <asp:Label ID="lblIBAN" runat="server" BackColor="Yellow"></asp:Label>
                    </td>
                </tr>
                 <tr>
                    <td style="width: 100px">Transfer to</td>
                    <td>
                        <asp:DropDownList ID="ddlAccountTo" runat="server" DataTextField="IBAN" DataValueField="IBAN">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="reqAccountTo" runat="server" ErrorMessage="Account for transfer cannot be blank" ControlToValidate="ddlAccountTo" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 100px">Amount</td>
                    <td>
                        <input type="number" id="txtAmount" name="txtAmount" min="0" max="10000000" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSave" Text="Transfer" runat="server" OnClick="btnSave_Click" Style="display: none" />
                        &nbsp;
                        <input type="button" value="Transfer" onclick="save();" />
                        <input type="button" value="Cancel" onclick="location.href = 'Home.aspx'" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
