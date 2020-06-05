using Dominio.Entities;
using Dominio.Interfaces;
using System.Collections;
using System.Linq;

namespace SalveRian
{
    public class Soldados : ISoldados
    {
        public DadosSoldados VerificarSoldadoSobrevivente(int quantidade)
        {
            try
            {
                var soldados = new DadosSoldados()
                {
                    Quantidade = quantidade
                };

                var array = ConverterInteiro(soldados.Quantidade);

                int i = 0;

                while (array.Count() > 1)
                {
                    if (i == (array.Count() - 1))
                        i = 0;
                    else if (i > (array.Count() - 1))
                        i = 1;
                    else
                        i++;

                    array = array.Where(x => x != array[i]).ToArray();
                }

                soldados.PosicaoSobrevivente = array[0];

                return soldados;
            }
            catch
            {
                return new DadosSoldados();
            }
        }

        private int[] ConverterInteiro(int inteiro)
        {
            int[] array = new int[inteiro];

            for (int i = 1; i <= inteiro; i++)
            {
                array[i - 1] = i;
            }

            return array;
        }
    }
}
