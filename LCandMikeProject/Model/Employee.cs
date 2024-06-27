using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCandMikeProject.Model;

public class Employee {

    public int Id { get; set; }
    [StringLength(100)] 
    public string Email { get; set; }
    [StringLength(100)]
    public string password { get; set; }


}
