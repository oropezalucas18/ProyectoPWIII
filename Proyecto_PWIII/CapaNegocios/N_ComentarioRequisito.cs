using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class N_ComentarioRequisito
    {
        private readonly D_ComentarioRequisito comentarioRequisito = new D_ComentarioRequisito(); 
        public DataTable ShowAnimacion()
        {
            return comentarioRequisito.ShowAnimacion();
        }
        public DataTable MostrarComentarioComputacion()
        {
            return comentarioRequisito.ShowCiencias();
        }
        public DataTable ShowMatematica()
        {
            return comentarioRequisito.ShowMatematica();
        }
        public DataTable ShowProgramacionI()
        {
            return comentarioRequisito.ShowProgramacionI();
        }
        public DataTable ShowInglesI()
        {
            return comentarioRequisito.ShowInglesI();
        }
        public DataTable ShowDesarrolloSoftware()
        {
            return comentarioRequisito.ShowFundamentosSoftware();
        }
        public DataTable ShowAll()
        {
            return comentarioRequisito.ShowAll();
        }
    }
}
