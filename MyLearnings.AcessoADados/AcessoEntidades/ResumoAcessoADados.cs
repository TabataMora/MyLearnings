using MyLearnings.Entidades;
using MyLearnings.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Common;
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
                    cmd.CommandText = @"INSERT TB_RESUMO(ASSUNTO, 
                                          SUBASSUNTO, RESUMO, ID_CICLO_RESUMO) 
                                          VALUES (@ASSUNTO, 
                                          @SUBASSUNTO, @RESUMO, @IDCICLORESUMO); 
                                          SELECT @@IDENTITY;";
                    cmd.Parameters.AddWithValue("@ASSUNTO", resumo.Assunto);
                    cmd.Parameters.AddWithValue("@SUBASSUNTO", resumo.Subassunto);
                    cmd.Parameters.AddWithValue("@RESUMO", resumo.Texto);
                    cmd.Parameters.AddWithValue("@IDCICLORESUMO", resumo.IdCicloResumo);
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

        public List<Resumo> BuscarResumo(Resumo resumo)
        {
            string query = string.Empty;
            List<Resumo> retorno = new List<Resumo>();
            SqlCommand cmd = new SqlCommand();
            using (cmd.Connection = _conexao.ObjetoDaConexao)
            {
                try
                {
                    _conexao.Conectar();

                    if (resumo.Assunto.Trim().Length == 0)
                    {
                        query = "SELECT * FROM TB_RESUMO";
                    }
                    else
                    {
                        query = ("SELECT ASSUNTO, ID, SUBASSUNTO, ID_CICLO_RESUMO, RESUMO" +
                            " FROM TB_RESUMO WHERE ASSUNTO LIKE '%" + resumo.Assunto + "%';");
                    }

                    cmd.CommandText = query;

                    using (cmd)
                    {
                        using (DbDataReader dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                Resumo resumoRetorno = new Resumo();
                                resumoRetorno.Id = Convert.ToInt32(dataReader["ID"].ToString());
                                resumoRetorno.Assunto = dataReader["ASSUNTO"].ToString();
                                   
                                if(dataReader["SUBASSUNTO"].ToString() != string.Empty)
                                {
                                    resumoRetorno.Subassunto = dataReader["SUBASSUNTO"].ToString();
                                }
                                if(dataReader["ID_CICLO_RESUMO"].ToString() != string.Empty)
                                {
                                    resumoRetorno.IdCicloResumo = Convert.ToInt32(dataReader["ID_CICLO_RESUMO"].ToString());
                                }
                                if (dataReader["RESUMO"].ToString() != string.Empty)
                                {
                                    resumoRetorno.Texto = dataReader["RESUMO"].ToString();
                                }
                                    retorno.Add(resumoRetorno);
                            }
                        }
                    }
                }
                finally 
                {
                    _conexao.Desconectar();
                }
            }
            return retorno;
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
                                          RESUMO = @RESUMO                                    
                                          WHERE ID = @ID
                                          SELECT @@IDENTITY;";
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
