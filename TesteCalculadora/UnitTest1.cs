using Calculadora;
using System;
using Xunit;

namespace TesteCalculadora
{
    public class UnitTest1
    {

        public Calculator construirClasse()
        {
            string data = "02/02/2020";
            Calculator calc = new Calculator(data);
            return calc;
        }

        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData (4, 5, 9)]
        public void TesteSomar(int val1, int val2, int res)
        {
            Calculator calc = construirClasse();

            int resultado = calc.Somar(val1, val2);

            Assert.Equal(res, resultado);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(7, 5, 2)]
        public void TesteSubtrair(int val1, int val2, int res)
        {
            Calculator calc = construirClasse();

            int resultado = calc.Subtrair(val1, val2);

            Assert.Equal(res, resultado);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int res)
        {
            Calculator calc = construirClasse();

            int resultado = calc.Multiplicar(val1, val2);

            Assert.Equal(res, resultado);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(10, 5, 2)]
        public void TesteDividir(int val1, int val2, int res)
        {
            Calculator calc = construirClasse();

            int resultado = calc.Dividir(val1, val2);

            Assert.Equal(res, resultado);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculator calc = construirClasse();

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculator calc = construirClasse();

            calc.Somar(1, 2);
            calc.Somar(2, 8);
            calc.Somar(3, 7);
            calc.Somar(4, 1);

            var lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }

    }
}
