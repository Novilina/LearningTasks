using System;
using System.Linq;

namespace _0104_Question
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пишем текст загадки
            Console.WriteLine("Отгадайте загадку:");
            Console.WriteLine("Не ездок, а со шпорами,");
            Console.WriteLine("Не будильник, а всех будит");

            Console.Write("Ответ: ");
            //Пишем ответ на загадку
            var answer = Console.ReadLine().Trim().ToLower();

            string[] rightAnswers = new[]
            {
                "петух",
                "петушок",
                "петя",
                "петушила",
                "петушенция",
                "петька",
                "тот паренек с гребнем"
            };

            //Если мы написали, что ответ "петух"
            if (rightAnswers.Contains(answer))
            {
                //...то зелёным цветом пишем, что ответ верный!
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Верно! Это петух!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неправильно!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Пожалуйста, выберите из предложенных вариантов:");
                Console.WriteLine("Свинья");
                Console.WriteLine("Петух");
                Console.WriteLine("Баран");
                answer = Console.ReadLine().Trim().ToLower();
                if (rightAnswers.Contains(answer))
                {
                    //...то зелёным цветом пишем, что ответ верный!
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Верно! Это петух!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неправильно! Это петух");
                    Console.ForegroundColor = ConsoleColor.Gray;



                }


                //...иначе ответ неверный, и красным цветом пишем об этом
            }

            Console.Read();
        }
    }
}
