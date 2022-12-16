using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            System.Console.Write("Введите количество элементов в массиве = ");
            int n = int.Parse(System.Console.ReadLine());//размерность массива
            int[] arr = new int[n];
            int summ = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write("Введите {0} элемент массива = ", i);
                arr[i] = int.Parse(System.Console.ReadLine());//ввод элементов массива
                if (i % 2 == 0)//проверка если номер элемена четный
                    summ += arr[i];
            }
            System.Console.Write("Полученный массив --");
            foreach (int el in arr)//цикл для перебора массива
                System.Console.Write("{0,2}", el);
            System.Console.WriteLine(" -- сумма элементов с чётными номерами = {0}", summ);//вывод суммы элементов

        }
    }
}
