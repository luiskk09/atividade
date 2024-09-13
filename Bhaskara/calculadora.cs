namespace Bhaskara
{
    public class Calculadora
    {
        public static (double? raiz1, double? raiz2) CalcularRaizes(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new ArgumentException("O coeficiente 'a' não pode ser zero em uma equação quadrática.");
            }

            double delta = (b * b) - (4 * a * c);

            if (delta < 0)
            {
                return (null, null);
            }

            double raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);

            if (delta == 0)
            {
                return (raiz1, null);
            }

            double raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);

            return (raiz1, raiz2);
        }
    }
}