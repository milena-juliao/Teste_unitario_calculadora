namespace Calculadora.Tests
{
    public class CalculadoraTest
    {
        [Fact]
        public void Somar()
        {
            Assert.Equal(20, Calculadora.Adicao(10, 10));
        }

        [Fact]
        public void Subtrair()
        {
            Assert.Equal(0, Calculadora.Subtracao(10, 10));
        }

        [Fact]
        public void Multiplicar()
        {
            Assert.Equal(100, Calculadora.Multiplicacao(10, 10));
        }

        [Fact]
        public void Dividir()
        {
            Assert.Equal(1, Calculadora.Divisao(10, 10));
        }
    }
}