using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCandMikeProject.Model;

public class Order {

    public int Id { get; set; }
    public int CustomerId { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime Date { get; set; } = DateTime.MinValue;
    [StringLength(30)]
    public string Description { get; set; } = string.Empty;
    [StringLength(30)]
    public string Status {  get; set; } = string.Empty;
    [Column(TypeName = "decimal(9,2)")]
    public decimal Total {  get; set; } 

    public virtual Customer? Customer { get; set; }


    
}
