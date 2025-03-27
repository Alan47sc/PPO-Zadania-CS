using System.ComponentModel.Design;

namespace PPO_C_
{
    internal class Program
    {
        static void kalkulator()
        {
            Console.WriteLine("\tProsty Kalkulator Dwóch Liczb");

            Console.WriteLine("\nPodaj pierwszą liczbę: ");
            var liczba1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę: ");
            var liczba2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Jaką operację chcesz wykonać:" +
                "\n1. Dodawanie" +
                "\n2. Odejmowanie" +
                "\n3. Mnożenie" +
                "\n4. Dzielenie");
            var wybor = int.Parse(Console.ReadLine());

            if (wybor == 1)
                Console.WriteLine(liczba1 + " + " + liczba2 + " = " + (liczba1 + liczba2));
            else if (wybor == 2)
                Console.WriteLine(liczba1 + " - " + liczba2 + " = " + (liczba1 - liczba2));
            else if (wybor == 3)
                Console.WriteLine(liczba1 + " * " + liczba2 + " = " + (liczba1 * liczba2));
            else if (wybor == 4 && liczba2 != 0)
                Console.WriteLine(liczba1 + " / " + liczba2 + " = " + (liczba1 / liczba2));
            else
                Console.WriteLine("Nieprawidłowy wybór.");
        }

        static void konwerter()
        {
            Console.WriteLine("\t Konwerter Temperatur (Celsjusz <-> Fahrenheit)");

            Console.WriteLine("Wybierz rodzaj konwersji: " +
                "\nC - Stopnie Celsjusza na Fahrenheita" +
                "\nF - Stopnie Fahrenheita na Celsjusza");
            var wybor = Console.ReadLine();

            if (wybor == "C" || wybor == "c")
            {
                Console.WriteLine("Podaj temperaturę w skali Celsjusza: ");
                var celsjusz = float.Parse(Console.ReadLine());
                Console.WriteLine(celsjusz + "°C to " + (celsjusz * 1.8 + 32) + " °F.");
            }

            else if (wybor == "F" || wybor == "f")
            {
                Console.WriteLine("Podaj temperaturę w skali Fahrenheita: ");
                var fahren = float.Parse(Console.ReadLine());
                Console.WriteLine(fahren + "°F to " + ((fahren - 32) / 1.8) + "°C.");
            }
            else
                Console.WriteLine("Nieprawidłowy wybór.");
        }


        static void Main(string[] args)
        {
            
        }
    }
}
