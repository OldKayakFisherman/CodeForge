using System.ComponentModel.DataAnnotations;

namespace FisheryMaps.Data.Entities;
using CommonLib.Geospatial;

public class MapPoint: CommonLib.Geospatial.MapPoint
{
    [Key]
    public int Id { get; set; }
}