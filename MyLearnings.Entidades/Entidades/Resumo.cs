using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnings.Entidades.Entidades
{
    public class Resumo
    {
        public int Id { get; set; }
        public int IdCicloResumo { get; set; }
        public string Assunto { get; set; }
        public string Subassunto { get; set; }
        public string Texto { get; set; }

        public Resumo(int idcicloresumo, string assunto, string subassunto, string texto)
        {
            this.IdCicloResumo = idcicloresumo;
            this.Assunto = assunto;
            this.Subassunto = subassunto;
            this.Texto = texto;
        }

        public Resumo()
        {

        }
    }  
}
