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
    public class D_ComentarioRequisito
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\PrograWebIIIBD.mdf;Integrated Security = True");
        public DataTable ShowAnimacion()
        {
            DataTable search = new DataTable();
            SqlCommand command = new SqlCommand(@"SELECT Description AS Descripcion, StudentName AS Estudiante, Subject AS Materia
                                            FROM CommentRequirement
                                            WHERE Subject = 'Animacion Digital'")
            {
                CommandType = CommandType.Text
            };

            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(search);
            connection.Close();
            return search;
        }

        public DataTable ShowCiencias() 
        {
            DataTable search = new DataTable();
            SqlCommand command = new SqlCommand(@"SELECT Description AS Descripcion, StudentName AS Estudiante, Subject AS Materia 
                                            FROM CommentRequirement
                                            WHERE Subject = 'Ciencias de la Computacion'")
            {
                CommandType = CommandType.Text
            };

            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(search);
            return search;
        }
        public DataTable ShowMatematica()
        {
            DataTable search = new DataTable();
            SqlCommand command = new SqlCommand(@"SELECT Description AS Descripcion, StudentName AS Estudiante, Subject AS Materia 
                                            FROM CommentRequirement
                                            WHERE Subject = 'Matematica Computacional'")
            {
                CommandType = CommandType.Text
            };

            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(search);
            return search;
        }

        public DataTable ShowProgramacionI()
        {
            DataTable search = new DataTable();
            SqlCommand command = new SqlCommand(@"SELECT Description AS Descripcion, StudentName AS Estudiante, Subject AS Materia 
                                            FROM CommentRequirement
                                            WHERE Subject = 'Programacion I'")
            {
                CommandType = CommandType.Text
            };

            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(search);
            return search;
        }

        public DataTable ShowInglesI()
        {
            DataTable search = new DataTable();
            SqlCommand command = new SqlCommand(@"SELECT Description AS Descripcion, StudentName AS Estudiante, Subject AS Materia
                                            FROM CommentRequirement
                                            WHERE Subject = 'Ingles tecnico I'")
            {
                CommandType = CommandType.Text
            };

            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(search);
            return search;
        }

        public DataTable ShowFundamentosSoftware()
        {
            DataTable search = new DataTable();
            SqlCommand command = new SqlCommand(@"SELECT Description AS Descripcion, StudentName AS Estudiante, Subject AS Materia
                                            FROM CommentRequirement
                                            WHERE Subject = 'Fundamentos de desarrollo de software'")
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
            SqlCommand command = new SqlCommand(@"SELECT Description AS Descripcion, StudentName AS Estudiante, Subject AS Materia
                                            FROM CommentRequirement")
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
