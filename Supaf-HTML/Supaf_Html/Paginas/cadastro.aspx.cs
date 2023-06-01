using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;

namespace Supaf_Html
{
    public partial class cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.strConexao.ToString());
                SqlCommand command = new SqlCommand();
                command.CommandText = "pi_Cliente";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                //inicio criptografia
                MD5 criaCripto = MD5.Create();
                byte[] vetorByte = Encoding.ASCII.GetBytes(txtsenhaCliente.Text);
                byte[] vetorHash = criaCripto.ComputeHash(vetorByte);

                StringBuilder senhaCriptografada = new StringBuilder();

                for (int i = 0; i < vetorHash.Length; i++)
                {
                    senhaCriptografada.Append(vetorHash[i].ToString("X2"));
                }

                //fim criptografia


                command.Parameters.AddWithValue("nomeCliente", txtnomeCliente.Text);
                command.Parameters.AddWithValue("cpfouCPNJCliente", txtcpfouCPNJCliente.Text);
                command.Parameters.AddWithValue("emailCliente", txtloginClienteemailCliente.Text);
                command.Parameters.AddWithValue("cidadeCliente", txtcidadeCliente.Text);
                command.Parameters.AddWithValue("enderecoCliente", txtenderecoCliente.Text);
                command.Parameters.AddWithValue("enderecoNumeroCLiente", txtenderecoNumeroCliente.Text);
                command.Parameters.AddWithValue("enderecoComplementoCliente", txtenderecoComplementoCliente.Text);
                command.Parameters.AddWithValue("telefoneCliente", txttelefoneCliente.Text);
                command.Parameters.AddWithValue("celularCliente", txtcelularCliente.Text);

                command.Parameters.AddWithValue("loginCliente", txtloginClienteemailCliente.Text);
                command.Parameters.AddWithValue("senhaCliente", senhaCriptografada.ToString());

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                Response.Write("<script>alert('Cliente Cadastrado')</script>");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);

            }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../default.aspx");
        }

        protected void computador_Click(object sender, EventArgs e)
        {
            Response.Redirect("../default.aspx");
        }
    }
}