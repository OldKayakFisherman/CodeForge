using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FisheryMaps.Data.Entities;

[Table("fisheries")]
public class Fishery
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public double CenterPointLatitude { get; set; }
    public double CenterPointLongitude { get; set; }
    public bool Active { get; set; }
    public string Nonce { get; set; }

    public ICollection<HotSpot> HotSpots { get; set; }
}