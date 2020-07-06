using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data.DB
{
    public class Schema
    {
        [Key]
        public int Id { get; set; }

        public byte[] Content { get; set; }
    }
}
