using System;

namespace ExitControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string exitWord = "exit"; 
            string userinput;
            bool isNotExit = true;

            while (isNotExit)
            {
                Console.WriteLine("Hello World");
                Console.WriteLine("Для того чтобы выйти из приложения введите слово <exit>");

                exitWord = Console.ReadLine();

                if (userinput == exitWord)
                {
                    isNotExit = false;
                }
            }
        }
    }
}
