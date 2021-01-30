using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data.DB
{
    public class Payment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Status { get; set; }
    }
}
