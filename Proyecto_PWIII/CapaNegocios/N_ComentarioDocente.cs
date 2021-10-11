using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    class N_ComentarioDocente
    {
        private readonly D_ComentarioDocente comentarioDocente = new D_ComentarioDocente();
        public DataTable ShowAnimacion()
        {
            return comentarioDocente.ShowDaniel();
        }
        public DataTable ShowComputacion()
        {
            return comentarioDocente.ShowDavid();
        }
        public DataTable ShowMatematica()
        {
            return comentarioDocente.ShowJose();
        }
        public DataTable ShowProgramacionI()
        {
            return comentarioDocente.ShowKenny();
        }
        public DataTable ShowInglesI()
        {
            return comentarioDocente.ShowPavel();
        }
    }
}
