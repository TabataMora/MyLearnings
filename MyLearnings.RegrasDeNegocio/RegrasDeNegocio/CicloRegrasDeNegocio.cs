using MyLearnings.AcessoADados.AcessoEntidades;
using MyLearnings.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnings.RegrasDeNegocio.RegrasDeNegocio
{
    public class CicloRegrasDeNegocio
    {
        public int Incluir(Ciclo ciclo)
        {
            try
            {             
                CicloAcessoADados cicloAcessoADados = new CicloAcessoADados();
                return cicloAcessoADados.Incluir(ciclo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //public int Alterar(Cil ciclo)
        //{
        //    try
        //    {
        //        CicloAcessoADados cicloAcessoADados = new CicloAcessoADados();
        //        return cicloAcessoADados.Alterar(ciclo);
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
    }
}
