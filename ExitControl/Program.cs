using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExitControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string exitWord; 
            bool isNotExit = true;

            while (isNotExit)
            {
                Console.WriteLine("Hello World");
                Console.WriteLine("Для того чтобы выйти из приложения введите слово <exit>");

                exitWord = Console.ReadLine();

                if (exitWord == "exit")
                {
                    isNotExit = false;
                }
            }
        }
    }
}
