﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper;

public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
    
    }

