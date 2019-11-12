<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:Panel ID="Panel1" runat="server" Height="202px" ScrollBars="Horizontal" 
            Width="316px">
            <asp:Image ID="Image1" runat="server" Height="100px" 
                ImageUrl="C:\Users\Public\Pictures\Sample Pictures\Desert.jpg" Width="100px" DescriptionUrl="~/Home.aspx"/>
           
            <asp:ImageButton ID="ImageButton1" runat="server" 
                ImageUrl="C:\Users\Public\Pictures\Sample Pictures\Desert.jpg" Height="100px" Width="100px" 
                onclick="ImageButton1_Click" />
            
             
          
           <asp:HyperLink  ID="HyperLink1" runat="server"     
       ImageUrl="C:\Users\Public\Pictures\Sample Pictures\Desert.jpg"  NavigateUrl="~/Contact.aspx"> Page2       </asp:HyperLink>

          
        </asp:Panel>

        <asp:ImageMap ID="ImageMap1" ImageUrl="C:\Users\Public\Pictures\Sample Pictures\Desert.jpg" Width="300" 
            HotSpotMode="Navigate"  runat="server">
        
        <asp:RectangleHotSpot Top="0" Bottom="225" Left="0" Right="255" AlternateText="chicago" NavigateUrl="~/Home.aspx" PostBackValue="You are on left side of SearTowers" />
       
        <asp:RectangleHotSpot Top="0" Bottom="225" Left="151" Right="300" AlternateText="chicago1" NavigateUrl="~/Contact.aspx" PostBackValue="You are on right side of SearTowers" />
        </asp:ImageMap> 

         <asp:ImageMap ID="ImageMap2" ImageUrl="C:\Users\Public\Pictures\Sample Pictures\Desert.jpg" Width="300" 
            HotSpotMode="PostBack"  runat="server" onclick="ImageMap2_Click">
        
        <asp:RectangleHotSpot Top="0" Bottom="225" Left="0" Right="255" AlternateText="chicago"  PostBackValue="You are on left side of SearTowers" />
        
        <asp:RectangleHotSpot Top="0" Bottom="225" Left="151" Right="300" AlternateText="chicago1"  PostBackValue="You are on right side of SearTowers" />
        </asp:ImageMap> 

        <asp:ImageMap ID="ImageMap3" ImageUrl="C:\Users\Public\Pictures\Sample Pictures\Desert.jpg" Width="300" 
            HotSpotMode="PostBack"  runat="server" onclick="ImageMap3_Click" >
        
        <asp:CircleHotSpot X="100" Y="100" Radius="220" AlternateText="chicago"  PostBackValue="You are click on Circle hotspot " />
        </asp:ImageMap> 

    </div>
    </form>
</body>
</html>
