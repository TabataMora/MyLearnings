using MyLearnings.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnings.AcessoADados.AcessoEntidades
{
    public class CicloAcessoADados
    {
        private Conexao _conexao;

        public CicloAcessoADados()
        {
            this._conexao = new Conexao();
        }

        public int Incluir(Ciclo ciclo)
        {
            SqlCommand cmd = new SqlCommand();
            using (cmd.Connection = _conexao.ObjetoDaConexao)
            {
                try
                {
                    _conexao.Conectar();
                    cmd.CommandText = @"INSERT TB_CICLO(ID_TECNICA, ID_USUARIO, 
                                          INICIO, STATUS_CICLO) 
                                          VALUES (@IDTECNICA, @IDUSUARIO, 
                                          @INICIO, @STATUS);
                                          SELECT @@IDENTITY;";
                    cmd.Parameters.AddWithValue("@IDTECNICA", ciclo.IdTecnica);
                    cmd.Parameters.AddWithValue("@IDUSUARIO", ciclo.IdUsuario);
                    cmd.Parameters.AddWithValue("@INICIO", ciclo.Inicio);
                    cmd.Parameters.AddWithValue("@STATUS", ciclo.StatusCiclo);
                    ciclo.Id = Convert.ToInt32(cmd.ExecuteScalar());
                    return ciclo.Id;
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
                    cmd.CommandText = "DELETE FROM TB_CICLO WHERE ID = @ID";
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
