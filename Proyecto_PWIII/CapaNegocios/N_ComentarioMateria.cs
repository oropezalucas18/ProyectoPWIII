using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class N_ComentarioMateria
    {
        private readonly D_ComentarioMateria comentarioMateria = new D_ComentarioMateria();
        public DataTable MostrarComentarioAnimacion()
        {
            return comentarioMateria.MostrarComentarioMateriaAnimacion();
        }
        public DataTable MostrarComentarioComputacion()
        {
            return comentarioMateria.MostrarComentarioMateriaCiencias();
        }
        public DataTable MostrarComentarioMatematica()
        {
            return comentarioMateria.MostrarComentarioMateriaMatematica();
        }
        public DataTable MostrarComentarioProgramacionI()
        {
            return comentarioMateria.MostrarComentarioMateriaProgramacionI();
        }
        public DataTable MostrarComentarioInglesI()
        {
            return comentarioMateria.MostrarComentarioMateriaInglesI();
        }
        public DataTable MostrarComentarioDesarrolloSoftware()
        {
            return comentarioMateria.MostrarComentarioFundamentosSoftware();
        }

    }
}
