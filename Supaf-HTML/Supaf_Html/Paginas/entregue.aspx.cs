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

namespace Supaf_Html.Paginas
{
    public partial class entregue : System.Web.UI.Page
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
            Listar();
        }

        private void Listar()
        {
            string finalizada = "Finalizada";

            try
            {
                SqlConnection connection = new
               SqlConnection(Properties.Settings.Default.strConexao.ToString());


                SqlCommand command = new SqlCommand();
                command.CommandText = "ListarCorridaEntregue";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;


                command.Parameters.AddWithValue("statusCorrida", finalizada); // MUDAR PARA NOME E CPF NA BUSCA

                command.Parameters.AddWithValue("idCliente", id); // MUDAR PARA NOME E CPF NA BUSCA


                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();

                adapter.Fill(ds);

                grdPedidos.DataSource = ds;
                grdPedidos.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);

            }

        }

    }
}