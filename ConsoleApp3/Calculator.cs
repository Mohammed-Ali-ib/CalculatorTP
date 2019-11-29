using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Calculator

    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public virtual int Addition(int val1, int val2)
        {

            return val1+val2;
        }
        public virtual int Substruction(int val1, int val2)
        {
            return val1-val2;
        }

        public virtual int Multiplication(int val1, int val2)
        {
            return val1*val2;
        }

        public virtual int Division(int val1, int val2)
        {
            int res;
            if (val2 > 0)
            {
                res= val1 /val2;
            }
            else
            {
                res = Int32.MinValue;
            }
            return res;
        }


    }
}
