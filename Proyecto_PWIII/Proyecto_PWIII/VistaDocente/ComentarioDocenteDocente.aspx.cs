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
    public partial class ComentarioDocenteDocente : System.Web.UI.Page
    {
        D_ComentarioMateria comentarioMateriaD = new D_ComentarioMateria();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
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
        void LoadDataGrid()
        {
            int res = 0;
            switch (res)
            {
                case 1:
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioMateriaD.ShowAnimacion();
                    break;
                case 2:
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioMateriaD.ShowCiencias();
                    break;
                case 3:
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioMateriaD.ShowInglesI();
                    break;
                case 4:
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioMateriaD.ShowMatematica();
                    break;
                case 5:
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioMateriaD.ShowProgramacionI();
                    break;
                case 6:
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioMateriaD.ShowSoftware();
                    break;
                default:
                    grdShow.DataSource = null;
                    grdShow.DataSource = comentarioMateriaD.ShowAll();
                    break;
            }
            
        }
    }
}