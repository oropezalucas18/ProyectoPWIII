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
    public class D_Materia
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GitHub\ProyectoPWIII\Proyecto_PWIII\Proyecto_PWIII\App_Data\PrograWebIIIBD.mdf;Integrated Security=True;Connect Timeout=30");

        public DataTable ShowAnimacion()
        {
            DataTable search = new DataTable();
            SqlCommand command = new SqlCommand(@"SELECT Prerequisite AS Pre-Requisito, Request AS Requisito
                                            FROM Subject
                                            WHERE Subject = 'Animacion Digital'", connection)
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
            SqlCommand command = new SqlCommand(@"SELECT Prerequisite AS Pre-Requisito, Request AS Requisito
                                            FROM Subject
                                            WHERE Subject = 'Ciencias de la Computacion'", connection)
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
            SqlCommand command = new SqlCommand(@"SELECT Prerequisite AS Pre-Requisito, Request AS Requisito
                                            FROM Subject
                                            WHERE Subject = 'Matematica Computacional'", connection)
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
            SqlCommand command = new SqlCommand(@"SELECT Prerequisite AS Pre-Requisito, Request AS Requisito
                                            FROM Subject
                                            WHERE Subject = 'Programacion I'", connection)
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
            SqlCommand command = new SqlCommand(@"SELECT Prerequisite AS Pre-Requisito, Request AS Requisito
                                            FROM Subject
                                            WHERE Subject = 'Ingles tecnico I'", connection)
            {
                CommandType = CommandType.Text
            };

            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(search);
            return search;
        }

        public DataTable ShowSoftware()
        {
            DataTable search = new DataTable();
            SqlCommand command = new SqlCommand(@"SELECT Prerequisite AS Pre-Requisito, Request AS Requisito
                                            FROM Subject
                                            WHERE Subject = 'Fundamentos de desarrollo de software'", connection)
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
