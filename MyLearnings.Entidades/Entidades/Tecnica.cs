using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnings.Entidades.Entidades
{
    public class Tecnica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Padrao { get; set; }
        public decimal TempoCiclo { get; set; }
        public decimal DescCurto { get; set; }
        public decimal DescLongo { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IdUsuarioCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int? IdUsuarioAlteracao { get; set; }

        public Tecnica(string nome, string padrao, decimal tempociclo, decimal descurto, decimal desclongo)
        {
            this.Nome = nome;
            this.Padrao = padrao;
            this.TempoCiclo = tempociclo;
            this.DescCurto = descurto;
            this.DescLongo = desclongo;
        }
    }
}
