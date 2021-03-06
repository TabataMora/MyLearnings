﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLearnings.Entidades.Entidades;

namespace MyLearnings.AcessoADados.AcessoEntidades
{
    public class TecnicaAcessoADados
    {
        private Conexao _conexao;

        public TecnicaAcessoADados()
        {
            this._conexao = new Conexao();
        }

        public int Incluir(Tecnica tecnica)
        {
            SqlCommand cmd = new SqlCommand();
            using (cmd.Connection = _conexao.ObjetoDaConexao)
            {
                try
                {
                    _conexao.Conectar();
                    cmd.CommandText = @"INSERT TB_TECNICA (NOME, PADRAO, 
                                          TEMPO_CICLO, DESC_CURTO, 
                                          DESC_LONGO, ID_USUARIO_CADASTRO,
                                          DATA_CADASTRO) 
                                          VALUES (@NOME, @PADRAO, 
                                          @TEMPO, @DESCURTO, 
                                          @DESCLONGO, @IDCADASTRO, GETDATE()); 
                                          SELECT @@IDENTITY;";
                    cmd.Parameters.AddWithValue("@NOME", tecnica.Nome);
                    cmd.Parameters.AddWithValue("@PADRAO", tecnica.Padrao);
                    cmd.Parameters.AddWithValue("@TEMPO", tecnica.TempoCiclo);
                    cmd.Parameters.AddWithValue("@DESCURTO", tecnica.DescCurto);
                    cmd.Parameters.AddWithValue("@DESCLONGO", tecnica.DescLongo);
                    cmd.Parameters.AddWithValue("@IDCADASTRO", tecnica.IdUsuarioCadastro);
                    tecnica.Id = Convert.ToInt32(cmd.ExecuteScalar());
                    return tecnica.Id;
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
                    cmd.CommandText = "DELETE FROM TB_TECNICA WHERE ID = @ID";
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

        public List<Tecnica> BuscarTecnica(Tecnica tecnica)
        {
            string query = string.Empty;
            List<Tecnica> retorno = new List<Tecnica>();
            SqlCommand cmd = new SqlCommand();
            using (cmd.Connection = _conexao.ObjetoDaConexao)
            {
                try
                {
                    _conexao.Conectar();

                    query = "SELECT* FROM TB_TECNICA WHERE ID > 0 ";

                    if (!string.IsNullOrWhiteSpace(tecnica?.Nome))
                    {
                        query += " AND NOME LIKE '%" + tecnica.Nome + "%';";
                    }
                    if (tecnica?.Id > 0)
                    {
                        query += " AND ID LIKE '%" + tecnica.Id + "%';";
                    }
                
                    cmd.CommandText = query;

                    using (cmd)
                    {
                        using (DbDataReader dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                Tecnica tecnicaRetorno = new Tecnica();
                                tecnicaRetorno.Id = Convert.ToInt32(dataReader["ID"].ToString());
                                tecnicaRetorno.Nome = dataReader["NOME"].ToString();
                                tecnicaRetorno.IdUsuarioCadastro = Convert.ToInt32(dataReader["ID_USUARIO_CADASTRO"].ToString());
                                tecnicaRetorno.TempoCiclo = Convert.ToInt32(dataReader["TEMPO_CICLO"].ToString());
                                tecnicaRetorno.DescCurto = Convert.ToInt32(dataReader["DESC_CURTO"].ToString());
                                tecnicaRetorno.DescLongo = Convert.ToInt32(dataReader["DESC_LONGO"].ToString());
                                tecnicaRetorno.DataCadastro = Convert.ToDateTime(dataReader["DATA_CADASTRO"].ToString());

                                if (dataReader["ID_USUARIO_ALTERACAO"].ToString() != string.Empty)
                                {
                                    tecnicaRetorno.IdUsuarioAlteracao = Convert.ToInt32(dataReader["ID_USUARIO_ALTERACAO"].ToString());
                                }
                                if (dataReader["DATA_ALTERACAO"].ToString() != string.Empty)
                                {
                                    tecnicaRetorno.DataAlteracao = Convert.ToDateTime(dataReader["DATA_ALTERACAO"].ToString());
                                }
                                if (dataReader["PADRAO"].ToString() != string.Empty)
                                {
                                    tecnicaRetorno.Padrao = dataReader["PADRAO"].ToString();
                                }
                                retorno.Add(tecnicaRetorno);
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

        public int Alterar(Tecnica tecnica)
        {
            SqlCommand cmd = new SqlCommand();
            using (cmd.Connection = _conexao.ObjetoDaConexao)
            {
                try
                {
                    _conexao.Conectar();
                    cmd.CommandText = @"UPDATE TB_TECNICA SET
                                        NOME = @NOME, 
                                        PADRAO = @PADRAO, 
                                        TEMPO_CICLO = @TEMPO, 
                                        DESC_CURTO = @DESCURTO, 
                                        DESC_LONGO = @DESCLONGO, 
                                        DATA_ALTERACAO = GETDATE(), 
                                        ID_USUARIO_ALTERACAO = @IDALTERACAO
                                        WHERE ID = @ID";
                    cmd.Parameters.AddWithValue("@NOME", tecnica.Nome);
                    cmd.Parameters.AddWithValue("@PADRAO", tecnica.Padrao);
                    cmd.Parameters.AddWithValue("@TEMPO", tecnica.TempoCiclo);
                    cmd.Parameters.AddWithValue("@DESCURTO", tecnica.DescCurto);
                    cmd.Parameters.AddWithValue("@DESCLONGO", tecnica.DescLongo);
                    cmd.Parameters.AddWithValue("@IDALTERACAO", tecnica.IdUsuarioAlteracao);
                    cmd.Parameters.AddWithValue("@ID", tecnica.Id);

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


