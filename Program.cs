using System;
using System.Globalization;
using System.Timers;
class Program
{
    static void Main() 
    {
        Console.WriteLine("Seleccione una opción: \n1. Triángulo \n2. Círculo \n3. Cuadrado \n4. Rectángulo"); //Menú de opciones
        int opcion = int.Parse(Console.ReadLine()); //Variable para seleccionar la opción

        switch(opcion) //Switch para seleccionar la opción
        {
            case 1: //Si el usuario selecciona la opción 1
                double lado1;
                double lado2;
                double lado3;
                
                do //Realiza el procedimiento del lado1
                {
                    Console.WriteLine("Ingrese la medida del primer lado del triángulo"); //Pedimos al usuario la medida del primer lado del triángulo
                    lado1 = double.Parse(Console.ReadLine()); //Variable para almacenar la medida del primer lado del triángulo
                } 
                while (lado1 <= 0); //Si el lado es menor o igual a 0
                
                do //Realiza el procedimiento del lado2
                {
                    Console.WriteLine("Ingrese la medida del segundo lado del triángulo"); //Pedimos al usuario la medida del segundo lado del triángulo
                    lado2 = double.Parse(Console.ReadLine()); //Variable para almacenar la medida del segundo lado del triángulo
                }
                while (lado2 <= 0); //Si el lado es menor o igual a 0
                
                do //Realiza el procedimiento del lado3
                {
                    Console.WriteLine("Ingrese la medida del tercer lado del triángulo"); //Pedimos al usuario la medida del tercer lado del triángulo
                    lado3 = double.Parse(Console.ReadLine()); //Variable para almacenar la medida del tercer lado del triángulo
                }
                
                while (lado3 <= 0); //Si el lado es menor o igual a 0
                {
                    Triangulo triangulo = new Triangulo(lado1, lado2, lado3); //Creamos un objeto
                    Console.WriteLine("El perímetro del triángulo es: " + triangulo.CalcularPerimetro()); //Llamamos al método CalcularPerimetro                            Console.WriteLine("El área del triángulo es: " + triangulo.CalcularArea()); //Llamamos al método CalcularArea
                    Console.WriteLine("El área del triágulo es: " + triangulo.CalcularArea());
                    Console.WriteLine(triangulo.TipoTriangulo()); //Llamamos al método TipoTriangulo
                    Console.WriteLine(triangulo.TipoTrianguloRectangulo()); //Llamamos al método TipoTrianguloRectangulo
                }
            break; //Salimos del switch       

            case 2: //Si el usuario selecciona la opción 2
                double radio;

                do //Realiza el procedimiento del radio
                {
                    Console.WriteLine("Ingrese el radio del círculo"); //Pedimos al usuario el radio del círculo
                    radio = double.Parse(Console.ReadLine()); //Variable para almacenar el radio del círculo
                }
                while (radio <= 0); //Si el radio es menor o igual a 0
                {
                    Circulo circulo = new Circulo(radio); //Creamos un objeto
                    Console.WriteLine("El área del círculo es: " + circulo.CalcularArea()); //Llamamos al método CalcularArea
                    Console.WriteLine("El perímetro del círculo es: " + circulo.CalcularPerimetro()); //Llamamos al método CalcularPerimetro
                }
            break; //Salimos del switch

            case 3: //Si el usuario selecciona la opción 3
                double lado;

                do
                {
                    Console.WriteLine("Ingrese la medida del lado del cuadrado"); //Pedimos al usuario la medida del lado del cuadrado
                    lado = double.Parse(Console.ReadLine()); //Variable para almacenar la medida del lado del cuadrado
                }
                while (lado <= 0); //Si el lado es menor o igual a 0
                {
                    Cuadrado cuadrado = new Cuadrado(lado); //Creamos un objeto
                    Console.WriteLine("El área del cuadrado es: " + cuadrado.CalcularArea()); //Llamamos al método CalcularArea
                    Console.WriteLine("El perímetro del cuadrado es: " + cuadrado.CalcularPerimetro()); //Llamamos al método CalcularPerimetro
                }
            break; //Salimos del switch

            case 4: //Si el usuario selecciona la opción 4
                double base_;
                double altura;
                
                do
                {
                    Console.WriteLine("Ingrese la medida de la base del rectángulo"); //Pedimos al usuario la medida del primer base del rectángulo
                    base_ = double.Parse(Console.ReadLine()); //Variable para almacenar la medida de la base del rectángulo
                }
                while (base_ <= 0); //Si la base es menor o igual a 0
                
                do
                {
                    Console.WriteLine("Ingrese la medida de la altura del rectángulo"); //Pedimos al usuario la medida de la altura del rectángulo
                    altura = double.Parse(Console.ReadLine()); //Variable para almacenar la medida de la altura del rectángulo
                }
                while (altura <= 0); //Si la altura es menor o igual a 0
                {
                Rectangulo rectangulo = new Rectangulo(base_, altura); //Creamos un objeto
                Console.WriteLine("El área del rectángulo es: " + rectangulo.CalcularArea()); //Llamamos al método CalcularArea
                Console.WriteLine("El perímetro del rectángulo es: " + rectangulo.CalcularPerimetro()); //Llamamos al método CalcularPerimetro
                }
                break; //Salimos del switch
                
            default: //Si el usuario selecciona una opción no válida
                Console.WriteLine("Opción no válida"); //Mensaje de error
                break; //Salimos del switch
        }
        
        Console.WriteLine("¿Quiere calcular el área y perímetro de otra figura? si o no"); //Preguntamos al usuario si quiere calcular el área de otra figura
        string respuesta = Console.ReadLine().ToLower(); //Variable para almacenar la respuesta del usuario
        if (respuesta == "si") //Si la respuesta es si
        {
            Main(); //Llamamos al método Main
        }
    }

