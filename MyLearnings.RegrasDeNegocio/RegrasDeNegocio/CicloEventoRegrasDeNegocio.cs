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
                //if (ciclo.Nome.Trim().Length <= 0)
                //{
                //    throw new Exception("O nome da técnica precisa ser informado!");
                //}
                //if (ciclo.TempoCiclo <= 0)
                //{
                //    throw new Exception("O tempo do ciclo precisa ser informado!");
                //}
                //if (ciclo.DescCurto <= 0)
                //{
                //    throw new Exception("O tempo do descanso curto precisa ser informado!");
                //}
                //if (ciclo.DescLongo <= 0)
                //{
                //    throw new Exception("O tempo do descanso longo precisa ser informado!");
                //}
                //if (ciclo.DataCadastro == null)
                //{
                //    throw new Exception("A data do cadastro precisa ser informada!");
                //}
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
                //if (ciclo.Nome.Trim().Length <= 0)
                //{
                //    throw new Exception("O nome da técnica precisa ser informado!");
                //}
                //if (ciclo.TempoCiclo <= 0)
                //{
                //    throw new Exception("O tempo do ciclo precisa ser informado!");
                //}
                //if (ciclo.DescCurto <= 0)
                //{
                //    throw new Exception("O tempo do descanso curto precisa ser informado!");
                //}
                //if (ciclo.DescLongo <= 0)
                //{
                //    throw new Exception("O tempo do descanso longo precisa ser informado!");
                //}
                //if (ciclo.DataCadastro == null)
                //{
                //    throw new Exception("A data do cadastro precisa ser informada!");
                //}
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
