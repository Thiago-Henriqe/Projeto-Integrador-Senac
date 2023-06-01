<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="corrida.aspx.cs" Inherits="Supaf_Html.WebForm1" %>

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


        <h1 class="titulocadastro9" id="computador">Bem-Vindo ao sistema SUPAF</h1>


        <h1 class="titulocadastro">Nova Corrida</h1>


        <div class="divtxtCorrida">

            <div class="divCorrida">
                <p class="textoDivCorrida2">Retirar</p>
            </div>

            <p id="computador" class="textoComputadorCadastro">Horário retirada</p>
            <asp:TextBox ID="txthorarioRetiraCorrida" runat="server" placeholder="Horario corrida" CssClass="caixatextoCadastro2"></asp:TextBox>
            <p id="computador" class="textoComputadorCadastro">Data retirada</p>
            <asp:TextBox ID="txtdataRetiraCorrida" runat="server" placeholder="Data retirada" CssClass="caixatextoCadastro2"></asp:TextBox>
            <p id="computador" class="textoComputadorCadastro">Cidade retirada</p>
            <asp:TextBox ID="txtcidadeRetiradaCorrida" runat="server" placeholder="Cidade retirada" CssClass="caixatextoCadastro2"></asp:TextBox>
            <p id="computador" class="textoComputadorCadastro">Endereço retirada</p>
            <asp:TextBox ID="txtenderecoRetiradaCorrida" runat="server" placeholder="Endereço retirada" CssClass="caixatextoCadastro2"></asp:TextBox>
            <p id="computador" class="textoComputadorCadastro">Número retirada</p>
            <asp:TextBox ID="txtenderecoNumeroRetiradaCorrida" runat="server" placeholder="Número retirada" CssClass="caixatextoCadastro2"></asp:TextBox>
            <p id="computador" class="textoComputadorCadastro">Complemento retirada</p>
            <asp:TextBox ID="txtenderecoComplementoRetiradaCorrida" runat="server" placeholder="Complemento retirada" CssClass="caixatextoCadastro2"></asp:TextBox>
            <p id="computador" class="textoComputadorCadastro">CEP retirada </p>
            <asp:TextBox ID="txtcepRetiraCorrida" runat="server" placeholder="CEP retirada" CssClass="caixatextoCadastro2"></asp:TextBox>

            <div class="divCorrida">
                <p class="textoDivCorrida2">Entregar</p>
            </div>

            <p id="computador" class="textoComputadorCadastro">Horário entrega</p>
            <asp:TextBox ID="txthorarioEntregaCorrida" runat="server" placeholder="Horario da entrega" CssClass="caixatextoCadastro2"></asp:TextBox>
            <p id="computador" class="textoComputadorCadastro">Data entrega</p>
            <asp:TextBox ID="txtdataEntregaCorrida" runat="server" placeholder="Data da entrega" CssClass="caixatextoCadastro2"></asp:TextBox>
            <p id="computador" class="textoComputadorCadastro">Cidade entrega</p>
            <asp:TextBox ID="txtcidadeEntregaCorrida" runat="server" placeholder="Cidade entrega" CssClass="caixatextoCadastro2"></asp:TextBox>
            <p id="computador" class="textoComputadorCadastro">Endereço entrega</p>
            <asp:TextBox ID="txtenderecoEntregaCorrida" runat="server" placeholder="Endereço entrega" CssClass="caixatextoCadastro2"></asp:TextBox>
            <p id="computador" class="textoComputadorCadastro">Número entrega</p>
            <asp:TextBox ID="txtenderecoNumeroEntregaCorrida" runat="server" placeholder="Número entrega" CssClass="caixatextoCadastro2"></asp:TextBox>
            <p id="computador" class="textoComputadorCadastro">Complemento entrega</p>
            <asp:TextBox ID="txtenderecoComplementoEntregaCorrida" runat="server" placeholder="Complemento entrega" CssClass="caixatextoCadastro2"></asp:TextBox>
            <p id="computador" class="textoComputadorCadastro">CEP entrega</p>

            <asp:TextBox ID="txtcepEntregaCorrida" runat="server" placeholder="CEP entrega" CssClass="caixatextoCadastro2"></asp:TextBox>




            <div class="divCorrida">
                <p class="textoDivCorrida2">Confira o valor</p>
            </div>

            <asp:TextBox ID="txtValor" runat="server" placeholder="Favor digitar a distância em KM" CssClass="caixatextoCadastro2"></asp:TextBox>
            <asp:Label ID="lblValor" runat="server" Text="$$$" CssClass="caixatextoCadastro"></asp:Label>


            <div class="divbotaocadastrar">
                <asp:Button ID="btnValor" runat="server" Text="Verificar valor" CssClass="botaocorrida2" OnClick="btnValor_Click" />

            </div>

            <div class="divbotaoconfirmarCorrida">
                <asp:Button ID="btnCadastrar" runat="server" Text="Confirmar" CssClass="botaocorrida" OnClick="btnCadastrar_Click" />

            </div>

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

        <%--<h1 class="titulocadastro">Cadastro de cliente</h1>
        <div class="divbordaredonda">
            <div class="divprincipalcadastro">



                <div class ="divlabel"> 
