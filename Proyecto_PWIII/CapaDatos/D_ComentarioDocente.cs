using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace CapaDatos
{
    public class D_ComentarioDocente
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GitHub\ProyectoPWIII\Proyecto_PWIII\Proyecto_PWIII\App_Data\PrograWebIIIBD.mdf;Integrated Security=True;Connect Timeout=30");

        public DataTable ShowDavid()
        {
            DataTable search = new DataTable();
            SqlCommand command = new SqlCommand(@"SELECT Description AS Descripcion, StudentName AS Estudiante, TeacherName AS Docente 
                                            FROM TeacherComment
                                            WHERE Teacher = 'David Escalera'")
            {
                CommandType = CommandType.Text
            };

            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(search);
            connection.Close();
            return search;
        }

        public DataTable ShowDaniel()
        {
            DataTable search = new DataTable();
            SqlCommand command = new SqlCommand(@"SELECT Description AS Descripcion, StudentName AS Estudiante, TeacherName AS Docente 
                                            FROM TeacherComment
                                            WHERE Teacher = 'Daniel Cosio'")
            {
                CommandType = CommandType.Text
            };

            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(search);
            return search;
        }

        public DataTable ShowKenny()
        {
            DataTable search = new DataTable();
            SqlCommand command = new SqlCommand(@"SELECT Description AS Descripcion, StudentName AS Estudiante, TeacherName AS Docente 
                                            FROM TeacherComment
                                            WHERE Teacher = 'Kenny Vidangos'")
            {
                CommandType = CommandType.Text
            };

            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(search);
            return search;
        }

        public DataTable ShowPavel()
        {
            DataTable search = new DataTable();
            SqlCommand command = new SqlCommand(@"SELECT Description AS Descripcion, StudentName AS Estudiante, TeacherName AS Docente 
                                            FROM TeacherComment
                                            WHERE Teacher= 'Pavel Caceres'")
            {
                CommandType = CommandType.Text
            };

            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(search);
            return search;
        }

        public DataTable ShowJose()
        {
            DataTable search = new DataTable();
            SqlCommand command = new SqlCommand(@"SELECT Description AS Descripcion, StudentName AS Estudiante, TeacherName AS Docente  
                                            FROM TeacherComment
                                            WHERE Teacher = 'Jose Gordillo'")
            {
                CommandType = CommandType.Text
            };

            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(search);
            return search;
        }
        public DataTable ShowAll()
        {
            DataTable search = new DataTable();
<<<<<<< HEAD
            SqlCommand command = new SqlCommand(@"SELECT Description AS Descripcion, StudentName AS Estudiante, TeacherName AS Docente
=======
            SqlCommand command = new SqlCommand(@"SELECT * 
>>>>>>> main
                                            FROM TeacherComment")
            {
                CommandType = CommandType.Text
            };

            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(search);
            return search;
        }

    }
}
