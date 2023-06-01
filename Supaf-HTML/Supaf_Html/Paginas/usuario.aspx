<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="usuario.aspx.cs" Inherits="Supaf_Html.Paginas.usuario" %>

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


        <h1 class="titulocadastro6" id="computador">Bem-Vindo ao sistema SUPAF</h1>


        <h1 class="titulocadastro">Área do usuário</h1>

        <div class="divCorrida">
            <p class="textoDivCorrida">Dados do usuário</p>
        </div>

        <div class="divtxt">
            <p id="computador" class="textoComputadorCadastro">Nome</p>
            <asp:TextBox ID="txtnomeCliente" runat="server" placeholder="Nome" CssClass="caixatextoCadastro"></asp:TextBox>
            <p id="computador" class="textoComputadorCadastro">CPF ou CNPJ</p>
            <asp:TextBox ID="txtcpfouCPNJCliente" runat="server" placeholder="CPF ou CNPJ" CssClass="caixatextoCadastro"></asp:TextBox>
            <p id="computador" class="textoComputadorCadastro">Cidade</p>
            <asp:TextBox ID="txtcidadeCliente" runat="server" placeholder="Cidade" CssClass="caixatextoCadastro"></asp:TextBox>
            <p id="computador" class="textoComputadorCadastro">Endereço</p>
            <asp:TextBox ID="txtenderecoCliente" runat="server" placeholder="Endereço" CssClass="caixatextoCadastro"></asp:TextBox>
            <p id="computador" class="textoComputadorCadastro">Número</p>
            <asp:TextBox ID="txtenderecoNumeroCliente" runat="server" placeholder="Número" CssClass="caixatextoCadastro"></asp:TextBox>
            <p id="computador" class="textoComputadorCadastro">Complemento</p>
            <asp:TextBox ID="txtenderecoComplementoCliente" runat="server" placeholder="Complemento" CssClass="caixatextoCadastro"></asp:TextBox>
            <p id="computador" class="textoComputadorCadastro">Telefone</p>
            <asp:TextBox ID="txttelefoneCliente" runat="server" placeholder="Telefone" CssClass="caixatextoCadastro"></asp:TextBox>
            <p id="computador" class="textoComputadorCadastro">Celular</p>
            <asp:TextBox ID="txtcelularCliente" runat="server" placeholder="Celular" CssClass="caixatextoCadastro"></asp:TextBox>
            <p id="computador" class="textoComputadorCadastro">E-mail / Login</p>
            <asp:TextBox ID="txtloginClienteemailCliente" runat="server" placeholder="E-mail / Login" CssClass="caixatextoCadastro"></asp:TextBox>
            <p id="computador" class="textoComputadorCadastro">Senha</p>
            <asp:TextBox ID="txtsenhaCliente" runat="server" placeholder="Senha" CssClass="caixatextoCadastro"></asp:TextBox>


            <div class="divbotaousuario">
                <asp:Button ID="btnAtualizar" runat="server" Text="Atualizar" CssClass="botaocadastrar" />
                <asp:Button ID="computador" runat="server" Text="Voltar" CssClass="botaocadastrar" />

            </div>

            <%--                               <div class="divbotaocadastrar">
                    <asp:Button ID="btnCadastrar" runat="server" Text="Atualizar" CssClass="botaocorrida2"/>

                </div>--%>
        </div>





        <div class="divFinalCorrida">
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
