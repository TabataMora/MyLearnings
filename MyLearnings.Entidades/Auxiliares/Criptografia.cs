using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnings.Entidades.Auxiliares
{
    public class Criptografia
    {
        private HashAlgorithm _algoritmo;

        public Criptografia()
        {
            _algoritmo = SHA512.Create();
        }

        public string CriptografarSenha(string senha)
        {
            var encodedValue = Encoding.UTF8.GetBytes(senha);
            var encryptedPassword = _algoritmo.ComputeHash(encodedValue);

            var sb = new StringBuilder();
            foreach (var caracter in encryptedPassword)
            {
                sb.Append(caracter.ToString("X2"));
            }
            string senhaCriptografada = sb.ToString();
            return senhaCriptografada;
        }

        public bool VerificarSenha(string senhaDigitada, string senhaCadastrada)
        {
            if (string.IsNullOrEmpty(senhaCadastrada))
                throw new NullReferenceException("Senha ou/e usuário inválido(s)!");

            var encryptedPassword = _algoritmo.ComputeHash(Encoding.UTF8.GetBytes(senhaDigitada));

            var sb = new StringBuilder();
            foreach (var caractere in encryptedPassword)
            {
                sb.Append(caractere.ToString("X2"));
            }

            var senha = sb.ToString();
            return senha == senhaCadastrada;
        }
    }
}

