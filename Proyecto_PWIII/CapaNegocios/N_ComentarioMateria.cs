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
        public DataTable ShowAnimacion()
        {
            return comentarioMateria.ShowAnimacion();
        }
        public DataTable ShowComputacion()
        {
            return comentarioMateria.ShowCiencias();
        }
        public DataTable ShowMatematica()
        {
            return comentarioMateria.ShowMatematica();
        }
        public DataTable ShowProgramacionI()
        {
            return comentarioMateria.ShowProgramacionI();
        }
        public DataTable ShowInglesI()
        {
            return comentarioMateria.ShowInglesI();
        }
        public DataTable ShowDesarrolloSoftware()
        {
            return comentarioMateria.ShowSoftware();
        }
        public DataTable ShowAll()
        {
            return comentarioMateria.ShowAll();
        }

    }
}
