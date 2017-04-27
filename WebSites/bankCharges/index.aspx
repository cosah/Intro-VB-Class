<%@ Page Language="VB" AutoEventWireup="false" CodeFile="index.aspx.vb" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Checking Charges</title>
</head>
<body>
    <div><h2>Checking Fee Calculator</h2></div>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td style="text-align: right">
                Checks Written:
            </td>
            <td>
                <asp:TextBox ID="txtChecks" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: right">
                Base Fee:
            </td>
            <td>
                <asp:TextBox ID="txtBase" runat="server" BackColor="#99CCFF" ReadOnly="True">$10.00</asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: right">
                Check Fees:
            </td>
            <td>
                <asp:TextBox ID="txtCheckFees" runat="server" BackColor="#99CCFF" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: right">
                Total Checking Fees:
            </td>
            <td>
                <asp:TextBox ID="txtTotalFees" runat="server" BackColor="#99CCFF" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td style="text-align:right">
                <asp:Button ID="btnClear" runat="server" Text="Clear" UseSubmitBehavior="False" />
                <span style="display:inline-block"></span>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
            </td>
        </tr>
    </table>
    </div>
        <asp:Label ID="lblStatus" runat="server" Visible="False"></asp:Label>
    </form>
</body>
</html>
