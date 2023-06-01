<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pagamento.aspx.cs" Inherits="Supaf_Html.Paginas.pagamento" %>

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

        <h1 class="titulocadastro5" id="computador">Bem-Vindo ao sistema SUPAF</h1>


        <h1 class="titulocadastro">Pagamento</h1>

        <div class="divPagamento">
            <p class="textoDivPagamento">Método de pagamento</p>
        </div>

        <div class="divIconesPagamento">

            <div class="divDentroIconesPagamento">
                <img src="../imagens/cartao.png" class="iconePagamento" />
            </div>
            <div class="divDentroIconesPagamento">
                <img src="../imagens/cartao.png" class="iconePagamento" />
            </div>
            <div class="divDentroIconesPagamento">
                <img src="../imagens/cartao.png" class="iconePagamento" />
            </div>
            <div class="divDentroIconesPagamento">
                <img src="../imagens/cartao.png" class="iconePagamento" />
            </div>


        </div>


        <div class="divtxt">            
                <asp:TextBox ID="txtnumeroCartao" runat="server" placeholder="Número do cartão" CssClass="caixatextoCadastro"></asp:TextBox>
                <asp:TextBox ID="txtnomeCartao" runat="server" placeholder="Nome do cartão" CssClass="caixatextoCadastro"></asp:TextBox>
                <asp:TextBox ID="txtdataCartao" runat="server" placeholder="Data da validade" CssClass="caixatextoCadastro"></asp:TextBox>
                <asp:TextBox ID="txtcvvCartao" runat="server" placeholder="CVV" CssClass="caixatextoCadastro"></asp:TextBox>           
           

            <div class="divbotaocadastrar">
                <asp:Button ID="btnCadastrar" runat="server" Text="Confirmar pagamento" CssClass="botaocorrida2" OnClick="btnCadastrar_Click" />
            </div>
        </div>
         <div id="DivGIF" visible="false" runat="server">
                <img src="../imagens/pagamentoOK.gif" alt="Alternate Text" />
            </div>





        <div class="divFinalPagamento">
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
