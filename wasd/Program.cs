using System;
using static System.Math;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Простой калькулятор by Tagir");
            for (; ; )
            {
                Console.Write("Введите первое число: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите оператор (+, -, *, /, ^, #, %, f)( выход через '9' ): ");
                char op = Convert.ToChar(Console.ReadLine());
                double num2 = 0;
                if (op != '#' && op != '%' && op != 'f' && op != '9') //Это я делал (Тут я смотрел гайды на ютубе)
                {
                    Console.Write("Введите второе число: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                }

                double result;

                switch (op) //Это тоже я делал
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: деление на ноль.");
                            return;
                        }
                        break;
                    case '^':
                        result = Math.Pow(num1, num2);
                        break;
                    case '#':
                        result = Math.Sqrt(num1);
                        break;
                    case '%':
                        result = num1 * 0.01;
                        break;
                    case 'f': //Тут я тоже старался
                        int temp = 1;
                        result = 1;
                        while (temp <= num1)
                        {
                            result *= temp;
                            temp++;
                        }
                        break;
                    case '9':
                        return;
                    default:
                        Console.WriteLine("Ошибка: некорректный оператор.");
                        return;
                }

                Console.WriteLine("Результат: " + result);
                //Спасибо за внимание!!!!!!!!<3 !!!!!!@!!
            }
        }
    }
}