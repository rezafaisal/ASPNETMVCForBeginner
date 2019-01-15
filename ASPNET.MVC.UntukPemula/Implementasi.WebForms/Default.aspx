<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Implementasi.WebForms.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nama :
            <asp:TextBox ID="TextBox_Nama" runat="server"></asp:TextBox>
            <br /><br />
            Alamat :
            <asp:TextBox ID="TextBox_Alamat" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="Label_Hello" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="Button_Kirim" runat="server" Text="Kirim" OnClick="Button_Kirim_Click" />
        </div>
    </form>
</body>
</html>