<asp:Label ID="lblhorarioRetiraCorrida" runat="server" Text="Horario da corrida:"></asp:Label>
<asp:Label ID="lbldataRetiraCorrida" runat="server" Text="Data da retirada:"></asp:Label>
<asp:Label ID="lblcidadeRetiradaCorrida" runat="server" Text="Cidade retirada:"></asp:Label>
<asp:Label ID="lblenderecoRetiradaCorrida" runat="server" Text="Endereço da retirada:"></asp:Label>
<asp:Label ID="lblenderecoNumeroRetiradaCorrida" runat="server" Text="Número"></asp:Label>
<asp:Label ID="lblenderecoComplementoRetiradaCorrida" runat="server" Text="Complemento"></asp:Label>
<asp:Label ID="lblcepRetiraCorrida" runat="server" Text="CEP"></asp:Label>
<asp:Label ID="lblhorarioEntregaCorrida" runat="server" Text="Horario da entrega:"></asp:Label>
<asp:Label ID="lbldataEntregaCorrida" runat="server" Text="Data da entrega:"></asp:Label>
<asp:Label ID="lblcidadeEntregaCorrida" runat="server" Text="Cidade entrega:"></asp:Label>
<asp:Label ID="lblenderecoEntregaCorrida" runat="server" Text="Endereço da entrega:"></asp:Label>
<asp:Label ID="lblenderecoNumeroEntregaCorrida" runat="server" Text="Número:"></asp:Label>
<asp:Label ID="lblenderecoComplementoEntregaCorrida" runat="server" Text="Complemento:"></asp:Label>
<asp:Label ID="lblcepEntregaCorrida" runat="server" Text="CEP entrega:"></asp:Label>
                </div>
                <div class="divtxt">
                    <asp:TextBox ID="txthorarioRetiraCorrida" runat="server" CssClass="campocadastro"></asp:TextBox>
                    <asp:TextBox ID="txtdataRetiraCorrida" runat="server" CssClass="campocadastro"></asp:TextBox>
                    <asp:TextBox ID="txtcidadeRetiradaCorrida" runat="server" CssClass="campocadastro"></asp:TextBox>
                    <asp:TextBox ID="txtenderecoRetiradaCorrida" runat="server" CssClass="campocadastro"></asp:TextBox>
                    <asp:TextBox ID="txtenderecoNumeroRetiradaCorrida" runat="server" CssClass="campocadastro"></asp:TextBox>
                    <asp:TextBox ID="txtenderecoComplementoRetiradaCorrida" runat="server" CssClass="campocadastro"></asp:TextBox>
                    <asp:TextBox ID="txtcepRetiraCorrida" runat="server" CssClass="campocadastro"></asp:TextBox>
                    <asp:TextBox ID="txthorarioEntregaCorrida" runat="server" CssClass="campocadastro"></asp:TextBox>
                    <asp:TextBox ID="txtdataEntregaCorrida" runat="server" CssClass="campocadastro"></asp:TextBox>
                    <asp:TextBox ID="txtcidadeEntregaCorrida" runat="server" CssClass="campocadastro"></asp:TextBox>
                    <asp:TextBox ID="txtenderecoEntregaCorrida" runat="server" CssClass="campocadastro"></asp:TextBox>
                    <asp:TextBox ID="txtenderecoNumeroEntregaCorrida" runat="server" CssClass="campocadastro"></asp:TextBox>
                    <asp:TextBox ID="txtenderecoComplementoEntregaCorrida" runat="server" CssClass="campocadastro"></asp:TextBox>
                    <asp:TextBox ID="txtcepEntregaCorrida" runat="server" CssClass="campocadastro"></asp:TextBox>

                </div>
                                </div>
            <div class="divbotaocadastrar">
                    <asp:Button ID="btnCorrida" runat="server" Text="Corrida" CssClass="botaocadastrar" OnClick="btnCorrida_Click"/>
            <asp:Button ID="btnVoltar" runat="server" Text="Voltar" CssClass="botaocadastrar" OnClick="btnVoltar_Click"/>
                </div>

            <asp:Label ID="MessageBox" runat="server" Text=""></asp:Label><br />

            </div>--%>















        <%--            <asp:Label ID="lblhorarioRetiraCorrida" runat="server" Text="horarioRetiraCorrida"></asp:Label>
