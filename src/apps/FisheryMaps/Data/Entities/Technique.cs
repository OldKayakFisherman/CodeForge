using System.ComponentModel.DataAnnotations;

namespace FisheryMaps.Data.Entities;

public class Technique
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
}