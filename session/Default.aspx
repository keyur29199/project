<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lbl" runat="server" Text="User Name"></asp:Label>
        <asp:TextBox ID="txtUnm" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Password" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="btnClick" runat="server" Text="Submit" 
            onclick="btnClick_Click" />
            
      <asp:Button ID="btnClear" runat="server" Text="Clear" onclick="btnClear_Click"/>
            
    </div>
    </form>
</body>
</html>
