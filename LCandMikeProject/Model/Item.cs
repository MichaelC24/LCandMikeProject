using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCandMikeProject.Model;

public class Item {

    public int Id { get; set; }
    [StringLength(50)] 
    public string Description { get; set; }
    [Column(TypeName = "decimal(9,2)")]
    public decimal Price { get; set; }


}
