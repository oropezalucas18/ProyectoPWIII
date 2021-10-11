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
    public partial class ComentarioRequisitoDocente : System.Web.UI.Page
    {
        D_ComentarioRequisito comentarioRequisitoD = new D_ComentarioRequisito();
        D_Materia materia = new D_Materia();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
            LoadDataGrid1();
        }
        void LoadDataGrid1()
        {
            string res = "";
            switch (res)
            {
                case "Animacion Digital":
                    grdShow.DataSource = null;
                    grdShow.DataSource = materia.ShowAnimacion();
                    break;
                case "Ciencias de la Computacion":
                    grdShow.DataSource = null;
                    grdShow.DataSource = materia.ShowCiencias();
                    break;
                case "Matematica Computacional":
                    grdShow.DataSource = null;
                    grdShow.DataSource = materia.ShowInglesI();
                    break;
                case "Programacion I":
                    grdShow.DataSource = null;
                    grdShow.DataSource = materia.ShowMatematica();
                    break;
                case "Ingles tecnico I":
                    grdShow.DataSource = null;
                    grdShow.DataSource = materia.ShowProgramacionI();
                    break;
                case "Fundamentos de desarrollo de software":
                    grdShow.DataSource = null;
                    grdShow.DataSource = materia.ShowSoftware();
                    break;
                default:
                    grdShow.DataSource = null;
                    grdShow.DataSource = materia.ShowAll();
                    break;
            }
        }
        void LoadDataGrid()
        {
            string res = "";
            switch (res)
            {
                case "Animacion Digital":
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioRequisitoD.ShowAnimacion();
                    break;
                case "Ciencias de la Computacion":
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioRequisitoD.ShowCiencias();
                    break;
                case "Matematica Computacional":
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioRequisitoD.ShowInglesI();
                    break;
                case "Programacion I":
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioRequisitoD.ShowMatematica();
                    break;
                case "Ingles tecnico I":
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioRequisitoD.ShowProgramacionI();
                    break;
                case "Fundamentos de desarrollo de software":
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioRequisitoD.ShowFundamentosSoftware();
                    break;
                default:
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioRequisitoD.ShowAll();
                    break;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = 0;
            System.Data.SqlClient.SqlConnection sqlConnection1 = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PrograWebIIIBD.mdf;Integrated Security=True");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = @"UPDATE CommentRequirement set Description ='" + txbComment.Text + "' WHERE CommentID ='" + id + "'";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = 0;
            System.Data.SqlClient.SqlConnection sqlConnection1 = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PrograWebIIIBD.mdf;Integrated Security=True");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = @"DELETE CommentRequirement WHERE CommentID ='" + id + "'";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }
    }
}