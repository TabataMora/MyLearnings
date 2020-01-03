using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace MyLearnings.AcessoADados
{
   public static class ConfiguraConexao
    {
        private static string Servidor;
        private static string Base;
        private static string Senha;
        private static string Usuario;
        //
        public static string StringConexao()
        {
            Servidor = ConfigurationManager.AppSettings["servidor"];
            Base = ConfigurationManager.AppSettings["base"];
            Usuario = ConfigurationManager.AppSettings["usuario"];
            Senha = ConfigurationManager.AppSettings["senha"];

            return @"Data Source=" + Servidor + ";Initial Catalog=" + Base + ";User ID=" + Usuario + ";Password=" + Senha;
        }

    }
}
