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
        public decimal? TempoCicloTermino { get; set; }

        public Ciclo()
        {

        }

        public Ciclo(int idTecnica, int idUsuario, DateTime inicio, string statusCiclo)
        {
            IdTecnica = idTecnica;
            IdUsuario = idUsuario;
            Inicio = inicio;
            StatusCiclo = statusCiclo;
        }
    }
}
