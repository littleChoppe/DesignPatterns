﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse
{
    public enum Size
    {
        Tall,
        Grande,
        Venti,
    }
    public abstract class Beverage
    {
        protected string description = "Unknown Beverage";
        public virtual string GetDescription()
        {
            return description;
        }
        public abstract double Cost();
    }
}
