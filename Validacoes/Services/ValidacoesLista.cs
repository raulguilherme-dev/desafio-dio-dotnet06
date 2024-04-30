using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Validacoes.Services
{
    public class ValidacoesLista
    {
        public int[] RemoverNumerosNegativos(int[] lista) {
            return lista.Where(x => x >= 0).ToArray();
        }

        public bool ListaContemDeterminadoNumero(int[] lista, int numero) {
            return lista.Contains(numero);
        }

        public int[] MultiplicarNumerosLista(int[] lista, int numero) {
            return lista.Select(x => x * numero).ToArray();
        }

        public int RetornarMaiorNumeroLista(int[] lista) {
            return lista.Max();
        }

        public int RetornarMenorNumeroLista(int[] lista) {
            return lista.Min();
        }


    }
}