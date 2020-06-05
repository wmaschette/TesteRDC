using Dominio.Interfaces;
using SalveRian;
using Xunit;

namespace TestesUnitarios
{
    public class TesteSalveRian
    {
        private readonly ISoldados _soldados;

        public TesteSalveRian()
        {
            _soldados = new Soldados();
        }

        [Fact]
        public void VerificarSoldadoSobrevivente_41Soldados_Posicao19()
        {
            var resultado = _soldados.VerificarSoldadoSobrevivente(41);

            Assert.True(resultado.PosicaoSobrevivente == 19);
        }

        [Fact]
        public void VerificarSoldadoSobrevivente_5Soldados_Posicao3()
        {
            var resultado = _soldados.VerificarSoldadoSobrevivente(5);

            Assert.True(resultado.PosicaoSobrevivente == 3);
        }
    }
}
