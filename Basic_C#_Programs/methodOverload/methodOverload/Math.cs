﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOverload
{
    class Math
    {
        public int Method(int num)
        {
            int result = num * 15;
            return result;
        }

        public int Method(decimal num1)
        {
            decimal result = num1 + 5;
            return result;
        }
    }
}
