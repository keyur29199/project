<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
            <HeaderTemplate>
                <table width="50%" border="1" cellpadding="10px" cellspacing="10x" align="center">
                    <tr bgcolor = "#ffffcc">
                        <th colspan="3">
                            <h1>Student Data</h1>
                        </th>
                    </tr> 
                    <tr>
                        <th>Name</th>
                        <th>Age</th>
                        <th>City</th>
                    </tr>         
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <%# DataBinder.Eval(Container.DataItem,"name") %>
                    </td>
                    <td>
                         <%# DataBinder.Eval(Container.DataItem,"age") %>
                    </td>
                    <td>
                        <%# DataBinder.Eval(Container.DataItem,"city") %>
                    </td>
                </tr>
            </ItemTemplate>
            <AlternatingItemTemplate>
            
                <tr>
                    <td>
                        <%# DataBinder.Eval(Container.DataItem,"name") %>
                    </td>
                    <td>
                         <%# DataBinder.Eval(Container.DataItem,"age") %>
                    </td>
                    <td>
                        <%# DataBinder.Eval(Container.DataItem,"city") %>
                    </td>
                </tr>
            </AlternatingItemTemplate>
            
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
    
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True" 
        ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [stud]">
    </asp:SqlDataSource>
    
     <asp:Repeater ID="Repeater2" runat="server" >
            <HeaderTemplate>
                <table width="50%" border="1" cellpadding="10px" cellspacing="10x" align="center">
                    <tr bgcolor = "#99ccff">
                        <th colspan="4">
                            <h1>Student Data</h1>
                        </th>
                    </tr> 
                    <tr>
                        <th>Id</th>
                        <th>Name</th>
                        <th>Age</th>
                        <th>City</th>
                    </tr>         
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <%# DataBinder.Eval(Container.DataItem,"id") %>
                    </td>
                    <td>
                        <%# DataBinder.Eval(Container.DataItem,"name") %>
                    </td>
                    <td>
                         <%# DataBinder.Eval(Container.DataItem,"age") %>
                    </td>
                    <td>
                        <%# DataBinder.Eval(Container.DataItem,"city") %>
                    </td>
                </tr>
            
            </ItemTemplate>
            <AlternatingItemTemplate>
            
                <tr>
                     <td>
                        <%# DataBinder.Eval(Container.DataItem,"id") %>
                    </td>
                    <td>
                        <%# DataBinder.Eval(Container.DataItem,"name") %>
                    </td>
                    <td>
                         <%# DataBinder.Eval(Container.DataItem,"age") %>
                    </td>
                    <td>
                        <%# DataBinder.Eval(Container.DataItem,"city") %>
                    </td>
                </tr>
            </AlternatingItemTemplate>
            
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
    
    </form>
</body>
</html>
