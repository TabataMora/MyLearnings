using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLearnings.AcessoADados.AcessoEntidades;
using MyLearnings.Entidades.Auxiliares;
using MyLearnings.Entidades.Entidades;

namespace MyLearnings.RegrasDeNegocio.RegrasDeNegocio
{
    public class TecnicaRegrasDeNegocio
    {
        public int Incluir(Tecnica tecnica)
        {
            try
            {
                if (tecnica.Nome.Trim().Length <= 0)
                {
                    throw new Exception("O nome da técnica precisa ser informado!");
                }
                if (tecnica.TempoCiclo <= 0)
                {
                    throw new Exception("O tempo do ciclo precisa ser informado!");
                }
                if (tecnica.DescCurto <= 0)
                {
                    throw new Exception("O tempo do descanso curto precisa ser informado!");
                }
                if (tecnica.DescLongo <= 0)
                {
                    throw new Exception("O tempo do descanso longo precisa ser informado!");
                }
                if (tecnica.DataCadastro == null)
                {
                    throw new Exception("A data do cadastro precisa ser informada!");
                }

               TecnicaAcessoADados tecnicaAcessoADados = new TecnicaAcessoADados();
               return tecnicaAcessoADados.Incluir(tecnica);            
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Alterar(Tecnica tecnica)
        {
            try
            {
                if (tecnica.Nome.Trim().Length <= 0)
                {
                    throw new Exception("O nome da técnica precisa ser informado!");
                }
                if (tecnica.TempoCiclo <= 0)
                {
                    throw new Exception("O tempo do ciclo precisa ser informado!");
                }
                if (tecnica.DescCurto <= 0)
                {
                    throw new Exception("O tempo do descanso curto precisa ser informado!");
                }
                if (tecnica.DescLongo <= 0)
                {
                    throw new Exception("O tempo do descanso longo precisa ser informado!");
                }
                if (tecnica.DataCadastro == null)
                {
                    throw new Exception("A data do cadastro precisa ser informada!");
                }              

                TecnicaAcessoADados tecnicaAcessoADados = new TecnicaAcessoADados();
                return tecnicaAcessoADados.Alterar(tecnica);
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
                TecnicaAcessoADados tecnicaAcesso = new TecnicaAcessoADados();
                tecnicaAcesso.Excluir(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Tecnica> BuscarTecnica(Tecnica tecnica)
        {
            return new TecnicaAcessoADados().BuscarTecnica(tecnica);
        }

        //public Tecnica BuscaTecnicaPorId(int id)
        //{
        //    TecnicaAcessoADados tecnicaAcesso = new TecnicaAcessoADados();
        //    Tecnica tecnica = tecnicaAcesso.BuscaTecnicaId(id);
        //    return tecnica;
        //}
    }
}
