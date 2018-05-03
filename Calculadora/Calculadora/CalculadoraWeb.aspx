<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculadoraWeb.aspx.cs" Inherits="Calculadora.CalculadoraWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Numero 1:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    
    </div>
        <p>
            Numero 2:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            Operador:
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="1">Suma</asp:ListItem>
                <asp:ListItem Value="2">Resta</asp:ListItem>
                <asp:ListItem Value="3">Multiplicacion</asp:ListItem>
                <asp:ListItem Value="4">Division</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:Button ID="BtnCalcular" runat="server" Text="Calcular" OnClick="BtnCalcular_Click" />
        </p>
        <p>
            <asp:Label ID="LblResult" runat="server" Text="0"></asp:Label>
        </p>
    </form>
</body>
</html>
