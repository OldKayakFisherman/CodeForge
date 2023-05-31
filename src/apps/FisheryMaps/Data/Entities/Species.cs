using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FisheryMaps.Data.Entities;

[Table("species")]
public class Species
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }
}