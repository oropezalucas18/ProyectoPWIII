using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_PWIII
{
    public class ComentarioMateria
    {
        public int ComentarioID { get; set; }
        public string Descripcion { get; set; }
        public string ComentarioEstudiante { get; set; }
        public string ComentarioDocente { get; set; }
        public string Materia { get; set; }
        public char Estado { get; set; }

        public ComentarioMateria(int comentarioID, string descripcion, string comentarioEstudiante, string comentarioDocente, string materia, char estado)
        {
            ComentarioID = comentarioID;
            Descripcion = descripcion;
            ComentarioEstudiante = comentarioEstudiante;
            ComentarioDocente = comentarioDocente;
            Materia = materia;
            Estado = estado;
        }
    }
}