    public class Triangulo //Clase Triangulo
    {
        public double Lado1 { get; set; } //Propiedad para el primer lado del triángulo con get y set

        public double Lado2 { get; set; } //Propiedad para el segundo lado del triángulo con get y set

        public double Lado3 { get; set; } //Propiedad para el tercer lado del triángulo con get y set

        public Triangulo(double lado1, double lado2, double lado3) //Constructor
        {
            Lado1 = lado1; //Inicializamos la variable Lado1
            Lado2 = lado2; //Inicializamos la variable Lado2
            Lado3 = lado3; //Inicializamos la variable Lado3
        }

        public double CalcularPerimetro() //Método para calcular el perímetro
        {
            return Lado1 + Lado2 + Lado3; //Retornamos la suma de los lados
        }

        public double CalcularArea() //Método para calcular el área
        {
            double semiperimetro = CalcularPerimetro() / 2; //Calculamos el semiperímetro
            return Math.Sqrt(semiperimetro * (semiperimetro - Lado1) * (semiperimetro - Lado2) * (semiperimetro - Lado3)); //formula de Herón
        }

        public string TipoTriangulo() //Método para determinar el tipo de triángulo
        {
            if (Lado1 == Lado2 && Lado2 == Lado3) //Si los tres lados son iguales
            {
                return "El triángulo es equilátero"; //Retornamos que es equilátero
            }
            else if (Lado1 == Lado2 || Lado1 == Lado3 || Lado2 == Lado3) //Si dos lados son iguales
            {
                return "El triángulo es isósceles"; //Retornamos que es isósceles
            }
            else //Si no se cumple ninguna de las condiciones anteriores
            {
                return "El triángulo es escaleno"; //Retornamos que es escaleno
            }
        }


        public string TipoTrianguloRectangulo() //Método para determinar si el triángulo es rectángulo
        {
            if ((Lado1 * Lado1 + Lado2 * Lado2 == Lado3 * Lado3) || (Lado1 * Lado1 + Lado3 * Lado3 == Lado2 * Lado2) || (Lado2 * Lado2 + Lado3 * Lado3 == Lado1 * Lado1)) //Si se cumple el teorema de Pitágoras
            {
                return "El triángulo es rectángulo"; //Retornamos que es rectángulo
            }
            else //Si no se cumple la condición anterior
            {
                return "El triángulo no es rectángulo"; //Retornamos que no es rectángulo
            }
        }
    }

    public class Circulo //Clase Circulo
    {
        public double Radio { get; set; } //Propiedad para el radio del círculo con get y set


        public Circulo(double radio) //Constructor
        {
            Radio = radio; //Inicializamos la variable Radio
        }

        public double CalcularArea() //Método para calcular el área
        {
            return Math.PI * Radio * Radio; //Retornamos el área del círculo
        }

        public double CalcularPerimetro() //Método para calcular el perímetro
        {
            return 2 * Math.PI * Radio; //Retornamos el perímetro del círculo
        }
    }

    public class Cuadrado //Clase Cuadrado
    {

        public double Lado { get; set; } //Propiedad para el lado del cuadrado con get y set


        public Cuadrado(double lado) //Constructor
        {
            Lado = lado; //Inicializamos la variable Lado
        }

        public double CalcularArea() //Método para calcular el área
        {
            return Lado * Lado; //Retornamos el área del cuadrado
        }

        public double CalcularPerimetro() //Método para calcular el perímetro
        {
            return 4 * Lado; //Retornamos el perímetro del cuadrado
        }
    }

    public class Rectangulo //Clase Rectangulo
    {
        public double Base_ { get; set; } //Propiedad para la base del rectángulo con get y set

        public double Altura { get; set; } //Propiedad para la altura del rectángulo con get y set

        public Rectangulo(double base_, double altura) //Constructor
        {
            Base_ = base_; //Inicializamos la variable Base_
            Altura = altura; //Inicializamos la variable Altura
        }

        public double CalcularArea() //Método para calcular el área
        {
            return Base_ * Altura; //Retornamos el área del rectángulo
        }

        public double CalcularPerimetro() //Método para calcular el perímetro
        {
            return 2 * (Base_ + Altura); //Retornamos el perímetro del rectángulo
        }
    }
}