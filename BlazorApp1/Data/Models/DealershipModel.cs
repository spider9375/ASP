using System.Collections.Generic;

namespace BlazorApp1.Data.Models
{
    public class DealershipModel
    {
        public int Id { get; set; }

        public string Address { get; set; }

        public List<CarModel> Cars { get; set; }
    }
}
