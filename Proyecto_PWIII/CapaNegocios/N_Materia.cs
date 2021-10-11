using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class N_Materia
    {
        private readonly D_Materia materia = new D_Materia();
        public DataTable ShowAnimacion()
        {
            return materia.ShowAnimacion();
        }
        public DataTable ShowComputacion()
        {
            return materia.ShowCiencias();
        }
        public DataTable ShowMatematica()
        {
            return materia.ShowMatematica();
        }
        public DataTable ShowProgramacionI()
        {
            return materia.ShowProgramacionI();
        }
        public DataTable ShowInglesI()
        {
            return materia.ShowInglesI();
        }
        public DataTable ShowDesarrolloSoftware()
        {
            return materia.ShowSoftware();
        }
        public DataTable ShowAll()
        {
            return materia.ShowAll();
        }
    }
}
