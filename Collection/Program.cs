using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 1.	Создать коллекцию List <int> . Вывести на экран позицию и значение элемента, 
 являющегося вторым максимальным значением в коллекции. 
 Вывести на экран сумму элементов на четных позициях.
*/

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 10, 12, 13, 4, 8, 1, 71, 28, 192, 15 };

            int secondMax = 0;
            int pos = 0;
            int sum = 0;

            foreach(int i in list)
            {
                Console.Write($"{i} ");
                
                if (i > secondMax && i != list.Max())
                {
                    secondMax = i;
                }

                if (pos++ % 2 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine("\nВторое максимальное число: {0}", secondMax);
            Console.WriteLine("Позиция числа: {0}", list.FindIndex(number => number == secondMax));
            Console.WriteLine("Сумма элементов на четных позициях {0}", sum);
        }
    }
}
