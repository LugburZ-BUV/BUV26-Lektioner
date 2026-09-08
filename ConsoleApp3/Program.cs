namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Räkna och skriv ut talen 0-10
            //Console.WriteLine("Talen 0-10:");
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();

            //// Räkna ut och skriv ut summan av talen 0-100
            //Console.WriteLine("Summan talen 0-100:");
            //int j = 0;
            //int total = 0;
            //while (j <= 100)
            //{
            //    total += j;
            //    j++;
            //}
            //Console.WriteLine(total);
            //Console.WriteLine();

            //// Skriv ut multiplikationstabellen 1-5
            //Console.WriteLine("Multiplikationstabell 1-5:");
            //int längd = 5;
            //for (int rad = 1; rad <= längd; rad++)
            //{
            //    for (int kolumn = 1; kolumn <= längd; kolumn++)
            //    {
            //        Console.Write(rad * kolumn + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            ////Dom häller det i drinken och säger den är god...
            ////string[] words = { "Banan", "Melon", "Kiwi", "Citron" };
            ////int[] numbers = { 1, 2, 3, 4};
            ////foreach (string item in words)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //// Gissa numret
            //int secretNumber = 7;
            //int antalGissningar = 0;
            //while (true)
            //{
            //    Console.Write("Gissa numret: ");
            //    int guess = Convert.ToInt32(Console.ReadLine());
            //    if (guess > secretNumber)
            //    {
            //        Console.WriteLine("För högt!");
            //        antalGissningar++;
            //        Console.WriteLine("Antal gissningar:" + antalGissningar);
            //    }
            //    else if (guess < secretNumber)
            //    {
            //        Console.WriteLine("För lågt!");
            //        antalGissningar++;
            //        Console.WriteLine("Antal gissningar:" + antalGissningar);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Rätt gissat efter " + antalGissningar + " gissningar.");
            //        break;
            //    }
            //}
            //Console.WriteLine();
            //// Array med namn och utskrift av arrayen + längden
            //Console.WriteLine("Namn i array + längd:");
            //string[] namn = { "Anna", "Erik", "Sara" };
            //foreach (string name in namn)
            //    Console.WriteLine(name);
            //Console.WriteLine(namn.Length);
            //Console.WriteLine();
            //// Meny
            //while (true)
            //{
            //    Console.WriteLine("Meny: " +
            //        "\n 1. Säg Hej!" +
            //        "\n 2. Säg Hej då!" +
            //        "\n 3. Avsluta");
            //    Console.WriteLine("\n" +
            //        "Ange alternativ:");
            //    int alternativ = Convert.ToInt32(Console.ReadLine());
            //    if (alternativ == 1)
            //    {
            //        Console.WriteLine("Val: 1 " +
            //            "\nHej!\n");
            //    }
            //    else if (alternativ == 2)
            //    {
            //        Console.WriteLine("Val 2: " +
            //            "\nHej då!\n");
            //    }
            //    else if (alternativ == 3)
            //    {
            //        Console.WriteLine("Val 3: " +
            //            "\nProgrammet avslutas.\n");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ogiltigt alternativ, vänligen försök igen.\n");
            //    }
            //}
            //Console.WriteLine();
            //// Tal 1-20, skippar jämna tal, stannar vid 15
            //for (int h = 1; h <= 20; h++)
            //{
            //    // Hoppa över om talet är delbart med 2
            //    if (h % 2 == 0)
            //    {
            //        continue; 
            //    }
            //    // Avbryt om talet är större än 15
            //    if (h > 15)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(h);
            //}
            //Console.WriteLine();

            //// Kombinera allt
            //Console.WriteLine("Kombinera allt:");
            //int[] Tal = { 5, 3, -2, 8, 0, 100 }; // Array med tal

            ////Summan av talen Tal
            //int summa = 0;
            ////För varje tal i arrayen Tal;
            //foreach (int T in Tal)
            //{
            //    // Hoppa över negativa tal
            //    if (T < 0)
            //    {
            //        continue;
            //    }
            //    // Lägg till positiva tal i summan
            //    else if (T > 0)
            //    {
            //        summa += T;
            //    }
            //    // Bryt om vi stöter på 0
            //    else if (T == 0)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("Den totala summan är: " + summa);

            //Console.ReadKey();


            //implicit
            // Från mindre till större datatyp
            int Number = 50;
            double Number_Double = Number;
            Console.WriteLine(Number_Double);


            //explicit
            // Från större till mindre datatyp
            float FNumber = 5821357.92f;
            int INumber = (int)FNumber;
            int INumber2 = Convert.ToInt32(FNumber);
            Console.WriteLine(INumber);
            Console.WriteLine(INumber2);


            //parse
            // Från string till int
            string strNumber = "123";
            //int IntNumber = int.Parse(strNumber);
            //Console.WriteLine(IntNumber + 100);

            int result = 0;
            bool isConverted = int.TryParse(strNumber, out result);

            if (isConverted)
            {
                Console.WriteLine($"Result is {strNumber}"); 
            }
            else
            {
                Console.WriteLine("Kunde inte konvertera strängen till ett heltal.");
            }
        }
    }
    class User
    {
            string Name = "Nils";
    }
    class User2
    {
            string Name2 = "Nils 2";
    }   
}
