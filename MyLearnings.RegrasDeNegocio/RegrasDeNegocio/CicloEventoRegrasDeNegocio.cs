using MyLearnings.AcessoADados;
using MyLearnings.AcessoADados.AcessoEntidades;
using MyLearnings.Entidades;
using MyLearnings.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnings.RegrasDeNegocio
{
    public class CicloEventoRegrasDeNegocio
    {
        public int Incluir(CicloEvento cicloEvento)
        {
            try
            {
                CicloEventoAcessoADados cicloAcessoADados = new CicloEventoAcessoADados();
                return cicloAcessoADados.Incluir(cicloEvento);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Alterar(CicloEvento cicloEvento)
        {
            try
            {            
                CicloEventoAcessoADados cicloAcessoADados = new CicloEventoAcessoADados();
                return cicloAcessoADados.Alterar(cicloEvento);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
