<%@ Page Language="C#" AutoEventWireup="true" CodeFile="viewState.aspx.cs" Inherits="viewState" EnableViewState="true"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="Panel1" runat="server" BackColor="#99CCFF" Height="57px" 
            Width="129px"><center>
            <asp:Label ID="Label2" runat="server" Text="View State"></asp:Label></center>
                <asp:Label ID="Label1" runat="server" Text="Label" EnableViewState="False"></asp:Label><br />
            <asp:Button ID="btnClick" runat="server" Text="Click" 
            onclick="btnClick_Click" />
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel2" runat="server" BackColor="Azure" >
        
         
        </asp:Panel>
        <br />
         <asp:Panel ID="Panel3" runat="server" BackColor="Azure" >
            <asp:Label ID="Label3" runat="server" Text="User Name"></asp:Label>
             <asp:TextBox ID="txtUnm" runat="server"></asp:TextBox><br />
             <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPass" runat="server"></asp:TextBox><br />
            <asp:LinkButton ID="linkCreate" runat="server" onclick="linkCreate_Click">Submit</asp:LinkButton><br />
          </asp:Panel> 
       </div>
    </form>
</body>
</html>
