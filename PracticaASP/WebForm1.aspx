<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="PracticaASP.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="color:darksalmon" >Hola mundo!</h1>
        </div>
        <div>
            <asp:Label ID="lblNuevoDepartamento" runat="server" Text="Ingrese el nombre del nuevo departamento"></asp:Label>
            <asp:TextBox ID="txtboxNombreDepartament" runat="server"></asp:TextBox>
            <asp:Button ID="btnGuardarNuevoDepartamento" runat="server" Text="Guardar" />
            <asp:Label ID="lblMensaje" runat="server" Text="Label" Visible="false"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="gridDepartamentos" runat="server"></asp:GridView>
            </div>
    </form>
</body>
</html>
