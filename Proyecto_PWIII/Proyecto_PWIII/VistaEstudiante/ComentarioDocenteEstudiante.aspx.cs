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

namespace Proyecto_PWIII.VistaEstudiante
{
    public partial class ComentarioDocenteEstudiante : System.Web.UI.Page
    {
        D_ComentarioDocente comentarioDocenteD = new D_ComentarioDocente();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string DocenteString;
            string res = "";
            switch (res)
            {
                case "Kenny Vidangos":
                    DocenteString = "Kenny Vidangos";
                    break;
                case "Pavel Caceres":
                    DocenteString = "Pavel Caceres";
                    break;
                case "Jose Gordillo":
                    DocenteString = "Jose Gordillo";
                    break;
                case "Daniel Cosio":
                    DocenteString = "Daniel Cosio";
                    break;
                case "David Escalera":
                    DocenteString = "David Escalera";
                    break;
                default:
                    DocenteString = "";
                    break;
            }
            System.Data.SqlClient.SqlConnection sqlConnection1 = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PrograWebIIIBD.mdf;Integrated Security=True");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = @"INSERT INTO TeacherComment (Description, StudentName, Teacher )" + "VALUES (" + txbComment.Text + "," + txbComment.Text + "," + DocenteString + ")";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }
        void LoadDataGrid()
        {
            string res = "";
            switch (res)
            {
                case "Kenny Vidangos":
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioDocenteD.ShowKenny();
                    break;
                case "Pavel Caceres":
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioDocenteD.ShowPavel();
                    break;
                case "Jose Gordillo":
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioDocenteD.ShowJose();
                    break;
                case "Daniel Cosio":
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioDocenteD.ShowDaniel();
                    break;
                case "David Escalera":
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioDocenteD.ShowDavid();
                    break;
                default:
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioDocenteD.ShowAll();
                    break;
            }
        }
    }
}