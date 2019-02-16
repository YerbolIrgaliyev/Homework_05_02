using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_05_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int cntNumbers;
            string strNumbers;

            Console.WriteLine("Введите кол-во цифр в коллекции:");
            strNumbers = Console.ReadLine();

            if(int.TryParse(strNumbers, out cntNumbers))
            {
                if(cntNumbers > 0)
                {
                    int sum = 0;
                    for (int i = 0; i < cntNumbers;)
                    {
                        Console.WriteLine($"Введите {i + 1} элемент:");
                        string strOneNumber = Console.ReadLine();
                        int oneNumber;

                        if(int.TryParse(strOneNumber, out oneNumber))
                        {
                            numbers.Add(oneNumber);
                            i++;
                            if(i%2 == 0)
                            {
                                sum += oneNumber;
                            }
                        }
                        else { Console.WriteLine("Были введены неправильные данные!"); }
                    }

                    int largest = int.MinValue;
                    int second = int.MinValue;
                    foreach (int i in numbers)
                    {
                        if (i > largest)
                        {
                            second = largest;
                            largest = i;
                        }
                        else if (i > second)
                            second = i;
                    }

                    Console.WriteLine($"Второе максимальное значение в коллекции: {second}");
                    Console.WriteLine($"Сумма четных элементов: {sum} ");
                }
                else
                { Console.WriteLine("В коллекции не может быть меньше 1 элементов!"); }
            }
            Console.ReadLine();
        }
    }
}
