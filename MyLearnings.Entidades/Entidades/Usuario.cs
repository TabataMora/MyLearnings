using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnings.Entidades.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }

        public Usuario(string nome, string senha, string email)
        {
            this.Nome = nome;
            this.Senha = senha;
            this.Email = email;
        }

        public Usuario()
        {

        }
    }
}