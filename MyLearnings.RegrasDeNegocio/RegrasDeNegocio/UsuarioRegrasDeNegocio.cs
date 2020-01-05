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
                if (usuario.Nome.Trim().Length <= 3)
                {
                    throw new Exception("O nome do usuário precisa ser maior!");
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

            UsuarioAcessoADados usuarioAcessoADados = new UsuarioAcessoADados();

            Usuario usuario = usuarioAcessoADados.ObterUsuario(email);

            Criptografia criptografia = new Criptografia();

            // senhaCriptografada = criptografia.CriptografarSenha(senha);

            validado = criptografia.VerificarSenha(senha, usuario.Senha);
            
            return true;
            
        }
    }
}
