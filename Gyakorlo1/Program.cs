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
            /*
            double radius, length;
            Console.Write("Enter the radius and length of a cylinder: ");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(radius);
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area is {area(radius)}");
            Console.WriteLine($"The volume is {volume(radius,length)}");
            */

            // Gyakorló 1 8. feladat Hosszúság átváltás.
            /*
            double feet;
            Console.Write("Enter a value for feet: ");
            feet = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{feet} feet is {feet*0.305} meters");
            */

            // Gyakorló 1 9. feladat Tömeg átváltás.
            /*
            double pounds;
            Console.Write("Enter a number in pounds: ");
            pounds = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{pounds} pounds is {pounds * 0.454} kilograms");
            */

            // Gyakorló 1 10. feladat Adott ASCII kódhoz tartozó karakter megjelenítése.
            int number;
            Console.Write("Enter an ASCII code: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The character for ASCII code {number} is {Convert.ToChar(number)}");
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


