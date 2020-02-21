using MyLearnings.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnings.AcessoADados.AcessoEntidades
{
    public class ResumoAcessoADados
    {
        private Conexao _conexao;

        ResumoAcessoADados()
        {
            this._conexao = new Conexao();
        }

        public int Incluir(Resumo resumo)
        {
            SqlCommand cmd = new SqlCommand();
            using (cmd.Connection = _conexao.ObjetoDaConexao)
            {
                try
                {
                    _conexao.Conectar();
                    cmd.CommandText = @"INSERT TB_RESUMO (ID_CICLO_RESUMO, ASSUNTO, 
                                          SUBASSUNTO, RESUMO) 
                                          VALUES (@ID_CICLO_RESUMO, @ASSUNTO, 
                                          @SUBASSUNTO, @RESUMO); 
                                          SELECT @@IDENTITY;";
                    cmd.Parameters.AddWithValue("@ID_CILO_RESUMO", resumo.IdCicloResumo);
                    cmd.Parameters.AddWithValue("@ASSUNTO", resumo.Assunto);
                    cmd.Parameters.AddWithValue("@SUBASSUNTO", resumo.Subassunto);
                    cmd.Parameters.AddWithValue("@RESUMO", resumo.Resumos);                 
                    resumo.Id = Convert.ToInt32(cmd.ExecuteScalar());
                    return resumo.Id;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    _conexao.Desconectar();
                }
            }
        }

        public void Excluir(int id)
        {
            SqlCommand cmd = new SqlCommand();
            using (cmd.Connection = _conexao.ObjetoDaConexao)
            {
                try
                {
                    _conexao.Conectar();
                    cmd.CommandText = "DELETE FROM TB_REUMO WHERE ID = @ID";
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    _conexao.Desconectar();
                }
            }
        }
    }
}
