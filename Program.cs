namespace PPO_C_
{
    internal class Program
    {
        static void Main(string[] args)
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
    }
}
