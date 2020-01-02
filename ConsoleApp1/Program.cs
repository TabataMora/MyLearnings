using MyLearnings.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            EuSouUmaClasse apelidoDaClasse = new EuSouUmaClasse();
            int EuSouUmaVariavelQueVouReceberORetornoDeUmMetodo;

            apelidoDaClasse.EuSouUmaPropriedadePublicDaClasse = 10;

            EuSouUmaVariavelQueVouReceberORetornoDeUmMetodo = apelidoDaClasse.EuSouUmMetodoInteiro();

            apelidoDaClasse.EuSouUmMetodoInteiro();
            //apelidoDaClasse.EuSouUmMetodoQueNaoRetornaNada();
            apelidoDaClasse.EuSouUmMetodoString();
            Console.Read();
        }
    }
}
