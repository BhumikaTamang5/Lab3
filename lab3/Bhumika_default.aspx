<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rojina_default.aspx.cs" Inherits="Bhumika_Unit4.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simple Interest Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center; margin-top:50px;">
            <h2>Simple Interest Calculator</h2>
            <table style="margin:auto;">
                <tr>
                    <td>Principal (P):</td>
                    <td><asp:TextBox ID="txtPrincipal" runat="server" Width="200px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Rate of Interest (R%):</td>
                    <td><asp:TextBox ID="txtRate" runat="server" Width="200px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Time (T in years):</td>
                    <td><asp:TextBox ID="txtTime" runat="server" Width="200px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align:center; padding-top:10px;">
                        <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
                    </td>
                </tr>
            </table>
            <br />
            <asp:Label ID="lblResult" runat="server" Text="" ForeColor="Green" Font-Bold="True"></asp:Label>
        </div>
    </form>
</body>
</html>
