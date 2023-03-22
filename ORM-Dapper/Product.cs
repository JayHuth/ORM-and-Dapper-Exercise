﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    internal class Product
    {
        public string Name { get; set; }
        public int ProductID { get; set; }
        public int Price { get; set; }
        public int CategoryID { get; set; }
        public bool OnSale { get; set; }
        public int StockLevel { get; set; }

    }
}
