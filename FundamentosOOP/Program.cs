using System;
using System.Globalization;


namespace FundamentosOOP
{

    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();  
            y = new Triangulo();  

            Console.WriteLine("Entre com as medidas do triângulo X ");
            x.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.b= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(" entre com as medidas do triangulo Y ");

            y.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.b= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.a + x.b + x.c) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.a) * (p - x.b) * (p - x.c));
            
            p = (y.a + y.b + y.c) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.a) * (p - y.b) * (p - y.c));
            Console.WriteLine("Área de  X = " + areaX.ToString("f4", CultureInfo.CurrentCulture));
            Console.WriteLine("Área de  Y = " + areaY.ToString("f4", CultureInfo.CurrentCulture));

            if (areaX > areaY)
            {
                Console.WriteLine(" MAIOR ÁREA DE X");
            }
            else
            {
                Console.WriteLine("MAIOR ÁREA DE Y ");
            }
        }
    }
}
