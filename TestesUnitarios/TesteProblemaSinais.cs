using Dominio.Interfaces;
using ProblemaSinais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace TestesUnitarios
{
    public class TesteProblemaSinais
    {
        private readonly ISinais _sinais;

        public TesteProblemaSinais()
        {
            _sinais = new Sinais();
        }

        [Fact]
        public void ValidarSinais_RetornaValor_True()
        {
            string[] valor = new string[3];
            valor[0] = "{[()]}";
            valor[1] = "{[(])}";
            valor[2] = "{{[[(())]]}}";
            var resultado = _sinais.ValidarSinais(valor);

            Assert.True(resultado.Count() > 0);
        }

        [Fact]
        public void ValidarSinais_PrimeiroExemplo_True()
        {
            string[] valor = new string[1];
            valor[0] = "{[()]}";
            var lista = _sinais.ValidarSinais(valor);

            var resultado = lista.FirstOrDefault();

            Assert.True(resultado.Balanceado);
        }

        [Fact]
        public void ValidarSinais_SegundoExemplo_False()
        {
            string[] valor = new string[1];
            valor[0] = "{[(])}";
            var lista = _sinais.ValidarSinais(valor);

            var resultado = lista.FirstOrDefault();

            Assert.False(resultado.Balanceado);
        }

        [Fact]
        public void ValidarSinais_TerceiroExemplo_True()
        {
            string[] valor = new string[1];
            valor[0] = "{{[[(())]]}}";
            var lista = _sinais.ValidarSinais(valor);

            var resultado = lista.FirstOrDefault();

            Assert.True(resultado.Balanceado);
        }
    }
}
