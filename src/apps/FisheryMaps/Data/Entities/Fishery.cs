namespace FisheryMaps.Data.Entities;

public class Fishery
{
    public string Name { get; set; }
    public double CenterPointLatitude { get; set; }
    public double CenterPointLongitude { get; set; }
    public bool Active { get; set; }
}