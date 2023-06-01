<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="entregue.aspx.cs" Inherits="Supaf_Html.Paginas.entregue" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/estilo.css" rel="stylesheet" />
</head>
<body class="bodycadastro">
    <form id="form1" runat="server">
        <div>
        </div>

        <h1 class="titulocadastro8" id="computador">Bem-Vindo ao sistema SUPAF</h1>

        <h1 class="titulocadastro">Entregas finalizadas</h1>
        <hr class="linha" />
        <div class="meusPedidos">
            <asp:GridView CssClass="GridPedido" ID="grdPedidos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">

                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />

            </asp:GridView>


        </div>







        <div class="divFinalEntregas">
            <a href="corrida.aspx">
                <img src="../imagens/moto.png" class="iconsBarra" /></a>
            <a href="entregas.aspx">
                <img src="../imagens/record.png" class="iconsBarra" /></a>
            <a href="entregue.aspx">
                <img src="../imagens/calendar.png" class="iconsBarra" /></a>
            <a href="hubUsuario.aspx">
                <img src="../imagens/user.png" class="iconsBarra" /></a>
        </div>


    </form>
</body>
</html>
