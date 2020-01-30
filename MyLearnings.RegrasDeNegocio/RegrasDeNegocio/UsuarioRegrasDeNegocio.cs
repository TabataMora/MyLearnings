using MyLearnings.AcessoADados.AcessoEntidades;
using MyLearnings.Entidades.Auxiliares;
using MyLearnings.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnings.RegrasDeNegocio.RegrasDeNegocio
{
    public class UsuarioRegrasDeNegocio
    {

        public int Incluir(Usuario usuario)
        {
            try
            {
                var senhaCri = "";

                senhaCri = new Criptografia().CriptografarSenha(usuario.Senha);

                usuario.Senha = senhaCri;

                if (usuario.Nome.Trim().Length <= 0)
                {
                    throw new Exception("O nome do usuário precisa ser informado!");
                }
                if (usuario.Email.Trim().Length <= 0)
                {
                    throw new Exception("O e-mail precisa ser informado!");
                }
                if (usuario.Senha.Trim().Length <= 0)
                {
                    throw new Exception("Uma senha precisa ser informada!");
                }
                else
                {
                    UsuarioAcessoADados usuarioAcessoADados = new UsuarioAcessoADados();
                    return usuarioAcessoADados.Incluir(usuario);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool ValidaUsuario(string email, string senha)
        {
            bool validado;

            try
            {
                UsuarioAcessoADados usuarioAcessoADados = new UsuarioAcessoADados(); //instanciando a classe para utilizar o método Usuario

                Usuario usuario = usuarioAcessoADados.ObterUsuario(email); //criando uma variável do tipo Usuário e passando o email para o UsuárioAcessoADados

                Criptografia criptografia = new Criptografia(); //instanciando a classe

                // senhaCriptografada = criptografia.CriptografarSenha(senha);

                validado = criptografia.VerificarSenha(senha, usuario.Senha); //validando a criptografia pegando a senha digitada e comparando com a senha salva no banco de dados.

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Alterar(Usuario usuario)/*int id, string nome*/
        {
            //Usuario usuario = new Usuario();

            var senhaCri = "";

            senhaCri = new Criptografia().CriptografarSenha(usuario.Senha);

            //usuario.Id = id;
            //usuario.Nome = nome;
            usuario.Senha = senhaCri;
            UsuarioAcessoADados usuarioAcesso = new UsuarioAcessoADados();
            usuarioAcesso.Alterar(usuario);
        }

        public void Excluir(int id)
        {
            try
            {
                UsuarioAcessoADados usuarioAcesso = new UsuarioAcessoADados();
                usuarioAcesso.Excluir(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Usuario> BuscarUsuario(Usuario IdUsuario)
        {
            return new UsuarioAcessoADados().BuscarUsuario(IdUsuario);
        }
        
        public Usuario BuscaUsuarioPorId(int id)
        {      
            UsuarioAcessoADados usuarioAcesso = new UsuarioAcessoADados();
            Usuario usuario = usuarioAcesso.BuscaUsuarioId(id);
            return usuario;
        }
    }
}
