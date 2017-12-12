<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <span style="font-size: 24pt"><strong>
            </strong>Car Loan Calculator<br />
        </span>Enter the required information and click Calculate!<br />
        <br />
        <br />
        <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>&nbsp;
        <asp:Label ID="lblAmount" runat="server" Text="Loan Amount"></asp:Label><br />
        <br />
        <asp:TextBox ID="txtInterest" runat="server"></asp:TextBox>&nbsp;
        <asp:Label ID="lblInterest" runat="server" Text="Interest Rate (for example, 0.09)"></asp:Label><br />
        <br />
        <asp:TextBox ID="txtPayment" runat="server"></asp:TextBox>&nbsp;
        <asp:Label ID="lblPayment" runat="server" Text="Monthly Payment"></asp:Label><br />
        <br />
        <asp:Button ID="btnCalculate" runat="server" Text="Calculate" /><br />
        <br />
        <asp:HyperLink ID="lnkHelp" runat="server" NavigateUrl="~/WebCalculatorHelp.htm">Get Help</asp:HyperLink><br />
        <br />
        <asp:HyperLink ID="lnkProspects" runat="server" NavigateUrl="~/InstructorLoans.aspx">Display Loan Prospects</asp:HyperLink></div>
    </form>
</body>
</html>
