using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Задача 2
// Используя Visual Studio, создайте проект по шаблону ConsoleApplication. Создайте четыре метода для выполнения арифметических операций,
// с именами: Add – сложение, Sub – вычитание, Mul – умножение, Div – деление.Каждый метод должен принимать два целочисленных аргумента 
// и выводить на экран результат выполнения арифметической операции соответствующей имени метода.Метод деления Div, должен выполнять 
// проверку попытки деления на ноль. Требуется предоставить пользователю возможность вводить с клавиатуры значения операндов и знак 
// арифметической операции, для выполнения вычислений.

namespace hwless7ex2
{
    class Program
    {
        static double Add(double opr1, double opr2)
        {
            return opr1 + opr2;
        }
        static double Sub(double opr1, double opr2)
        {
            return opr1 - opr2;
        }
        static double Mul(double opr1, double opr2)
        {
            return opr1 * opr2;
        }
        static double Div(double opr1, double opr2)
        {
            if (opr2 == 0)
            {
                Console.WriteLine("Divide by 0!");
                return 0;
            }
            else return opr1 / opr2;
        }
        static double RemainderOfDivision(double opr1, double opr2)
        {
            return opr1 % opr2;
        }
        static void Main(string[] args)
        {
            start:
            Console.Write("Input expression (through a space): ");
            string str = Console.ReadLine();
            string[] splitStr = str.Split(' ');
            double operrand1 = double.Parse(splitStr[0]);
            string operrator = splitStr[1];
            double operrand2 = double.Parse(splitStr[2]);
            switch (operrator)
            {
                case "+":
                    Console.WriteLine($"= {Add(operrand1, operrand2)}");
                    goto start;
                case "-":
                    Console.WriteLine($"= {Sub(operrand1, operrand2)}");
                    goto start;
                case "*":
                    Console.WriteLine($"= {Mul(operrand1, operrand2)}");
                    goto start;
                case "/":
                    if (Div(operrand1, operrand2) == 0)
                    {
                        goto start;
                    }
                    else
                    {
                        Console.WriteLine($"= {Div(operrand1, operrand2)}");
                        goto start;
                    }
                case "%":
                    Console.WriteLine($"= {RemainderOfDivision(operrand1, operrand2)}");
                    goto start;
                default: Console.WriteLine("Uncorrect data! Try again!");
                    goto start;
                //break;
            }

        }
    }
}
