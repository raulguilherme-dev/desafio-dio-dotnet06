using Validacoes.Services;

namespace validacoesTestes;

public class ValidacoesListaTests {

    ValidacoesLista validacoesLista = new ValidacoesLista();    

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        int[] lista = [1, 2, -3, 4, -5, 6, 7, -8, 9];
        int[] resultado = validacoesLista.RemoverNumerosNegativos(lista);
        Assert.Equal([1, 2, 4, 6, 7, 9], resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista() {
        int[] lista = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        bool resultado = validacoesLista.ListaContemDeterminadoNumero(lista, 9);
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista() {
        int[] lista = [1, 2, 3, 4, 5, 6, 7, 8, 9];
        bool resultado = validacoesLista.ListaContemDeterminadoNumero(lista, 10);
        Assert.False(resultado);
    }

    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2() {
        int[] lista = [1, 2, 3, 4, 5, 6, 7, 8, 9];
        int[] resultado = validacoesLista.MultiplicarNumerosLista(lista, 2);
        Assert.Equal([2, 4, 6, 8, 10, 12, 14, 16, 18], resultado);
    }

    [Fact]
    public void DeveRetorner9ComoOMaiorNumeroDaLista() {
        int[] lista = [1, 2, 3, 4, 5, 6, 7, 8, 9];
        int resultado = validacoesLista.RetornarMaiorNumeroLista(lista);
        Assert.Equal(9, resultado);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoOMenorNumeroDaLista() {
        int[] lista = [-8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
        int resultado = validacoesLista.RetornarMenorNumeroLista(lista);
        Assert.Equal(-8, resultado);
    }
}