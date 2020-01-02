using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnings.Entidades.Entidades
{
    public class EuSouUmaClasse
    {

        public EuSouUmaClasse()
        {
            Console.WriteLine("Eu sou a classe EuSouUmInteiro e essa mensagem está sendo executada no meu construtor vazio");
            EuSouUmaPropriedadePublicDaClasse = 500;
        }

        public EuSouUmaClasse(string mensagem)
        {
            Console.WriteLine(mensagem);
            EuSouUmaPropriedadePublicDaClasse = 650;
        }

        public int EuSouUmaPropriedadePublicDaClasse { get; set; }
        private int EuSouUmaPropriedadePrivadaDaClasse { get; set; }

        public int EuSouUmMetodoInteiro ()
        {
            return 20;
        }

        public string EuSouUmMetodoString()
        {
            return "Eu sou uma string";
        }

        public void EuSouUmMetodoQueNaoRetornaNada()
        {
            Console.WriteLine("Não retornei nada");
        }

    }
}
