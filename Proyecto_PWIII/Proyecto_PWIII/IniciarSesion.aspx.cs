using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_PWIII
{
    public partial class IniciarSesion_Registrarse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegisterNow_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registrarse.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Cookies["user"]["email"] = txtEmail.Text;
            Response.Cookies["user"]["password"] = txtPassword.Text;
            Response.Cookies["user"].Expires = DateTime.Now.AddDays(1);
            if (txtEmail.Text.EndsWith("@univalle.edu"))
            {
                Session["emailTeacher"] = txtEmail.Text;
                Session["passwordTeacher"] = txtPassword.Text;
                Response.Redirect("PaginaInicio.aspx");
            }
            else
            {
                Session["emailStudent"] = txtEmail.Text;
                Session["passwordStudent"] = txtPassword.Text;
                Response.Redirect("PaginaInicio.aspx");
            }
        }
    }
}