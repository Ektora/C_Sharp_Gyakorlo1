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
            /*
            int number;
            Console.Write("Enter an ASCII code: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The character for ASCII code {number} is {Convert.ToChar(number)}");
            */

            // Gyakorló 1 25. feladat Algebra: a másodfokú egyenlet megoldása.
            /*
            double a,b,c;
            Console.Write("Enter a, b, c: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            masodfokuEgyenlet(a,b,c);
            */

            // Gyakorló 1 26. feladat Páros szám ellenőrzése
            /*
            int number;
            Console.Write("Enter an integer: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Is {number} an even number? {number%2 == 0}");
            */

            // Gyakorló 1 27. feladat ISBN kód ellenőrzése
            /*
            string szoveg = Console.ReadLine();
            int c, ISBNOsszeg=0;
            for(int i = 0; i<9; i++)
            {
                c = Convert.ToInt32(szoveg[i]-'0');
                Console.WriteLine(c);
                ISBNOsszeg += c * (i + 1); 
            }
            ISBNOsszeg = ISBNOsszeg % 11;
            if (ISBNOsszeg != 10)
            {
                Console.WriteLine(szoveg + ISBNOsszeg);
            }
            else
            {
                Console.WriteLine(szoveg + 'X');
            }
            */

            // Gyakorló 1 28. feladat Háromszög érvényességének ellenőrzése
            /*
            double a, b, c;
            Console.Write("Enter three edges: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Can edges {a}, {b}, and {c} form a triangle? {haromszogErvenyesseg(a,b,c)}");
            */

            // Gyakorló 1 29. feladat Pozitív és negatív számok számolása, valamint számok átlagának a kiszámítása.
            /*
            int poz =0, neg = 0, ossz = 0, olvasottSzam;
            double average = 0;
            Console.WriteLine("Enter integer values, the program exist if the input is 0:");
            do
            {
                olvasottSzam = Convert.ToInt32(Console.ReadLine());
                ossz++;
                average += olvasottSzam;
                if (olvasottSzam > 0)
                    poz++;
                else if(olvasottSzam<0)
                {
                    neg++;
                }
            }
            while (olvasottSzam != 0);

            Console.WriteLine("The number of positives is " + poz);
            Console.WriteLine("The number of negatives is " + neg);
            Console.WriteLine("The total is " + ossz);
            Console.WriteLine("The average is " + average/(ossz-1));
            */

            // Gyakorló 1 30. feladat Kilogram átváltása fontra.
            Console.WriteLine(String.Format("{0,-14} {1,-10}", "Kilograms", "Pounds"));
            for(int i = 1; i < 200; i = i + 2)
            {
                Console.WriteLine(String.Format("{0,-13} {1,5:0.0}",i,i*2.2));
            }
        }



        static bool haromszogErvenyesseg(double a, double b, double c)
        {
            if (((a + b) > c) && ((a + c) > b) && ((b + c) > a))
                return true;
            return false;
        }

        static void masodfokuEgyenlet(double a, double b, double c)
        {
            double r1, r2;
            if (Math.Pow(b, 2) - 4 * a * c > 0)
            {
                r1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                r2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                Console.WriteLine($"The roots are {r1} and {r2}");

            }
            else if (Math.Pow(b, 2) - 4 * a * c == 0)
            {
                r1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                Console.WriteLine($"The root is {r1}");
            }
            else
            {
                Console.WriteLine("The equation has no real roots");
            }
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


