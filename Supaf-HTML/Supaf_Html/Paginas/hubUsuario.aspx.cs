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
using static System.Collections.Specialized.BitVector32;

namespace Supaf_Html.Paginas
{
    public partial class hubUsuario : System.Web.UI.Page
    {
        public static string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            string nome;
            try
            {


                HttpCookie cookie = Request.Cookies["id"];
                HttpCookie cookie2 = Request.Cookies["nome"];

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

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        protected void btnDeslogar_Click(object sender, EventArgs e)
        {
            //HttpContext.Current.Session.Abandon();
            //HttpContext.Current.Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));

            Response.Cookies["id"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["nome"].Expires = DateTime.Now.AddDays(-1);            

            //Session.Clear();
            //Session.Abandon();
            Response.Redirect("../default.aspx");

        }





    }
}