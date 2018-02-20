<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Test.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="ddlCorresponsales" runat="server" AutoPostBack="True" DataTextField="COR_NOMBRE" DataValueField="COR_CORRESPONSAL_ID" OnSelectedIndexChanged="ddlCorresponsales_SelectedIndexChanged"></asp:DropDownList>
        <br/>
        <asp:Label ID="lblCorresponsal" runat="server" Text="Label"></asp:Label>
        <br/>
        <asp:Label ID="lblOficina" runat="server" Text="Label"></asp:Label>
        <br/>
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    </div>
    </form>
</body>
</html>
