<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hubUsuario.aspx.cs" Inherits="Supaf_Html.Paginas.hubUsuario" %>

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


        <h1 class="titulocadastro7" id="computador">Bem-Vindo ao sistema SUPAF</h1>


        <h1 class="titulocadastro">Área do usuário</h1>

        <div class="divhubusuario2">
            <p class="textohubUsuario">Dados do usuário</p>
        </div>


        <div class="divhubusuario">
            <asp:Button ID="btnAtualizar" runat="server" Text="Atualizar" CssClass="botaocorrida3" OnClick="btnAtualizar_Click" />

            <asp:Button ID="btnDeslogar" runat="server" Text="Deslogar" CssClass="botaocorrida3" OnClick="btnDeslogar_Click" />

        </div>







        <div class="divFinalHubUsuario">
            <a href="corrida.aspx">
                <img src="../imagens/moto.png" class="iconsBarraHubUsuario" /></a>
            <a href="entregas.aspx">
                <img src="../imagens/record.png" class="iconsBarraHubUsuario" /></a>
            <a href="entregue.aspx">
                <img src="../imagens/calendar.png" class="iconsBarraHubUsuario" /></a>
            <a href="hubUsuario.aspx">
                <img src="../imagens/user.png" class="iconsBarraHubUsuario" /></a>
        </div>


    </form>
</body>
</html>
