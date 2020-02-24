using MyLearnings.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnings.AcessoADados
{
    public class CicloEventoAcessoADados
    {
        private Conexao _conexao;

        public CicloEventoAcessoADados()
        {
            this._conexao = new Conexao();
        }

        public int Incluir(CicloEvento cicloEvento)
        {
            SqlCommand cmd = new SqlCommand();
            using (cmd.Connection = _conexao.ObjetoDaConexao)
            {
                try
                {
                    _conexao.Conectar();
                    cmd.CommandText = @"INSERT TB_CICLO_EVENTO(ID_CICLO, ID_EVENTO, 
                                          COMPLETO, INICIO) 
                                          VALUES (@IDCICLO, @IDEVENTO, 
                                           @COMPLETO, @INICIO);
                                          SELECT @@IDENTITY;";
                    cmd.Parameters.AddWithValue("@IDCICLO", cicloEvento.IdCiclo);
                    cmd.Parameters.AddWithValue("@IDEVENTO", cicloEvento.IdEvento);
                    cmd.Parameters.AddWithValue("@COMPLETO", cicloEvento.Completo);
                    cmd.Parameters.AddWithValue("@INICIO", cicloEvento.Inicio);
                    cicloEvento.Id = Convert.ToInt32(cmd.ExecuteScalar());
                    return cicloEvento.Id;
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

        public int Alterar(CicloEvento cicloEvento)
        {
            SqlCommand cmd = new SqlCommand();
            using (cmd.Connection = _conexao.ObjetoDaConexao)
            {
                try
                {
                    _conexao.Conectar();
                    cmd.CommandText = @"UPDATE TB_CICLO_EVENTO SET
                                        TERMINO = @TERMINOCICLOEVENTO,
                                        COMPLETO = @COMPLETO
                                        WHERE ID = @ID";
                    cmd.Parameters.AddWithValue("@TERMINOCICLOEVENTO", cicloEvento.Termino);
                    cmd.Parameters.AddWithValue("@COMPLETO", cicloEvento.Completo);
                    cmd.Parameters.AddWithValue("@ID", cicloEvento.Id);

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
