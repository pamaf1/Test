using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Лаба__3_2._3_
{
    class Program
    {
        //Дана послідовність додатніх цілих чисел. Обробляючи тільки непарні числа, отримати послідовність їх строкових уявлень і впорядкувати її в лексикографічному порядку по зростанню. (3)
        static void Main(string[] args)
        {
            var sequence = new List<int>(50);
            int[] array = new int[50];
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 200);
                sequence.Add(array[i]);
            }
            Console.Write("Послідовність додатніх цілих чисел: ");
            foreach (var i in sequence)
            { 
                Console.Write(i + " ");
            }
            var selectedSequence = from n in sequence
                                   where n % 2 != 0
                                   orderby n
                                   select n;

            var sortSequence = new List<string>();           
            Console.WriteLine();
            foreach(var n in selectedSequence)
            {
                sortSequence.Add(n.ToString());
            }
            /*Вообще я сначала сделал так, но не уверен, что здесь числа представленны в последовательности строковых представлений:
             * 
                foreach(var n in selectedSequence)
                {
                   n.ToString();
                   Console.WriteLine(n+" ");
                }
             */
            Console.Write("Відсортована послідовність непарних чисел: ");
            foreach (string number in sortSequence)
            {
                Console.Write(number+" ");
            }
        }
    }
}
