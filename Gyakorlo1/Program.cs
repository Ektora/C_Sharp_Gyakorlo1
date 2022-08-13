namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gyakorló 1 6. feladat Hőmérséklet átváltás
            /* 
            double celsius;
            Console.Write("Enter a degree in Celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(celsius + " Celsius is " + celsiusToFahrenheit(celsius) + " Fahrenheit.");
            */

            // Gyakorló 1 7. feladat Henger térfogatának számítása
            double radius, length;
            Console.Write("Enter the radius and length of a cylinder: ");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(radius);
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area is {area(radius)}");
            Console.WriteLine($"The volume is {volume(radius,length)}");
        }

        static double celsiusToFahrenheit(double celsius)
        {
            return (9.0/5) * celsius + 32;
        }

        static double area(double radius)
        {
            Console.WriteLine(radius);
            return radius * radius * Math.PI;
        }

        static double volume(double radius, double length)
        {
            return area(radius) * length;
        }
    }

}


