<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         
    <tr>
    <td>
        <asp:Label ID="Labelstate" runat="server" Text="State"></asp:Label>
    </td>
    <td>
        <asp:DropDownList ID="ddstate" runat="server"  
            onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
            AutoPostBack="True">
            <asp:ListItem>Gujarat</asp:ListItem>
            <asp:ListItem>Maharastra</asp:ListItem>
            <asp:ListItem>Rajasthan</asp:ListItem>
        </asp:DropDownList> 



    </td>
    </tr>
    <tr>
    <td>
      <asp:Label ID="lb_1" runat="server"></asp:Label>  
    </td>
    </tr>
    </div>
    </form>
</body>
</html>
