using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5OAIP
{
    public class Scope
    {

        public int first;
        public int second;
        public int number;
        public string resualt;

        public void Read(out int first, out int second, out int number)
        {
            Console.WriteLine("Введите число(левую границу диапазона):");
            first = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число(правую границу диапазона):");
            second = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите любое число:");
            number = int.Parse(Console.ReadLine());
        }

        public void Display(string resualt)
        {
            Console.WriteLine(resualt);
        }

        public string rangecheck(int first, int second, int number)
        {
            if (number >= first && number < second){
                return resualt = "Число принадлежит диапазону";
            }
            else{
                return resualt = "Число не принадлежит диапазону";
            }
        }
    }
}
