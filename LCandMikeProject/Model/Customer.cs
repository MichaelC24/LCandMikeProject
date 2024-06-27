using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCandMikeProject.Model
{
    public class Customer
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [StringLength(50)]
        public string City { get; set; } = string.Empty;
        [StringLength(50)]
        public string State {  get; set; } = string.Empty;
        [Column(TypeName = "decimal(9,2)")]
        public decimal Sales { get; set; }
        [Column(TypeName = "bit")]
        public bool Active { get; set; }
    }
}
