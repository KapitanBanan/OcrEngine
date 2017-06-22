using System;
using System.Collections.Generic;

namespace TextScan
{
    
    public class Costs
    {
        public int Id { get; set; }
        public float Total { get; set; }
        public DateTime Date { get; set; }

        public List<Product> Products { get; set; }
    }
}
