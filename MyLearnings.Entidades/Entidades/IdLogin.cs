using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnings.Entidades.Entidades
{
    public static class IdLogin
    {
        private static int IdUsuCadastro { get; set; }

        public static int IdLogado(int pUsuarioLogado)
        {
            IdUsuCadastro = pUsuarioLogado;
            return pUsuarioLogado;
        }

        public static int ObterIdLogado()
        {
            return 1;
            return IdUsuCadastro;
        }
    }
}
