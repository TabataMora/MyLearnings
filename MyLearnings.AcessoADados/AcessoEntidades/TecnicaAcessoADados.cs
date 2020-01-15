using System;
using System.Collections.Generic;
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
            using(cmd.Connection = _conexao.ObjetoDaConexao)
            {
                try
                {
                    _conexao.Conectar();
                    cmd.CommandText = "INSERT NOME, PADRAO, TEMPO_CICLO, DESC_CURTO, DESC_LONGO, DATA_CADASTRO, ID_USUARIO_CADASTRO, " +
                        "DATA_ALTERACAO, ID_USUARIO_ALTERACAO " +
                        "VALUES (@NOME, @PADRAO, @TEMPO, @DESCURTO, @DESCLONGO, @DATACADASTRO, @IDCADASTRO, @DATALTERACAO, @IDALTERACAO); SELECT; @@IDENTITY;";
                    cmd.Parameters.AddWithValue("@NOME", tecnica.Nome);
                    cmd.Parameters.AddWithValue("@PADRAO", tecnica.Padrao);
                    cmd.Parameters.AddWithValue("@TEMPO", tecnica.TempoCiclo);
                    cmd.Parameters.AddWithValue("@DESCURTO", tecnica.DescCurto);
                    cmd.Parameters.AddWithValue("@DESCLONGO", tecnica.DescLongo);
                    cmd.Parameters.AddWithValue("@DATACADASTRO", tecnica.DataCadastro);
                    cmd.Parameters.AddWithValue("@IDCADASTRO", tecnica.IdUsuarioCadastro);
                    cmd.Parameters.AddWithValue("@DATALTERACAO", tecnica.DataAlteracao);
                    cmd.Parameters.AddWithValue("@IDALTERACAO", tecnica.IdUsuarioAlteracao);
                    tecnica.Id = Convert.ToInt32(cmd.ExecuteScalar());
                    return tecnica.Id;
                }
                catch(Exception)
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
