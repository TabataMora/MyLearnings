using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnings.AcessoADados
{
    public class Conexao
    {
        private SqlConnection _conexao;

        public Conexao()
        {
            _conexao = new SqlConnection();
            _conexao.ConnectionString = ConfiguraConexao.StringConexao();
        }

        public SqlConnection ObjetoDaConexao
        {
            get
            {
                return this._conexao;
            }

            set
            {
                this._conexao = value;
            }
        }

        public void Conectar()
        {
            this._conexao.Open();
        }

        public void Desconectar()
        {
            this._conexao.Close();
        }
    }
}
