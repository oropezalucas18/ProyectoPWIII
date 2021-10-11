using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_PWIII
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPageInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaInicio.aspx");
        }

        protected void btnPageMateriasPre_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/VistaEstudiante/ComentarioRequisitoEstudiante.aspx");
        }

        protected void btnPageDocente_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/VistaEstudiante/ComentarioDocenteEstudiante.aspx");
        }

        protected void btnPageCerrarSesion_Click(object sender, EventArgs e)
        {

        }

        protected void cmbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Cookies["subject"]["name"] = cmbSubjects.SelectedValue;
        }
    }
}