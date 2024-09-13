using Bhaskara; 

namespace calculadorateste
{
    public class calculadorateste

    {
        [Fact]
        public void Calcular_DuasRaizesReais()
        {
           
            double a = 1;
            double b = -3;
            double c = 2;

            var (raiz1, raiz2) = Calculadora.CalcularRaizes(a, b, c);

            Assert.NotNull(raiz1);
            Assert.NotNull(raiz2);
            Assert.Equal(2.0, raiz1.Value, precision: 1e-10);
            Assert.Equal(1.0, raiz2.Value, precision: 1e-10);
        }

        [Fact]
        public void Calcular_UmaRaizReal()
        {
            double a = 1;
            double b = -2;
            double c = 1;

            var (raiz1, raiz2) = Calculadora.CalcularRaizes(a, b, c);

            Assert.NotNull(raiz1);
            Assert.Null(raiz2);
            Assert.Equal(1.0, raiz1.Value, precision: 1e-10);
        }

        [Fact]
        public void Calcular_SemRaizReal()
        {
            double a = 1;
            double b = 1;
            double c = 1;

            var (raiz1, raiz2) = Calculadora.CalcularRaizes(a, b, c);

            Assert.Null(raiz1);
            Assert.Null(raiz2);
        }

        [Fact]
        public void Calcular_EquacaoInvalida()
        {
            double a = 0;
            double b = 2;
            double c = 1;

            Assert.Throws<ArgumentException>(() => Calculadora
