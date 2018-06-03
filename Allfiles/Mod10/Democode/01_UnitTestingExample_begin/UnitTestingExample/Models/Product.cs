﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTestingExample.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float BasePrice { get; set; }
        public string Description { get; set; }
        public string FormattedPrice
        {
            get
            {
                return BasePrice.ToString($"C2");
            }
        }
    }
}