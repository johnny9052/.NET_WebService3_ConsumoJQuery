<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="WebService3_ConsumoJs.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="Scripts/Jquery.js"></script>
    <script src="Scripts/WebService.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <input type="text" value="johnny" id="txtNombre" />
        <input type="button" value="llamar" onclick="callService();" />
        <asp:Label ID="lblRespuesta" runat="server" Text=""></asp:Label>
        
    </form>
</body>
</html>
