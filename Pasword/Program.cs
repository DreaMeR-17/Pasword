using System;

namespace Pasword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pasword = "admin";
            string userInput;

            int triesCount = 3;

            for (int i = 0; i < triesCount; i++)
            {

                Console.WriteLine("Введите пароль.");
                userInput = Console.ReadLine();

                if (userInput == pasword)
                {
                    Console.WriteLine("Вот все ваши секреты");
                    break;
                }
                
                else
                {
                    Console.WriteLine("Пароль неверный, попробуйте еще раз");
                    Console.WriteLine($"Осталось {triesCount - i - 1} попытки");
                }
            }
        }
    }
}
