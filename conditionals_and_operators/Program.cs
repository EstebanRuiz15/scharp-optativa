namespace conditionals
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("write a number");
           int num=int.Parse(Console.ReadLine());
           if(num>0) Console.WriteLine("the number is positive");
           else if(num<0) Console.WriteLine("the number is negative");
           else Console.WriteLine("the number zero");
           Console.ReadLine();

            Console.WriteLine("write the first number");
           double num1=double.Parse(Console.ReadLine());
           Console.WriteLine("write the second number");
           double num2=double.Parse(Console.ReadLine());

            Console.WriteLine($"suma= {num1+num2}, rest= {num1-num2}, multiplication= {num1*num2}, division= {(num2!=0 ? num1/num2 : "Indeterminado" )}");

        }
    }
}