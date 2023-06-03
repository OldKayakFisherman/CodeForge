using System.ComponentModel.DataAnnotations;

namespace FisheryMaps.Data.Entities;

public class HotSpot
{
    [Key]
    public int Id { get; set; }

    public int FisheryId { get; set; }

    public Fishery Fishery { get; set; }

    public int SpeciedId { get; set; }

    public Species Species { get; set; }

    public string Season { get; set; }

    public ICollection<MapPoint> MapPoints { get; set; }

    public ICollection<Technique> Techniques { get; set; }

}