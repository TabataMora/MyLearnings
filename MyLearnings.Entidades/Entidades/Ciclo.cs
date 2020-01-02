using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnings.Entidades.Entidades
{
    public class Ciclo
    {
        public int Id { get; set; }
        public int IdTecnica { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Inicio { get; set; }
        public string StatusCiclo { get; set; }
        public DateTime? Termino { get; set; }

        public Ciclo(int idtecnica, int idusuario, string statusciclo)
        {
            this.IdTecnica = idtecnica;
            this.IdUsuario = idusuario;
            this.StatusCiclo = statusciclo;
        }
    }
}
