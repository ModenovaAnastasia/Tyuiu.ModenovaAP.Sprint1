﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ModenovaAP.Sprint1.Task1.V16.Lib
{
    public class DataService : ISprint1Task1V16
    {
        public double Calculate(double x, double y, double a)
        {
            return x * 5 * y + 2 * a;
        }
    }
}