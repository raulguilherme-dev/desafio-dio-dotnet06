using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Validacoes.Services
{
    public class ValidacoesString
    {
        public int RetornarQuantidadeCaracteres(String texto) {
            return texto.Length;
        }

        public bool ContemCaractere(string texto, string trecho) {
            return texto.Contains(trecho);
        }

        public bool TextoTerminaCom(string texto, string trecho) {
            return texto.EndsWith(trecho);
        }
    }
}