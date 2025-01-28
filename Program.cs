using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Seleccione una opción: \n1. Triángulo \n2. Círculo \n3. Cuadrado \n4. Rectángulo");
        int opcion = int.Parse(Console.ReadLine());
        switch(opcion)
        {
            case 1:
                Console.WriteLine("Ingrese la medida del primer lado del triángulo");
                double lado1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la medida del segundo lado del triángulo");
                double lado2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la medida del tercer lado del triángulo");
                double lado3 = double.Parse(Console.ReadLine());
                Triangulo triangulo = new Triangulo(lado1, lado2, lado3);
                Console.WriteLine(triangulo.TipoTriangulo());
                Console.WriteLine(triangulo.TipoTrianguloRectangulo());
                break;
            case 2:
                Console.WriteLine("Ingrese el radio del círculo");
                double radio = double.Parse(Console.ReadLine());
                Circulo circulo = new Circulo(radio);
                Console.WriteLine("El área del círculo es: " + circulo.CalcularArea());
                Console.WriteLine("El perímetro del círculo es: " + circulo.CalcularPerimetro());
                break;
            case 3:
                Console.WriteLine("Ingrese la medida del lado del cuadrado");
                double lado = double.Parse(Console.ReadLine());
                Cuadrado cuadrado = new Cuadrado(lado);
                Console.WriteLine("El área del cuadrado es: " + cuadrado.CalcularArea());
                Console.WriteLine("El perímetro del cuadrado es: " + cuadrado.CalcularPerimetro());
                break;
            case 4:
                Console.WriteLine("Ingrese la medida del primer base del rectángulo");
                double base_ = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la medida del segundo altura del rectángulo");
                double altura = double.Parse(Console.ReadLine());
                Rectangulo rectangulo = new Rectangulo(base_, altura);
                Console.WriteLine("El área del rectángulo es: " + rectangulo.CalcularArea());
                Console.WriteLine("El perímetro del rectángulo es: " + rectangulo.CalcularPerimetro());
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        
    }
}

    public class Triangulo
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }

        public Triangulo(double lado1, double lado2, double lado3)
        {
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
        }
        public double CalcularPerimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }

        public double CalcularArea()
        {
            double semiperimetro = CalcularPerimetro() / 2;
            return Math.Sqrt(semiperimetro * (semiperimetro - Lado1) * (semiperimetro - Lado2) * (semiperimetro - Lado3)); //formula de Herón
        }
        public string TipoTriangulo()
        {
            if (Lado1 == Lado2 && Lado2 == Lado3)
            {
                return "El triángulo es equilátero";
            }
            else if (Lado1 == Lado2 || Lado1 == Lado3 || Lado2 == Lado3)
            {
                return "El triángulo es isósceles";
            }
            else
            {
                return "El triángulo es escaleno";
            }
        }

        public string TipoTrianguloRectangulo()
        {
            if ((Lado1 * Lado1 + Lado2 * Lado2 == Lado3 * Lado3) || (Lado1 * Lado1 + Lado3 * Lado3 == Lado2 * Lado2) || (Lado2 * Lado2 + Lado3 * Lado3 == Lado1 * Lado1))
            {
                return "El triángulo es rectángulo";
            }
            else
            {
                return "El triángulo no es rectángulo";
            }
        }
    }

    public class Circulo
    {
        public double Radio { get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }
    }

    public class Cuadrado
    {
        public double Lado { get; set; }

        public Cuadrado(double lado)
        {
            Lado = lado;
        }

        public double CalcularArea()
        {
            return Lado * Lado;
        }

        public double CalcularPerimetro()
        {
            return 4 * Lado;
        }
    }

    public class Rectangulo
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }

        public Rectangulo(double base_, double altura)
        {
            Lado1 = base_;
            Lado2 = altura;
        }

        public double CalcularArea()
        {
            return Lado1 * Lado2;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Lado1 + Lado2);
        }
    }
}