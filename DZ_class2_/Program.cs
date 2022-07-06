using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_class2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число узнаем палиндром или нет: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Palindrom b = new Palindrom(a);
            Console.WriteLine(b.CheckP());
        }
    }
}
