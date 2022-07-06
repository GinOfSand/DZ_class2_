using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_class2_
{
    internal class Palindrom
    {
        public int number { get; set; }
        public Palindrom(int numbers = 1111) { number = numbers; }

        public bool CheckP()
        {
            int [] chekers = new int[number.ToString().Length];
            for(int i = 0; i < number.ToString().Length; i++)
            {
                chekers[i] = number.ToString()[number.ToString().Length-i-1] -48;
            }
            int che = 0;
            int porydok = Convert.ToInt32(Math.Pow(10,Convert.ToDouble(chekers.Length)-1));
            for(int i = 0; i < chekers.Length; i++)
            {
                che += chekers[i] * porydok;
                porydok /= 10;
            }
            return number == che;
        }
    }
}
