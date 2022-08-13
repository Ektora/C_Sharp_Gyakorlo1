namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            Console.Write("Enter a degree in Celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(celsius + " Celsius is " + celsiusToFahrenheit(celsius) + " Fahrenheit.");

        }

        static double celsiusToFahrenheit(double celsius)
        {
            return (9.0/5) * celsius + 32;
        }
    }

}


