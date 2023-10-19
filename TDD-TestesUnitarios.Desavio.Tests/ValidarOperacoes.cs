using TDD_TestesUnitarios.Desavio.Console.Services;
using Xunit;

namespace TDD_TestesUnitarios.Desavio.Tests
{

    public class ValidarOperacoes
    {
        private Operacoes _operacoes = new Operacoes();

        [Fact]
        public void DeveRetornarSomaDe2Valores()
        {
            // Arrange
            int valor1 = 2;
            int valor2 = 53;
            int resultadoEsperado = 55;

            // Act
            var resultado = _operacoes.Somar(valor1, valor2);
        
            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DeveRetornarErroNaSomaDe2Valores()
        {
            // Arrange
            int valor1 = 2;
            int valor2 = 53;
            int resultadoEsperado = 56;

            // Act
            var resultado = _operacoes.Somar(valor1, valor2);
        
            // Assert
            Assert.NotEqual(resultadoEsperado, resultado);
        }
        


        [Fact]
        public void DeveRetornarSubtracaoDe2Valores()
        {
            // Arrange
            int valor1 = 20;
            int valor2 = 25;
            int resultadoEsperado = -5;

            // Act
            var resultado = _operacoes.Subtrair(valor1, valor2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }


        [Fact]
        public void DeveRetornarMultiplicacaoDe2Valores()
        {
            // Arrange
            int valor1 = 12;
            int valor2 = 7;
            int resultadoEsperado = 84;

            // Act
            var resultado = _operacoes.Multiplicar(valor1, valor2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }


        [Theory]
        [InlineData(3, 2, 6)]
        [InlineData(21, 2, 42)]
        public void DeveRetornarMultiplicacaoDe2ValoresTheory(int valor1, int valor2, int resultadoEsperado)
        {
            //// Arrange
            //int valor1 = 12;
            //int valor2 = 7;
            //int resultadoEsperado = 84;

            // Act
            var resultado = _operacoes.Multiplicar(valor1, valor2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }


        [Fact]
        public void DeveRetornarDivisaoDoPrimeiroPeloSegundoValor()
        {
            // Arrange
            int valor1 = 93;
            int valor2 = 3;
            int resultadoEsperado = 31;

            // Act
            var resultado = _operacoes.Dividir(valor1, valor2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }


        [Fact]
        public void DeveRetornarRetornarHistoricoDeOperacoes()
        {
            // Arrange
            int valor1 = 93;
            int valor2 = 3;
            int resultadoEsperado1 = 96;
            int resultadoEsperado2 = 90;
            int resultadoEsperado3 = 279;
            int resultadoEsperado4 = 31;

            // Act
            var resultado1 = _operacoes.Somar(valor1, valor2);
            var resultado2 = _operacoes.Subtrair(valor1, valor2);
            var resultado3 = _operacoes.Multiplicar(valor1, valor2);
            var resultado4 = _operacoes.Dividir(valor1, valor2);
            var resLista = _operacoes.RetornarHistorico();

            // Assert
            Assert.Equal(resultadoEsperado1, resultado1);
            Assert.Equal(resultadoEsperado2, resultado2);
            Assert.Equal(resultadoEsperado3, resultado3);
            Assert.Equal(resultadoEsperado4, resultado4);
            Assert.NotEmpty(resLista);
            Assert.True(resLista.Count() > 0);
            Assert.False(resLista.Count() <= 0);
        }
    }
}