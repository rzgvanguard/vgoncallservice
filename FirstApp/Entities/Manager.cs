using System;
using System.Collections.Generic;

namespace FirstApp.Entities
{
    public class Manager : BaseCrew
    {
        public List<ProductData> ProductList
        {
            get;
            set;
        }
        public Manager()
        {
        }
    }
}
