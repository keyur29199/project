<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DataImage.aspx.cs" Inherits="DataImage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Product Id"></asp:Label>
        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Product Name"></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
         <asp:Label ID="Label2" runat="server" Text="Product Image"></asp:Label>
         <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
         <asp:Label ID="Label3" runat="server" Text="Product Quantity"></asp:Label>
        <asp:TextBox ID="txtQty" runat="server"></asp:TextBox>
        <br />
         <asp:Label ID="Label4" runat="server" Text="Product Price"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Add Product" 
            onclick="btnAdd_Click" />
    </div>
    <div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:x %>" 
            SelectCommand="SELECT * FROM [product]"></asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataSourceID="SqlDataSource1" CellPadding="10" CellSpacing="10">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="imageType" HeaderText="imageType" 
                    SortExpression="imageType" />
                <asp:BoundField DataField="qty" HeaderText="qty" SortExpression="qty" />
                <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                <asp:TemplateField HeaderText="Image">
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" width="200" Height="150" ImageUrl='<%# "Handler.ashx?id="+Eval("id") %>'/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
