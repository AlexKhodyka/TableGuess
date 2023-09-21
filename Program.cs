namespace TableGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[30];
            Random random = new Random();

            // Fill the array with random numbers between 19 and 31
            for (int i = 29; i >= 0; i--)
            {
                Array[i] = random.Next(19, 32);
            }

            Console.Write("Näppäile numero 19 ja 31 väliltä hakua varten: ");
            if (int.TryParse(Console.ReadLine(), out int targetNumber))
            {
                if (targetNumber >= 19 && targetNumber <= 31)
                {
                    int count = 0;
                    bool found = false;

                    // Search for the target number in the array
                    foreach (int number in Array)
                    {
                        if (number == targetNumber)
                        {
                            count++;
                            found = true;
                        }
                    }

                    if (found)
                    {
                        Console.WriteLine("Luku {0} esiintyy taulukossa {1} kertaa.", targetNumber, count);
                    }
                    else
                    {
                        Console.WriteLine("Numeroa {0} ei löydy taulukosta.", targetNumber);
                    }
                }
                else
                {
                    Console.WriteLine("Kirjoita numero väliltä 19-31.");
                }
            }
            else
            {
                Console.WriteLine("Virheellinen syöttö. Syötä kelvollinen kokonaisluku.");
            }
        }
    }
}