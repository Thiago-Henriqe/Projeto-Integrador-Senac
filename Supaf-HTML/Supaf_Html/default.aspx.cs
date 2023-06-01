using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data; // colocar
using System.Data.SqlClient; //colocar
using System.Configuration; //colocar CONEXAO manager
using System.Security.Cryptography; //criptografia biblio DLL
using System.Text; //dll para trabalhar com textos

namespace Supaf_Html
{
    public partial class _default : System.Web.UI.Page
    {
        public static int idFun;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
                                    
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Paginas/cadastro.aspx");
        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {

            try
            {
                HttpCookie cookie2 = new HttpCookie("nome");
                HttpCookie cookie = new HttpCookie("id");

                DateTime agora = DateTime.Now;
                TimeSpan tempo = new TimeSpan(0, 20, 0);
                cookie.Expires = agora + tempo;
                cookie2.Expires = agora + tempo;

                Response.Cookies.Add(cookie);
                Response.Cookies.Add(cookie2);



                SqlConnection connection = new
                SqlConnection(Properties.Settings.Default.strConexao.ToString());

                SqlCommand command = new SqlCommand();
                SqlDataReader leitor;
                command.CommandText = "ps_loginCliente";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                //inicio criptografia
                MD5 criaCripto = MD5.Create();
                byte[] vetorByte = Encoding.ASCII.GetBytes(txtSenha.Text);
                byte[] vetorHash = criaCripto.ComputeHash(vetorByte);
                StringBuilder senhaCriptografada = new StringBuilder();
                for (int i = 0; i < vetorHash.Length; i++)
                {
                    senhaCriptografada.Append(vetorHash[i].ToString("x2"));
                }
                //fim criptografia
                command.Parameters.Clear();
                command.Parameters.AddWithValue("loginCliente", txtLogin.Text);
                command.Parameters.AddWithValue("senhaCliente", senhaCriptografada.ToString());
                connection.Open();
                leitor = command.ExecuteReader();
                if (leitor.HasRows)
                {
                    leitor.Read();

                    cookie.Value = leitor.GetInt32(0).ToString();
                    cookie2.Value = leitor.GetString(1);

                    Response.Redirect("/Paginas/entregas.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Senha ou usuário incorretos')</script>");
                    txtSenha.Text = "";
                }


                //Response.Redirect("Paginas/corrida.aspx");
                leitor.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);

            }

        }
    }
}