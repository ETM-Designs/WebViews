<%@ Page Language="C#" AutoEventWireup="true" CodeFile="dataset2.aspx.cs" Inherits="dataset1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle1 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .newStyle2 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connStr_Nwind %>" ProviderName="<%$ ConnectionStrings:connStr_Nwind.ProviderName %>" SelectCommand="SELECT * FROM [Suppliers]"></asp:SqlDataSource>
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="True">
        </asp:GridView>
        <br />
    
    </div>
    </form>
</body>
</html>
