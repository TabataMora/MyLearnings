using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnings.Entidades
{
    public class CicloEvento
    {      
        public int Id { get; set; }
        public int IdCiclo { get; set; }
        public int IdEvento { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public string Completo { get; set; }

        public CicloEvento(int idCiclo, int idEvento, DateTime inicio)
        {
            IdCiclo = idCiclo;
            IdEvento = idEvento;
            Inicio = inicio;
            Completo = "N";
        }

        public CicloEvento(DateTime termino)
        {
            Completo = "S";
            Termino = termino;
        }

        public CicloEvento()
        {

        }
    }
}
