<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ADODemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <center>
    <form id="form1" runat="server">
        <div class="container-fluid " >
    
        <asp:Label ID="Label4" runat="server" Text="Search Id:"></asp:Label>
        <asp:TextBox ID="Txtid" runat="server" style="margin-left: 36px" Width="61px"></asp:TextBox>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnSearch" runat="server" OnClick="BtnSearch_Click" Text="Search" />
            <br />
            <br />
    
    </div>
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Student Name:"></asp:Label>
        <asp:TextBox ID="Txtname" runat="server" style="margin-left: 57px" Width="175px"></asp:TextBox>
    
    </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Student Email:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txtemail" runat="server" style="margin-left: 23px" Width="177px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Student Address:"></asp:Label>
            <asp:TextBox ID="Txtaddress" runat="server" style="margin-left: 48px" Width="177px"></asp:TextBox>
        </p>
        <asp:Button ID="Btncreate" runat="server" OnClick="Btncreate_Click" Text="Create" style="margin-left: 0px" Width="77px" />
         <asp:Button ID="BtnUpdate" runat="server" OnClick="BtnUpdate_Click" Text="Update" style="margin-left: 0px" Width="88px" />
        <asp:Button ID="Btndelete" runat="server" OnClick="Btndelete_Click" Text="Delete" style="margin-left: 0px" Width="95px" />
        <asp:Button ID="Btndisplay" runat="server" OnClick="Btndisplay_Click" Text="Display" style="margin-left: 0px" Width="82px" />

    
        <div>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
            </div>
        </form>
        </center>
    
</body>
</html>
