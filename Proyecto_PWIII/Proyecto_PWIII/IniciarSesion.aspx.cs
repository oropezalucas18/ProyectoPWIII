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
            Response.Cookies["person"].Expires = DateTime.Now.AddDays(1);
            Session["email"] = txtEmail.Text;
            Session["password"] = txtPassword.Text;

            Response.Redirect("PaginaInicio.aspx");
        }
    }
}