using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRS_Server.Models;

public class Poline {

    [StringLength(30)]
    public string Product { get; set; }
    public int Quantity { get; set; }
    [Column(TypeName = "decimal(11,2)")]
    public decimal Price { get; set; }
    [Column(TypeName = "decimal(11,2)")]
    public decimal LineTotal { get; set; }
}
