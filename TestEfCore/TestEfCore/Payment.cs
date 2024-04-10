using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEfCore
{
    public  class Payment
    {
        public int Id { get; set; }
        public DateTime PayDate { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; } = "Food";
        public string? Description { get; set; }

    }
}
