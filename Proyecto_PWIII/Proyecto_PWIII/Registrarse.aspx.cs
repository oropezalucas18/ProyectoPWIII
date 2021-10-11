using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_PWIII
{
    public partial class Registrarse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection sqlConnection1 = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PrograWebIIIBD.mdf;Integrated Security=True");

            if (txtEmail.Text.EndsWith("@univalle.edu"))
            {
                Response.Cookies["user"]["emailTeacher"] = txtEmail.Text;
                Response.Cookies["user"]["name"] = txtName.Text;
                Response.Cookies["user"]["lastName"] = txtLastName.Text;
                Response.Cookies["user"]["secondLastName"] = txtSecondLastName.Text;
                Response.Cookies["user"]["password"] = txtPassword.Text;
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = @"INSERT INTO Teacher (FirstName, LastName, SecondLastName, Email )" + "VALUES (" + txtName.Text + "," + txtLastName.Text + "," + txtSecondLastName + "," + txtEmail + ")";
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();
            }
            else
            {
                Response.Cookies["user"]["emailStudent"] = txtEmail.Text;
                Response.Cookies["user"]["name"] = txtName.Text;
                Response.Cookies["user"]["lastName"] = txtLastName.Text;
                Response.Cookies["user"]["secondLastName"] = txtSecondLastName.Text;
                Response.Cookies["user"]["password"] = txtPassword.Text;
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = @"INSERT INTO Student (Name, LastName, SecondLastName, Email )" + "VALUES (" + txtName.Text + "," + txtLastName.Text + "," + txtSecondLastName + "," + txtEmail + ")";
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();
            }
        }
    }
}