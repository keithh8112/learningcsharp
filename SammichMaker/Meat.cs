﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SammichMaker
{
    class Meat
    {
        public string meatChoice(int meatchoice)
        {
            if (meatchoice == 1)
                return "Ham";
            else if (meatchoice == 2)
                return "Chicken";
            else if (meatchoice == 3)
                return "Salami";
            else
                return "Please enter a number 1-3";
        }
    }
}
