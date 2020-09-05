﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleApp4.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Product()
        {
        }

        public virtual string Imprimir()
        {
            return
                Name +
                " $ " +
                Price.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
