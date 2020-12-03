using System.ComponentModel.DataAnnotations.Schema;

namespace Practice3.Models
{
    public class Product
    {
        public long EmployeeID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal Salary { get; set; }
    }
}
