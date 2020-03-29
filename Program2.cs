using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба__3_2._2_
{
    class Program
    {
        //Дано словник. Записати значення його ключів у список, значення ключів записати у ще один список. Вивести елементи двох списків почергово на екран.
        static void Main(string[] args)
        {
            Dictionary<int, string> list = new Dictionary<int, string>
            {
                {1, "Микола" },
                {2, "Алёша" },
                {3, "Петро" },
                {4, "Андрей" },
                {5, "Янык" },
                {6, "Микита" },
                {7, "Владос" },
                {8, "Виталя" },
                {9, "Геббельс" },
                {10, "Боженька" }
            };
            List<string> names = new List<string>();
            List<int> number = new List<int>();
            foreach (int numbers in list.Keys)
            {
                number.Add(numbers);
            }
            foreach (string name in list.Values)
            {
                names.Add(name);
            }
            for(int i=0;i<names.Count;i++)
            {
                Console.WriteLine(number[i]+" - "+ names[i] + "; ");
               
            }
        }
    }
}
