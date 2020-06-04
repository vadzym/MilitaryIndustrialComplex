﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entities
{
    public class ProductionStore
    {
        public int ProductionStoreId { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public IList<string> ProductList { get; set; }
    }
}
