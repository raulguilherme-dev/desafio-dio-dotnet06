using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Validacoes.Services;
using Xunit;

namespace ValidacoesTestes
{
    public class ValidacoesStringTests {

        ValidacoesString validacoesString = new ValidacoesString();

        [Fact]
        public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix() {
            
            string texto = "Matrix";
            int resultado = validacoesString.RetornarQuantidadeCaracteres(texto);
            Assert.Equal(6, resultado);
        }

        [Fact]
        public void DeveConterAPalavraQualquerNoTexto() {
            string texto = "Esse é um texto qualquer";
            bool resultado = validacoesString.ContemCaractere(texto, "qualquer");
            Assert.True(resultado);
        }

        [Fact]
        public void NaoDeveConterAPalavraTesteNoTexto() {
            string texto = "Esse é um texto qualquer";
            bool resultado = validacoesString.ContemCaractere(texto, "teste");
            Assert.False(resultado);
        }

        [Fact]
        public void TextoDeveTerminarComAPalavraProcurado() {
            string texto = "Começo, meio e fim do texto procurado";
            bool resultado = validacoesString.ContemCaractere(texto, "procurado");
            Assert.True(resultado);
        }
    }
}