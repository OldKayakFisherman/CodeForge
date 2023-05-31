namespace FisheryMaps.Data.Entities;

public class HotSpot
{
    public int FisheryId { get; set; }

    public Fishery Fishery { get; set; }

    public int SpeciedId { get; set; }
    

    public ICollection<MapPoint> MapPoints { get; set; }

    public ICollection<Technique> Techniques { get; set; }

}