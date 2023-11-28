using System;

namespace inluppg5_9A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[3];

            int counter = 0;
            Console.WriteLine("Skriv in ett namn, eller mata in a för att sluta");
            for (int i = 0; i < names.Length; i++)
            {
                string promptInput = Console.ReadLine();
                if(i == names.Length)
                {
                    Console.WriteLine("Nu finns det inte plats för fler namn");
                    break;
                }
                else if (promptInput == "a")
                {
                    break;
                }
                else
                {
                    counter++;
                    names[i] = promptInput;
                    Console.WriteLine("Skriv in ett till namn, eller mata in a för att sluta");
                }
            }

            int appears = 0;
            Console.WriteLine("\nSkriv nu ett namn för att få veta hur många gånger som det uppstår");
            string nameToCheck = Console.ReadLine();

            for(int i = 0; i < counter; i++)
            {
                if (names[i].ToLower() == nameToCheck.ToLower())
                {
                    appears++;
                }
            }
            Console.WriteLine(nameToCheck + " finns med " + appears + " gånger i listan");
        }
    }
}