<asp:TextBox ID="txthorarioRetiraCorrida" runat="server"></asp:TextBox>
<br />
<asp:Label ID="lbldataRetiraCorrida" runat="server" Text="dataRetiraCorrida"></asp:Label>
<asp:TextBox ID="txtdataRetiraCorrida" runat="server"></asp:TextBox>
<br />
<asp:Label ID="lblcidadeRetiradaCorrida" runat="server" Text="cidadeRetiradaCorrida"></asp:Label>
<asp:TextBox ID="txtcidadeRetiradaCorrida" runat="server"></asp:TextBox>
<br />
<asp:Label ID="lblenderecoRetiradaCorrida" runat="server" Text="enderecoRetiradaCorrida"></asp:Label>
<asp:TextBox ID="txtenderecoRetiradaCorrida" runat="server"></asp:TextBox>
<br />
<asp:Label ID="lblenderecoNumeroRetiradaCorrida" runat="server" Text="enderecoNumeroRetiradaCorrida"></asp:Label>
<asp:TextBox ID="txtenderecoNumeroRetiradaCorrida" runat="server"></asp:TextBox>
<br />
<asp:Label ID="lblenderecoComplementoRetiradaCorrida" runat="server" Text="enderecoComplementoRetiradaCorrida"></asp:Label>
<asp:TextBox ID="txtenderecoComplementoRetiradaCorrida" runat="server"></asp:TextBox>
<br />
<asp:Label ID="lblcepRetiraCorrida" runat="server" Text="cepRetiraCorrida"></asp:Label>
<asp:TextBox ID="txtcepRetiraCorrida" runat="server"></asp:TextBox>
<br />
<asp:Label ID="lblhorarioEntregaCorrida" runat="server" Text="horarioEntregaCorrida"></asp:Label>
<asp:TextBox ID="txthorarioEntregaCorrida" runat="server"></asp:TextBox>
<br />
<asp:Label ID="lbldataEntregaCorrida" runat="server" Text="dataEntregaCorrida"></asp:Label>
<asp:TextBox ID="txtdataEntregaCorrida" runat="server"></asp:TextBox>
<br />
<asp:Label ID="lblcidadeEntregaCorrida" runat="server" Text="cidadeEntregaCorrida"></asp:Label>
<asp:TextBox ID="txtcidadeEntregaCorrida" runat="server"></asp:TextBox>
<br />
<asp:Label ID="lblenderecoEntregaCorrida" runat="server" Text="enderecoEntregaCorrida"></asp:Label>
<asp:TextBox ID="txtenderecoEntregaCorrida" runat="server"></asp:TextBox>
<br />
<asp:Label ID="lblenderecoNumeroEntregaCorrida" runat="server" Text="enderecoNumeroEntregaCorrida"></asp:Label>
<asp:TextBox ID="txtenderecoNumeroEntregaCorrida" runat="server"></asp:TextBox>
<br />
<asp:Label ID="lblenderecoComplementoEntregaCorrida" runat="server" Text="enderecoComplementoEntregaCorrida"></asp:Label>
<asp:TextBox ID="txtenderecoComplementoEntregaCorrida" runat="server"></asp:TextBox>
<br />
<asp:Label ID="lblcepEntregaCorrida" runat="server" Text="cepEntregaCorrida"></asp:Label>
<asp:TextBox ID="txtcepEntregaCorrida" runat="server"></asp:TextBox>
<br />
            <asp:Label ID="MessageBox" runat="server" Text=""></asp:Label><br />--%>

        <%--<asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />--%>
    </form>
</body>
</html>
