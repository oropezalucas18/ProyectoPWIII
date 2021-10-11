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
            Response.Cookies["subject"]["nameSubject"] = cmbSubjects.SelectedValue;
        }

        protected void cmbTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Cookies["teacher"]["nameTeacher"] = cmbTeachers.SelectedValue;
        }

        protected void cmbPreSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Cookies["presubject"]["namePresubject"] = cmbPreSubjects.SelectedValue;
        }
    }
}