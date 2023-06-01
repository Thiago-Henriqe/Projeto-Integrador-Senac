<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Supaf_Html._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
        <link href="css/estilo.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            </div>

<div id="myNav" class="overlay">
            <a href="javascript:void(0)" class="closebtn" onclick="closeNav()">&times;</a>
            <div class="overlay-content">
<%--                <div class="divlogar" >
                    <div class="imagemsupaflogin">
                        <img src="imagens/supaflogo.png" class="supafloginlogo"/>
                    </div>

                    <div class="caixadologin">

                        <h1 class="titulocaixatextologin">Bem-vindo ao Supaf</h1>

                        <asp:TextBox ID="txtLogin" runat="server" placeholder="Login" CssClass="caixatexto"></asp:TextBox>

                        <asp:TextBox ID="txtSenha" runat="server" placeholder="Senha" CssClass="caixatexto" TextMode="Password"></asp:TextBox>

                        <asp:Button ID="btnLogar" runat="server" Text="Logar" CssClass="botao" OnClick="btnLogar_Click" />

                    </div>



                </div>--%>


        <h1 class="titulocadastro11" id="computador">Bem-Vindo ao sistema SUPAF</h1>



                <img src="imagens/supaflogo.png" class="supaflogo2" />

                            <h1 class="titulocadastro">Acesse sua conta</h1>
                                            <h3 id="computador" class="textoComputadorLogin3">Utilize o e-mail e senha para acessar o sistema</h3>

                <div class="divtxt">
                    <p id="computador" class="textoComputadorLogin">Digite seu e-mail</p>
                    <asp:TextBox ID="txtLogin" runat="server" placeholder="Login" CssClass="caixatextoCadastro"></asp:TextBox>
                    <p id="computador" class="textoComputadorLogin2">Digite sua senha</p>
                    <asp:TextBox ID="txtSenha" runat="server" placeholder="Senha" CssClass="caixatextoCadastro" TextMode="Password"></asp:TextBox>


                                </div>
            <div class="divbotaocadastrar">
                    <asp:Button ID="btnLogar" runat="server" Text="Logar" OnClick="btnLogar_Click" CssClass="botaocadastrar"/>

                </div>








            </div>
        </div>


        <div class="topnav">
            <a href="#home"><span  onclick="openNav()">Logar</span></a>
            <a href="paginas/cadastro.aspx"><span >Cadastrar</span></a>
        </div>

        <div class="divlogo">
            <img src="imagens/supaflogo.png" class="supaflogo" />
        </div>

                    <asp:Label ID="MessageBox" runat="server" Text=""></asp:Label><br />

    </form>

        <script src="js/script.js" type="text/javascript"></script>

</body>
</html>
