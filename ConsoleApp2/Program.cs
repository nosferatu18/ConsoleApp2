using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //массив от 1 до 100
            int[] numbers = new int[20];
            Random random = new Random();//создаем генератор случайных чисел
            //заполняем массив от 1 до 100
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101);//дает рандомное значени из промежутка
            }
            Console.WriteLine("Массив: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] + "  ");
            }
            Console.WriteLine();
            //поиск минимальног и максимального занчения
            int min = numbers[0];//предполгаем, что первый элемент минимальный
            int max = numbers[0];//предполгаем, что первый элемент максимальный
            int minIndex = 0;
            int maxIndex = 0;

            //поиск минимума и максимума
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];//обновляем минимум
                    minIndex = i;
                }
                if (numbers[i] > max)
                {
                    max = numbers[i];
                    maxIndex = i;
                }
            }
            //проверяем на наличие дубликатов 
            bool hasDuplicates = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        hasDuplicates = true;
                        break;
                    }
                }
                if (hasDuplicates)
                    break;
            }
            //поиск второго по величине элемента
            int secondMax = int.MinValue;//вызываем самое маленькое число из существующих
            for (int i = 0; i <= numbers.Length; i++)
            {
                //если элемент больш текущего второго максимума но меньше абсолютного максимума
                if ( numbers[i] > secondMax && numbers[i] < max)
                {
                    secondMax= numbers[i];//возвращаем второй максимум 
                }
            }
            //Выводим результаты
            Console.WriteLine($"Минимум {min} находится в ячейке {minIndex}");
            Console.WriteLine($"Максимум {max} находится в ячейке {maxIndex}");
            Console.WriteLine("Есть дубликаты: " + hasDuplicates);
            if(secondMax != int.MinValue)
            {
                Console.WriteLine($"Второй максимум: {secondMax}");
            }
            else
            {
                Console.WriteLine("Второго максимума нет ( все элементы одинаковые)");
            }
        }
    }
}
