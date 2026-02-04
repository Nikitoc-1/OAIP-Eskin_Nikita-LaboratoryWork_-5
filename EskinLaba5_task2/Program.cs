
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Runtime.ExceptionServices;
using Laba5OAIP;
namespace Hello
{
    class Program
    {
        static void Main()
        {

            Rational fraction1 = new Rational();
            Rational fraction2 = new Rational();
            Rational rational = new Rational();

            Console.WriteLine("\nВведите первую дробь:");
            fraction1.Read();

            Console.WriteLine("\nВведите вторую дробь:");
            fraction2.Read();

            Console.WriteLine("\nРезультаты операций:");

            Rational sum = fraction1 + fraction2;
            Console.Write("Сумма: ");
            sum.Display();

            Rational difference = fraction1 - fraction2;
            Console.Write("Разность: ");
            difference.Display();

            Rational product = fraction1 * fraction2;
            Console.Write("Произведение: ");
            product.Display();

            Rational quotient = fraction1 / fraction2;
            Console.Write("Частное: ");
            quotient.Display();

            Console.WriteLine("Сравнение дробей:");
            rational.equals(fraction1, fraction2);
            
        }
    }
}