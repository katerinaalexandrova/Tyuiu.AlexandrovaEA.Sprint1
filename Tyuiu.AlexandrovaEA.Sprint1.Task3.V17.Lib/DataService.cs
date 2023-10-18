using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AlexandrovaEA.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {
        public bool ZeroCheck(double number)
        {
            int i = 0;
            double x;
            bool t = false;
            number *= 1000;
            number = Convert.ToInt32(number);
            //Console.WriteLine(number);
            while (i < 3)
            {
                i++;
                x = number % 10;
                number = Convert.ToInt32(number / 10);
                //Console.WriteLine(number);
               //Console.WriteLine(x);
                if (x == 0)
                {
                    t = true;
                }
            }
            return t;
        }
    }
}
