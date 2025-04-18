﻿using System.ComponentModel.Design;

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
            else if (wybor == 4 && liczba2 != 0)                                                //Brak dzielenia przez 0
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
                Console.WriteLine(celsjusz + "°C to " + (celsjusz * 1.8 + 32) + "°F.");        //Obliczenia ze wzoru bezpośrednio w print statemencie dla zwiększenia kompaktowości kodu
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

        static void srednia()
        {
            Console.WriteLine("\tKalkulator Średniej Ocen");

            Console.WriteLine("Podaj liczbę ocen do wprowadzenia: ");
            int  n = int.Parse(Console.ReadLine());
            List<float> oceny = new List<float>();

            Console.WriteLine("Podaj kolejno oceny: ");

            for (int i = 0; i < n; i++)
            {
                float wpis = float.Parse(Console.ReadLine());
                oceny.Add(wpis);
            }

            float srednia = oceny.Sum() / n;        //Średnia ocen w zmiennej dla zwiększonej czytelności

            if (3 <= srednia && srednia <= 6)               //Program nie pozwala na podawanie ocen większych niż 6 oraz mniejszych niż 1
            {
                Console.WriteLine("Średnia ucznia wynosi: " + srednia);
                Console.WriteLine("Uczeń zdał.");
            }
            else if (1 <= srednia && srednia < 3)
            {
                Console.WriteLine("Srednia ucznia wynosi: " + srednia);
                Console.WriteLine("Uczeń nie zdał.");
            }
            else
                Console.WriteLine("Niepoprawne dane.");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz zadanie do którego chcesz przejść: " +
                "\n1. Prosty kalkulator dwóch liczb" +
                "\n2. Konwerter temperatur (Celsjusz <-> Fahrenheit)" +
                "\n3. Kalkulator średniej z ocen" +
                "\n4. Wyjście");
            int wybor = int.Parse(Console.ReadLine());

                if (wybor == 1)
                    kalkulator();
                else if (wybor == 2)
                    konwerter();
                else if (wybor == 3)
                    srednia();
                else if (wybor == 4 )
                Console.WriteLine("Do zobaczenia!");
                else
                    Console.WriteLine("Niepoprawny wybór.");
        }
    }
}
