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
    public partial class ComentarioDocenteEstudiante : System.Web.UI.Page
    {
        N_ComentarioMateria comentarioMateria = new N_ComentarioMateria();
        D_ComentarioMateria comentarioMateriaD = new D_ComentarioMateria();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection sqlConnection1 = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PrograWebIIIBD.mdf;Integrated Security=True");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO TeacherComment (Description, StudentName, Subject )" + "VALUES (" + txbComment.Text + "," + txbComment.Text + "," + txbComment.Text + ")";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }
    }
}