﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class HousingCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Ev kredisi ödeme planı hesaplandı");
        }
    }
}
