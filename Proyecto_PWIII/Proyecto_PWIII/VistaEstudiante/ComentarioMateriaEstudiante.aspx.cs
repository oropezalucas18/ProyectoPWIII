using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocios;
using CapaDatos;
using System.Data.SqlClient;
using System.Data;

namespace Proyecto_PWIII
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        N_ComentarioMateria comentarioMateria = new N_ComentarioMateria();
        D_ComentarioMateria comentarioMateriaD = new D_ComentarioMateria();

        protected void Page_Load(object sender, EventArgs e)
        {
            Request.Cookies["subject"]["name"];
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if(Request.Cookies["name"] != null)
            {
                SqlCommand command = new SqlCommand(@"INSERT INTO ComentarioMateria(Descripcion, ComentarioEfectuadoPorEstudiante , Materia)" +
                                                     "VALUES(" + txbComentario.Text + "," + "," + ")")
                {
                    CommandType = CommandType.Text
                };
            }
                
        }
    }
}