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
    public partial class pagamento : System.Web.UI.Page
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

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {

            DivGIF.Visible = true;
           
        }
    }
}