using MyLearnings.Entidades.Entidades;
using System;
using System.Collections.Generic;
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
                    cmd.CommandText = "INSERT TB_USUARIO(NOME, SENHA, EMAIL) VALUES(@NOME, @SENHA, @EMAIL); SELECT @@IDENTITY;";
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
    }
}
