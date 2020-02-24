using MyLearnings.Entidades;
using MyLearnings.Entidades.Entidades;
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

       public ResumoAcessoADados()
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
                                          VALUES (@IDCICLORESUMO, @ASSUNTO, 
                                          @SUBASSUNTO, @RESUMO); 
                                          SELECT @@IDENTITY;";
                    cmd.Parameters.AddWithValue("@IDCILORESUMO", resumo.IdCicloResumo);
                    cmd.Parameters.AddWithValue("@ASSUNTO", resumo.Assunto);
                    cmd.Parameters.AddWithValue("@SUBASSUNTO", resumo.Subassunto);
                    cmd.Parameters.AddWithValue("@RESUMO", resumo.Texto);                 
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
                    cmd.CommandText = "DELETE FROM TB_RESUMO WHERE ID = @ID";
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

        public int Alterar(Resumo resumo)
        {
            SqlCommand cmd = new SqlCommand();
            using (cmd.Connection = _conexao.ObjetoDaConexao)
            {
                try
                {
                    _conexao.Conectar();
                    cmd.CommandText = @"UPDATE TB_RESUMO SET
                                        ASSUNTO = @ASSUNTO, 
                                        SUBASSUNTO = @SUBASSUNTO, 
                                        RESUMO = @RESUMO,                                         
                                        WHERE ID = @ID";
                    cmd.Parameters.AddWithValue("@ASSUNTO", resumo.Assunto);
                    cmd.Parameters.AddWithValue("@SUBASSUNTO", resumo.Subassunto);
                    cmd.Parameters.AddWithValue("@RESUMO", resumo.Texto);                 
                    cmd.Parameters.AddWithValue("@ID", resumo.Id);

                    var resultado = cmd.ExecuteNonQuery();

                    return resultado;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    _conexao.Desconectar();
                }
            }
        }
    }
}
