﻿using System;
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
        public int add(int a, int b)
        {
            return a+b;
        }
        public int Sub(int a, int b)
        {
            return a-b;
        }

        public int Mul(int a, int b)
        {
            return a*b;
        }

        public int Div(int a, int b)
        {
            int res;
            if (a > 0)
            {
                res= a / b;
            }
            else
            {
                res = Int32.MinValue;
            }
            return res;
        }


    }
}