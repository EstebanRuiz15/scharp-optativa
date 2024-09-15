namespace Polimorfismo
{

    public interface IFigura
    {
        public abstract double Area();
        public abstract double Perimetro();
    }


    public class Circulo : IFigura
    {
        public double Radio { get; set; }

        public double Area() => Math.PI * Radio * Radio;

        public double Perimetro() => 2 * Math.PI * Radio;
    }


    class Program
    {
        static void Main(string[] args)
        {
            var cir = new Circulo();
            cir.Radio = 20;

            var resultArea = cir.Area();
            var resultPerim = cir.Perimetro();

            Console.WriteLine($"El área del círculo es: {resultArea}, y el perímetro es: {resultPerim}");
            Console.ReadLine();

            int prev = 0, next = 1, sum;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(prev);
                sum = prev + next;
                prev = next;
                next = sum;
            }
            Console.ReadLine();

            try
            {
                Console.WriteLine("Escriba numero a dividir");
                double num = double.Parse(Console.ReadLine());
                Console.WriteLine("Escriba numero divisor");
                double numDivisor = double.Parse(Console.ReadLine());
                if (numDivisor == 0)
                {
                    throw new DivideByZeroException();
                }
                Console.WriteLine($"Resultado es: {num / numDivisor}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir por 0");
            }
            catch (Exception)
            {
                Console.WriteLine("Error desconocido");
            }
        }
    }
}