using System;

namespace ExitControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string exitWord = "exit"; 
            string userinput;
            bool isWork = true;

            while (isWork)
            {
                Console.WriteLine("Hello World");
                Console.WriteLine("Для того чтобы выйти из приложения введите слово <exit>");

                userInput = Console.ReadLine();

                if (userinput == exitWord)
                {
                    isWork = false;
                }
            }
        }
    }
}
