<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastro.aspx.cs" Inherits="Supaf_Html.cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../css/estilo.css" rel="stylesheet" />
</head>
<body class="bodycadastro">
    <form id="form1" runat="server">
        <div>
        </div>
        <%--<div class="divbordaredonda">--%>
        <div id="celular">
            <asp:LinkButton ID="btnVoltar" runat="server" CssClass="botaoVoltar" OnClick="btnVoltar_Click">&lt; Voltar</asp:LinkButton>
        </div>



        <h1 class="titulocadastro5" id="computador">Bem-Vindo ao sistema SUPAF</h1>


        <img src="../imagens/supaflogo.png" class="supaflogo3" id="computador" />


        <h1 class="titulocadastro">Cadastre-se</h1>

        <h2 class="titulocadastro2">Preencha seus dados</h2>



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

        </div>





        <div class="divbotaocadastrar">
            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" CssClass="botaocadastrar" />
            <asp:Button ID="computador" runat="server" Text="Voltar" CssClass="botaocadastrar" OnClick="computador_Click" />

        </div>


        <%--</div>--%>





        <%--            <asp:Label ID="lblnomeCliente" runat="server" Text="Nome:"></asp:Label>
            <asp:TextBox ID="txtnomeCliente" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblcpfouCPNJCliente" runat="server" Text="CPF ou CNPJ:"></asp:Label>
            <asp:TextBox ID="txtcpfouCPNJCliente" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblcidadeCliente" runat="server" Text="Cidade:"></asp:Label>
            <asp:TextBox ID="txtcidadeCliente" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblenderecoCliente" runat="server" Text="Endereço:"></asp:Label>
            <asp:TextBox ID="txtenderecoCliente" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblenderecoNumeroCliente" runat="server" Text="Número:"></asp:Label>
            <asp:TextBox ID="txtenderecoNumeroCliente" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblenderecoComplementoCliente" runat="server" Text="Complemento:"></asp:Label>
            <asp:TextBox ID="txtenderecoComplementoCliente" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbltelefoneCliente" runat="server" Text="Telefone:"></asp:Label>
            <asp:TextBox ID="txttelefoneCliente" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCelularCliente" runat="server" Text="Celular:"></asp:Label>
            <asp:TextBox ID="txtcelularCliente" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblloginClienteemailCliente" runat="server" Text="E-mail / Login:"></asp:Label>
            <asp:TextBox ID="txtloginClienteemailCliente" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblsenhaCliente" runat="server" Text="Senha:"></asp:Label>
            <asp:TextBox ID="txtsenhaCliente" runat="server"></asp:TextBox>
            <br />

            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" />
            <asp:Button ID="btnVoltar" runat="server" Text="Voltar" OnClick="btnVoltar_Click" />--%>
    </form>
</body>
</html>
