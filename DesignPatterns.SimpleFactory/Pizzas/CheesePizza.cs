﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SimpleFactory.Pizzas
{
    public class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            this.Name = "cheese pizza";
        }
    }
}
