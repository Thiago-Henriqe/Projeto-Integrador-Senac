using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data; // colocar
using System.Data.SqlClient; //colocar
using System.Configuration; //colocar CONEXAO manager
using System.Security.Cryptography; //criptografia biblio DLL
using System.Text; //dll para trabalhar com textos
using System.Net;

namespace Supaf_Html
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            string nome;
            try
            {


                HttpCookie cookie = Request.Cookies["id"];

                HttpCookie cookie2 = Request.Cookies["nome"];

                //Response.Write(cookie.Value + cookie2.Value);

                if (cookie == null)
                {
                    Response.Redirect("../default.aspx");

                }
                else
                {
                    id = cookie.Value.ToString();
                    nome = cookie2.Value.ToString();
                }


            }
            catch (NullReferenceException)
            {
                //Response.Write(ex.Message);
                Response.Redirect("default.aspx");

            }

        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../default.aspx");
        }

        protected void btnCorrida_Click(object sender, EventArgs e)
        {
        }

        protected void btnVoltar_Click1(object sender, EventArgs e)
        {
            Response.Redirect("../default.aspx");
        }

        protected void btnValor_Click(object sender, EventArgs e)
        {

            try
            {
                txtValor.Text = txtValor.Text.Replace(".", ",");

                string distancia;

                distancia = txtValor.Text.ToString();

                lblValor.Text =  (Convert.ToDouble(distancia) * 0.95).ToString("n2");

            }
            catch (Exception EX)
            {

                Response.Write(EX.Message);
            }
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (lblValor.Text != "")
                {
                    SqlConnection connection = new SqlConnection(Properties.Settings.Default.strConexao.ToString());

                    SqlCommand command = new SqlCommand();
                    command.CommandText = "pi_Corrida";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;


                    //Retira
                    command.Parameters.AddWithValue("IdCliente", id);
                    command.Parameters.AddWithValue("valorCorrida", lblValor.Text);
                    command.Parameters.AddWithValue("distanciaCorrida", txtValor.Text);

                    command.Parameters.AddWithValue("horarioRetiraCorrida", txthorarioRetiraCorrida.Text);
                    command.Parameters.AddWithValue("dataRetiraCorrida", txtdataRetiraCorrida.Text);
                    command.Parameters.AddWithValue("cidadeRetiradaCorrida", txtcidadeRetiradaCorrida.Text);
                    command.Parameters.AddWithValue("enderecoRetiradaCorrida", txtenderecoRetiradaCorrida.Text);
                    command.Parameters.AddWithValue("enderecoNumeroRetiradaCorrida", txtenderecoNumeroRetiradaCorrida.Text);
                    command.Parameters.AddWithValue("enderecoComplementoRetiradaCorrida", txtenderecoComplementoRetiradaCorrida.Text);
                    command.Parameters.AddWithValue("cepRetiraCorrida", txtcepRetiraCorrida.Text);
                    //Entrega
                    command.Parameters.AddWithValue("horarioEntregaCorrida", txthorarioEntregaCorrida.Text);
                    command.Parameters.AddWithValue("dataEntregaCorrida", txtdataEntregaCorrida.Text);
                    command.Parameters.AddWithValue("cidadeEntregaCorrida", txtcidadeEntregaCorrida.Text);
                    command.Parameters.AddWithValue("enderecoEntregaCorrida", txtenderecoEntregaCorrida.Text);
                    command.Parameters.AddWithValue("enderecoNumeroEntregaCorrida", txtenderecoNumeroEntregaCorrida.Text);
                    command.Parameters.AddWithValue("enderecoComplementoEntregaCorrida", txtenderecoComplementoEntregaCorrida.Text);
                    command.Parameters.AddWithValue("cepEntregaCorrida", txtcepEntregaCorrida.Text);
                    //status
                    


                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();


                    Response.Write("<script>alert('Corrida cadastrada')</script>");
                    Response.Redirect("pagamento.aspx");

                }
                else
                {
                    Response.Write("<script>alert('Preencha a distancia')</script>");
                }

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}