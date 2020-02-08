using MyLearnings.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnings.AcessoADados.AcessoEntidades
{
    public class UsuarioAcessoADados
    {
        private Conexao _conexao;

        public UsuarioAcessoADados()
        {
            this._conexao = new Conexao();
        }

        public int Incluir(Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand();
            using (cmd.Connection = _conexao.ObjetoDaConexao)
            {
                try
                {
                    _conexao.Conectar();
                    cmd.CommandText = "INSERT TB_USUARIO(NOME, SENHA, EMAIL) " +
                                       "VALUES(@NOME, @SENHA, @EMAIL); " +
                                       "SELECT @@IDENTITY;";
                    cmd.Parameters.AddWithValue("@NOME", usuario.Nome);
                    cmd.Parameters.AddWithValue("@SENHA", usuario.Senha);
                    cmd.Parameters.AddWithValue("@EMAIL", usuario.Email);
                    usuario.Id = Convert.ToInt32(cmd.ExecuteScalar());
                    return usuario.Id;
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

        public Usuario ObterUsuario(string email) //método para obter um usuário
        {
            Usuario retorno = new Usuario(); //instaciando criando uma variável do tipo usuario
            SqlCommand cmd = new SqlCommand();
            using (cmd.Connection = _conexao.ObjetoDaConexao) //usando a conexão e passando para o objetodaconexão
            {
                try
                {
                    _conexao.Conectar();
                    cmd.CommandText = "SELECT * FROM TB_USUARIO WHERE EMAIL = @EMAIL";
                    cmd.Parameters.AddWithValue("@EMAIL", email);
                    using (cmd) //usando o comando
                    {
                        using (DbDataReader dbReader = cmd.ExecuteReader())
                        {
                            while (dbReader.Read()) //se os campos não forem vazios atribui os valores para as variáveis e salva no banco de dados.
                            {
                                retorno.Id = Convert.ToInt32(dbReader["ID"]);
                                retorno.Senha = (dbReader["SENHA"].ToString());
                                retorno.Email = (dbReader["EMAIL"].ToString());
                                retorno.Nome = (dbReader["NOME"].ToString());
                            }
                        }
                    }
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
            return retorno;
        }

        public void Excluir(int id)
        {
            SqlCommand cmd = new SqlCommand();
            using (cmd.Connection = _conexao.ObjetoDaConexao)
            {
                try
                {
                    _conexao.Conectar();
                    cmd.CommandText = "DELETE FROM TB_USUARIO WHERE ID = @ID";
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

        public List<Usuario> BuscarUsuario(Usuario usuario)
        {
            string query = string.Empty;
            List<Usuario> retorno = new List<Usuario>();
            SqlCommand cmd = new SqlCommand();
            using (cmd.Connection = _conexao.ObjetoDaConexao)
            {
                try
                {
                    _conexao.Conectar();

                    if (usuario.Nome.Trim().Length == 0)
                    {
                        query = "SELECT * FROM TB_USUARIO";
                    }
                    else
                    {
                        query = ("SELECT * FROM TB_USUARIO WHERE NOME LIKE '%" + usuario.Nome + "%';");
                       
                    }

                    cmd.CommandText = query;

                    using (cmd)
                    {
                        using (DbDataReader dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                Usuario usuarioRetorno = new Usuario();
                                usuarioRetorno.Id = Convert.ToInt32(dataReader["ID"].ToString());
                                usuarioRetorno.Nome = dataReader["NOME"].ToString();
                                usuarioRetorno.Email = dataReader["EMAIL"].ToString();
                                usuarioRetorno.Senha = dataReader["SENHA"].ToString();
                                retorno.Add(usuarioRetorno);
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

        public void Alterar(Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand();
            using (cmd.Connection = _conexao.ObjetoDaConexao)
            {
                try
                {
                    _conexao.Conectar();
                    cmd.CommandText = "UPDATE TB_USUARIO SET " +
                                      "NOME = @NOME, " +
                                      "SENHA = @SENHA, " +
                                      "EMAIL = @EMAIL WHERE ID = @ID;";
                    cmd.Parameters.AddWithValue("@NOME", usuario.Nome);
                    cmd.Parameters.AddWithValue("@ID", usuario.Id);
                    cmd.Parameters.AddWithValue("@SENHA", usuario.Senha);
                    cmd.Parameters.AddWithValue("@EMAIL", usuario.Email);
                    cmd.ExecuteScalar();
                }            
                finally
                {
                    _conexao.Desconectar();
                }
            }
        }

        public Usuario BuscaUsuarioId(int id)
        {
            Usuario usuario = new Usuario();
            SqlCommand cmd = new SqlCommand();
            using (cmd.Connection = _conexao.ObjetoDaConexao)
            {
                try
                {
                    _conexao.Conectar();
                    cmd.CommandText = "SELECT NOME FROM TB_USUARIO WHERE ID = @ID";
                    cmd.Parameters.AddWithValue("@ID", id);
                    using (cmd)
                    {
                        using (DbDataReader dbReader = cmd.ExecuteReader())
                        {
                            while (dbReader.Read())
                            {
                                usuario.Nome = (dbReader["NOME"].ToString());
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    _conexao.Desconectar();
                }
                return usuario;
            }
        }
    }
}