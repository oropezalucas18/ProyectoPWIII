using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Entidades;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace CapaDatos
{
    public class D_ComentarioMateria
    {
        
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GitHub\ProyectoPWIII\Proyecto_PWIII\Proyecto_PWIII\App_Data\PrograWebIIIBD.mdf;Integrated Security=True;Connect Timeout=30");

        public DataTable MostrarComentarioMateriaAnimacion()
        {
            DataTable resultado = new DataTable();
            SqlCommand command = new SqlCommand(@"SELECT * 
                                            FROM ComentarioMateria
                                            WHERE Materia = 'Animacion Digital'")
            {
                CommandType = CommandType.Text
            };

            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(resultado);
            connection.Close();
            return resultado;
        }

        public DataTable MostrarComentarioMateriaCiencias()
        {
            DataTable resultado = new DataTable();
            SqlCommand command = new SqlCommand(@"SELECT * 
                                            FROM ComentarioMateria
                                            WHERE Materia = 'Ciencias de la Computacion'")
            {
                CommandType = CommandType.Text
            };

            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(resultado);
            return resultado;
        }

        public DataTable MostrarComentarioMateriaMatematica()
        {
            DataTable resultado = new DataTable();
            SqlCommand command = new SqlCommand(@"SELECT * 
                                            FROM ComentarioMateria
                                            WHERE Materia = 'Matematica Computacional'")
            {
                CommandType = CommandType.Text
            };

            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(resultado);
            return resultado;
        }

        public DataTable MostrarComentarioMateriaProgramacionI()
        {
            DataTable resultado = new DataTable();
            SqlCommand command = new SqlCommand(@"SELECT * 
                                            FROM ComentarioMateria
                                            WHERE Materia = 'Programacion I'")
            {
                CommandType = CommandType.Text
            };

            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(resultado);
            return resultado;
        }

        public DataTable MostrarComentarioMateriaInglesI()
        {
            DataTable resultado = new DataTable();
            SqlCommand command = new SqlCommand(@"SELECT * 
                                            FROM ComentarioMateria
                                            WHERE Materia = 'Ingles tecnico I'")
            {
                CommandType = CommandType.Text
            };

            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(resultado);
            return resultado;
        }

        public DataTable MostrarComentarioFundamentosSoftware()
        {
            DataTable resultado = new DataTable();
            SqlCommand command = new SqlCommand(@"SELECT * 
                                            FROM ComentarioMateria
                                            WHERE Materia = 'Fundamentos de desarrollo de software'")
            {
                CommandType = CommandType.Text
            };

            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(resultado);
            return resultado;
        }
    }

    
}
