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


        protected void btnPageCerrarSesion_Click(object sender, EventArgs e)
        {

        }

        protected void cmbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {      
            if (Session["email"].ToString().EndsWith("@univalle.edu"))
            {
                Response.Cookies["subject"]["nameSubject"] = cmbSubjects.SelectedValue;
                Response.Redirect("~/VistaDocente/ComentarioMateriaDocente.aspx");
            }
            else
            {
                Response.Cookies["subject"]["nameSubject"] = cmbSubjects.SelectedValue;
                Response.Redirect("~/VistaEstudiante/ComentarioMateriaEstudiante.aspx");
            }
        }

        protected void cmbTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Session["email"].ToString().EndsWith("@univalle.edu"))
            {
                Response.Cookies["teacher"]["nameTeacher"] = cmbTeachers.SelectedValue;
                Response.Redirect("~/VistaDocente/ComentarioDocenteDocente.aspx");
            }
            else
            {
                Response.Cookies["teacher"]["nameTeacher"] = cmbTeachers.SelectedValue;
                Response.Redirect("~/VistaEstudiante/ComentarioDocenteEstudiante.aspx");
            }
        }

        protected void cmbPreSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Session["email"].ToString().EndsWith("@univalle.edu"))
            {
                Response.Cookies["presubject"]["namePresubject"] = cmbPreSubjects.SelectedValue;
                Response.Redirect("~/VistaDocente/ComentarioRequisitoDocente.aspx");
            }
            else
            {
                Response.Cookies["presubject"]["namePresubject"] = cmbPreSubjects.SelectedValue;
                Response.Redirect("~/VistaEstudiante/ComentarioRequisitoEstudiante.aspx");
            }
        }
    }
}