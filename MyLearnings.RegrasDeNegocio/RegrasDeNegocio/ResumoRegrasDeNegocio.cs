using MyLearnings.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLearnings.AcessoADados.AcessoEntidades;
using MyLearnings.Entidades.Entidades;

namespace MyLearnings.RegrasDeNegocio.RegrasDeNegocio
{
    public class ResumoRegrasDeNegocio
    {
        public int Incluir(Resumo resumo)
        {
            try
            {
                if (resumo.Assunto.Trim().Length <= 0)
                {
                    throw new Exception("O assunto precisa ser informado!");
                }
                if (resumo.Texto.Trim().Length <= 0)
                {
                    throw new Exception("O resumo precisa ser preenchido!");
                }

                ResumoAcessoADados resumoAcessoADados = new ResumoAcessoADados();
                return resumoAcessoADados.Incluir(resumo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Alterar(Resumo resumo)
        {
            try
            {
                if (resumo.Assunto.Trim().Length <= 0)
                {
                    throw new Exception("O assunto precisa ser informado!");
                }
                if (resumo.Texto.Trim().Length <= 0)
                {
                    throw new Exception("O resumo precisa ser preenchido!");
                }

                ResumoAcessoADados resumoAcessoADados = new ResumoAcessoADados();
                return resumoAcessoADados.Incluir(resumo);

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Excluir(int id)
        {
            try
            {
                ResumoAcessoADados resumoAcesso = new ResumoAcessoADados();
                resumoAcesso.Excluir(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
