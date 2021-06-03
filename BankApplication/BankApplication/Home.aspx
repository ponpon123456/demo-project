<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="BankApplication.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <div>
            <table style="width: 800px;">
                <tr>
                    <td style="width: 450px;"></td>
                    <td style="width: 150px;">
                        <asp:TextBox ID="txtAccount" Width="150" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                    </td>
                    <td style="width: 400px; text-align: right;">
                        <input type="button" value="Create Account" onclick="location.href = 'CreateAccount.aspx'" />
                    </td>
                </tr>
            </table>
            <div>
                <asp:GridView ID="gvList" runat="server" BackColor="White"
                    BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3"
                    HorizontalAlign="Center" AutoGenerateColumns="False">
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White"
                        HorizontalAlign="Center" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000066" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                    <Columns>
                        <asp:BoundField DataField="IBAN" HeaderText="IBAN" />
                        <asp:TemplateField HeaderText="AccountType">
                            <ItemTemplate>
                                <asp:Label ID="lblAccountTypeCode" runat="server" Text='<%# GetAccountType(Eval("AccountTypeCode")) %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Firstname" HeaderText="First name" />
                        <asp:BoundField DataField="Lastname" HeaderText="Last name" />
                        <asp:BoundField DataField="Balance" HeaderText="Balance" DataFormatString="{0:###,###,###.00}" />
                        <asp:TemplateField HeaderText="Action">
                            <ItemTemplate>
                                <a href='deposit.aspx?iban=<%# Eval("IBAN") %>'>Deposit</a>&nbsp;&nbsp;
                                <a href='transfer.aspx?iban=<%# Eval("IBAN") %>'>Transfer</a>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>

        </div>
    </form>
</body>
</html>
