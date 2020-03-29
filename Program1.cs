using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба__3
{
    class Program
    {
        //Дано список, заповнений випадковим чином нулями і одиницями. Знайти найдовшу безперервну послідовність одиниць і визначити індекси першого і останнього елементів в ній.

        static void Main(string[] args)
        {
            var binare = new List<int>(100);
            int maxLenght = 0, firstIndex=0, currentLenght=0, currentIndex=0, lastIndex=0;
            
            int[] array = new int[100];
            Random rand = new Random();

            for(int i=0;i<array.Length;i++)
            {
                array[i] = rand.Next(0, 2);               
                binare.Add(array[i]);
            }
            Console.Write("Список: ");
            foreach (var i in binare)
            {
                Console.Write(i+"");          
            }

            Console.WriteLine();
            
            for (int i = 0; i < binare.Count; i++)
            { 
                if(binare[i]==1)
                {
                    if(i>0 && (binare[i-1]==1))
                    currentLenght++;
                    else
                    {
                        currentLenght = 1;
                        currentIndex = i;
                    }
                }
                else
                {
                    if(currentLenght>maxLenght)
                    {
                        maxLenght = currentLenght;
                        firstIndex = currentIndex;
                        lastIndex = firstIndex + maxLenght-1;
                    }                   
                }                
            }
            Console.WriteLine("Найдовша послідовність одиниць: " + maxLenght);
            Console.WriteLine("Перший індекс послідовності: " + firstIndex + " Останній індекс послідовності: " + lastIndex);
        }
    }
}
