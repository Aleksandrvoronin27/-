using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в калькулятор");
            double a, b, c;
            Console.WriteLine("Введите первое число");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("выберите действие +,-,*,/");
            c = Convert.ToChar(Console.ReadLine());
            switch (c)
            {
                case '+': c = a+b; break;
                case '-': c = a - b; break;
                case '*': c = a * b; break;
                case '/':
                    
                    if (b != 0) 
                    {
                        c = a / b;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка, деление на ноль");
                        return; 
                    }
                    break;
                default:
                    Console.WriteLine("Неверная операция");
                    return;

                
            }
            Console.WriteLine("ОТВЕТ="+c);
            Console.ReadKey();

        }
    }
}
