using System;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Калькулятор 7000");
            int first, second;
            int answer = 0;
        Start:
            Console.WriteLine("1.Сложить 2 числа \n2. Вычесть первое из второго \n3. Перемножить два числа \n4. Разделить первое на второе \n5. Возвести в степень N первое число \n6. Найти квадратный корень из числа \n7. Найти 1 процент от числа \n8. Найти факториал из числа \n9. Выйти из программы");
            Console.WriteLine("Введите номер операции которую вы хотите выполнить");
            int move = Convert.ToInt32(Console.ReadLine());
            while (move < 0 || move > 9)
            {
                Console.WriteLine("Недопустимые значение \nВведите новые значение");
                move = Convert.ToInt32(Console.ReadLine());
            }

            while (move < 9)
            {
                if (move == 1)
                {
                    Console.WriteLine("Введите первое число\n");
                    first = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число\n");
                    second = Convert.ToInt32(Console.ReadLine());
                    answer = first + second;
                    Console.WriteLine("Ответ: " + answer + "\n");
                    goto Start;

                }
                if (move == 2)
                {
                    Console.WriteLine("Введите первое число\n");
                    first = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число\n");
                    second = Convert.ToInt32(Console.ReadLine());
                    answer = first - second;
                    Console.WriteLine("Ответ: " + answer + "\n");
                    goto Start;
                }
                if (move == 3)
                {
                    Console.WriteLine("Введите первое число");
                    first = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    second = Convert.ToInt32(Console.ReadLine());
                    answer = first * second;
                    Console.WriteLine("Ответ: " + answer + "\n");
                    goto Start;
                }
                if (move == 4)
                {
                    Console.WriteLine("Введите первое число");
                    double a, b;
                    a = Convert.ToDouble(Console.ReadLine());
                Second0:
                    Console.WriteLine("Введите второе число");
                    b = Convert.ToDouble(Console.ReadLine());


                    if (b != 0)
                    {
                        double c = a / b;
                        Console.WriteLine("Ответ: " + c + "\n");
                        goto Start;
                    }
                    else
                    {

                        Console.WriteLine("Введите другое число КРОМЕ 0");
                        goto Second0;

                    }
                }
                if (move == 5)
                {
                    Console.WriteLine("Введите первое число");
                    first = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    second = Convert.ToInt32(Console.ReadLine());
                    answer = (int)Math.Pow(first, second);
                    Console.WriteLine("Ответ: " + answer + "\n");
                    goto Start;
                }
                if (move == 6)
                {
                    Console.WriteLine("Введите число");
                    first = Convert.ToInt32(Console.ReadLine());
                    answer = (int)Math.Sqrt(first);
                    Console.WriteLine("Ответ: " + answer + "\n");
                    goto Start;
                }
                if (move == 7)
                {
                    Console.WriteLine("Введите  число");
                    double first1, answerd;
                    first1 = Convert.ToDouble(Console.ReadLine());

                    answerd = first1 / 100;
                    Console.WriteLine("Ответ: " + answerd + "\n");
                    goto Start;
                }
                if (move == 8)
                {
                    int fact;
                    int count = 1;
                    Console.WriteLine("Введите число");
                    fact = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= fact; i++)
                    {
                        count *= i;


                    }
                    Console.WriteLine("Ответ: " + count + "\n");
                    goto Start;
                    if (move == 9)
                    {
                        break;
                    }
                    break;
                }






            }









        }




    }
}

