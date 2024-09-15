var rect = new Rectangle();
rect.Base = 20;
rect.Altura = 40;
Console.WriteLine($"Rectangulo");
Console.WriteLine($"El área es: {rect.Area()}");  
Console.WriteLine($"El perímetro es: {rect.Perimetro()}");  
Console.ReadLine();

var cuadr = new Cuadrado();
cuadr.Lado = 20;  
Console.WriteLine($"Cuadrado");
Console.WriteLine($"El área es: {cuadr.Area()}");  
Console.WriteLine($"El perímetro es: {cuadr.Perimetro()}");
Console.WriteLine($"El lado del cuadrado es: {cuadr.Lado}");
class Rectangle
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public double Area() => Base * Altura;
    public double Perimetro() => 2 * Base + 2 * Altura;
}

class Cuadrado : Rectangle
{
    public double Lado
    {
        set { Base = value; Altura = value; }
        get { return Base; }
    }
}