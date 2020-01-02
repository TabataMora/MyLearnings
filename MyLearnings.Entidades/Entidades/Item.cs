using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnings.Entidades.Entidades
{
    public class Item
    {
        public int Id { get; set; }
        public int IdCiclo { get; set; }
        public string TipoCiclo { get; set; }
        public DateTime InicioItem { get; set; }
        public string StatusItem { get; set; }

        public Item(int idciclo, string tipociclo, string statusitem)
        {
            this.IdCiclo = idciclo;
            this.TipoCiclo = tipociclo;
            this.StatusItem = statusitem;
        }
    }
}
