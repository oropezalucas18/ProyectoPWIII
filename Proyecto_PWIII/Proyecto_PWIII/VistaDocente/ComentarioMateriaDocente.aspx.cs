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
    public partial class Comentarios : System.Web.UI.Page
    {
        D_ComentarioMateria comentarioMateriaD = new D_ComentarioMateria();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }
<<<<<<< HEAD
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = 0;
            System.Data.SqlClient.SqlConnection sqlConnection1 = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PrograWebIIIBD.mdf;Integrated Security=True");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = @"UPDATE CommentSubject set Description ='" + txbComment.Text + "' WHERE CommentID ='" + id + "'";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();

        }

        void LoadDataGrid()
        {
=======

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string MateriaString;
>>>>>>> main
            string res = "";
            switch (res)
            {
                case "Animacion Digital":
<<<<<<< HEAD
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioMateriaD.ShowAnimacion();
                    break;
                case "Ciencias de la Computacion":
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioMateriaD.ShowCiencias();
                    break;
                case "Matematica Computacional":
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioMateriaD.ShowInglesI();
                    break;
                case "Programacion I":
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioMateriaD.ShowMatematica();
                    break;
                case "Ingles tecnico I":
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioMateriaD.ShowProgramacionI();
                    break;
                case "Fundamentos de desarrollo de software":
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioMateriaD.ShowSoftware();
                    break;
                default:
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioMateriaD.ShowAll();
                    break;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = 0;
            System.Data.SqlClient.SqlConnection sqlConnection1 = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PrograWebIIIBD.mdf;Integrated Security=True");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = @"DELETE CommentSubject WHERE CommentID ='" + id + "'";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
=======
                    MateriaString = "Animacion Digital";
                    break;
                case "Ciencias de la Computacion":
                    MateriaString = "Ciencias de la Computacion";
                    break;
                case "Matematica Computacional":
                    MateriaString = "Matematica Computacional";
                    break;
                case "Programacion I":
                    MateriaString = "Programacion I";
                    break;
                case "Ingles tecnico I":
                    MateriaString = "Ingles tecnico I";
                    break;
                case "Fundamentos de desarrollo de software":
                    MateriaString = "Fundamentos de desarrollo de software";
                    break;
                default:
                    MateriaString = "";
                    break;
            }
            System.Data.SqlClient.SqlConnection sqlConnection1 = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PrograWebIIIBD.mdf;Integrated Security=True");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "UPDATE INTO CommentSubject (Description, StudentName, Subject )" + "VALUES (" + txbComment.Text + "," + MateriaString + "," + txbComment.Text + ")";
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
                case "Animacion Digital":
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioMateriaD.ShowAnimacion();
                    break;
                case "Ciencias de la Computacion":
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioMateriaD.ShowCiencias();
                    break;
                case "Matematica Computacional":
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioMateriaD.ShowInglesI();
                    break;
                case "Programacion I":
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioMateriaD.ShowMatematica();
                    break;
                case "Ingles tecnico I":
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioMateriaD.ShowProgramacionI();
                    break;
                case "Fundamentos de desarrollo de software":
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioMateriaD.ShowSoftware();
                    break;
                default:
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioMateriaD.ShowAll();
                    break;
            }
>>>>>>> main
        }
    }
}