using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Laba5OAIP
{
    public class Rational
    {
        public int first;
        public int second;
        public string resualt;
        public Rational()
        {
            first = 23424;
            second = 12312;
        }

        public Rational(int a, int b)
        {
            first = a;
            second = b;
            Reduce();
        }

        public void Read()
        {
            Console.Write("Введите числитель: ");
            first = int.Parse(Console.ReadLine());

            Console.Write("Введите знаменатель: ");
            second = int.Parse(Console.ReadLine());

            if (second == 0)
            {
                Console.WriteLine("Ошибка:знаменатель не может быть равен нулю");
            }

            Reduce();
        }

        public void Display()
        {
            if (second == 1)
                Console.WriteLine($"{first}");
            else
                Console.WriteLine($"{first}/{second}");
        }

        public void Display(string resualt)
        {
            Console.WriteLine(resualt);
        }

        public int NOD(int a, int b)
        {
            if (a < 0)
            {
                a *= -1;
            }

            if (b < 0)
            {
                b *= -1;
            }

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public void Reduce()
        {
            if (first == 0)
            {
                second = 1;
                return;
            }

            int nod = NOD(first, second);
            first /= nod;
            second /= nod;

        }

        public static Rational operator +(Rational r1, Rational r2)
        {
            int newNumerator = r1.first * r2.second + r2.first * r1.second;
            int newDenominator = r1.second * r2.second;
            return new Rational(newNumerator, newDenominator);
        }

        public static Rational operator -(Rational r1, Rational r2)
        {
            int newNumerator = r1.first * r2.second - r2.first * r1.second;
            int newDenominator = r1.second * r2.second;
            return new Rational(newNumerator, newDenominator);
        }

        public static Rational operator *(Rational r1, Rational r2)
        {
            int newNumerator = r1.first * r2.first;
            int newDenominator = r1.second * r2.second;
            return new Rational(newNumerator, newDenominator);
        }

        public static Rational operator /(Rational r1, Rational r2)
        {

            int newNumerator = r1.first * r2.second;
            int newDenominator = r1.second * r2.first;
            return new Rational(newNumerator, newDenominator);
        }

        public void equals(Rational r1, Rational r2)
        {
            {
                int left = r1.first * r2.second;
                int right = r2.first * r1.second;
                if (left == right)
                {
                    resualt = "Дроби равны";
                }
                else if (left > right)
                {
                    resualt = "Первая дробь больше второй";
                }
                else
                {
                    resualt = "Первая дробь меньше второй";
                }
                Display(resualt);   
            }
        }
    }
}