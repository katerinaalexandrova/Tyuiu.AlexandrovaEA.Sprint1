using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AlexandrovaEA.Sprint1.Task6.V13.Lib
{
    public class DataService : ISprint1Task6V13
    {
        public bool CheckWordsAlphabet(string value)
        {
            bool t = true;
            for (int i = 1; i < value.Length; i++)
            {
                if (value[i - 1] != value[i] - 1)
                {
                    t = false;
                }
                else t = true;
            }
            return t;
        }
    }
}
