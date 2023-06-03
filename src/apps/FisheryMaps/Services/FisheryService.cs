using CommonLib.Geospatial;

namespace FisheryMaps.Services;

public class FisheryServiceDisplayModel
{
    public string Name { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public bool Active { get; set; }
    public string Nonce { get; set; }

    public ICollection<FisheryHotspotDisplayModel> Hotspots { get; set; } = new List<FisheryHotspotDisplayModel>();
}

public class FisheryHotspotDisplayModel
{
    public string Species { get; set; }
    public string Season { get; set; }

    public ICollection<MapPoint> Coordinates { get; set; } = new List<MapPoint>();
    public ICollection<String> Techniques { get; set; } = new List<string>();

}


public class FisheryService
{
    public IList<FisheryServiceDisplayModel> GetAllActiveFisheries()
    {
        //TODO - Plug this into a real database pull when the time comes
        IList<FisheryServiceDisplayModel> displayModels = new List<FisheryServiceDisplayModel>();
        
        //38.762817, -77.299299 - Burke Lake
        displayModels.Add(new FisheryServiceDisplayModel()
        {
            Name = "Burke Lake",
            Latitude = 38.762817,
            Longitude = -77.299299,
            Active = true,
            Nonce = "n7Rb6ePrGR9zQ"
        });
        
        displayModels[0].Hotspots.Add(new FisheryHotspotDisplayModel()
        {
            Species = "Bass",
            Season = "Spring",
            Coordinates = new List<MapPoint>()
                {
                    new MapPoint(){Latitude = 38.757786, Longitude = -77.293923},
                    new MapPoint(){Latitude = 38.758264, Longitude = -77.294792},
                    new MapPoint(){Latitude = 38.757538, Longitude = -77.295018},
                    new MapPoint(){Latitude = 38.757211, Longitude = -77.294535}
                },
            Techniques = new List<string>()
            {
                "Speed Worm",
                "Swim Jig",
                "Tokyo Rig",
                "Soft Plastic JerkBait"
            }
        });
        
        displayModels[0].Hotspots.Add(new FisheryHotspotDisplayModel()
        {
            Species = "Bass",
            Season = "Spring",
            Coordinates = new List<MapPoint>()
            {
                new MapPoint(){Latitude = 38.760759, Longitude = -77.295929},
                new MapPoint(){Latitude = 38.761118, Longitude = -77.296552},
                new MapPoint(){Latitude = 38.760733, Longitude = -77.296949},
                new MapPoint(){Latitude = 38.760332, Longitude = -77.296562}
            },
            Techniques = new List<string>()
            {
                "Speed Worm",
                "Swim Jig",
                "Tokyo Rig",
                "Soft Plastic JerkBait",
                "Neko Rig",
                "Shallow CrankBaits",
                "Wacky Rig"
            }
            
        });
        
        displayModels[0].Hotspots.Add(new FisheryHotspotDisplayModel()
        {
            Species = "Bass",
            Season = "Spring",
            Coordinates = new List<MapPoint>()
            {
                new MapPoint(){Latitude = 38.763636, Longitude = -77.297893},
                new MapPoint(){Latitude = 38.763410, Longitude = -77.298665},
                new MapPoint(){Latitude = 38.762934, Longitude = -77.298537},
                new MapPoint(){Latitude = 38.762925, Longitude = -77.297485}
            },
            Techniques = new List<string>()
            {
                "Speed Worm",
                "Swim Jig",
                "Tokyo Rig",
                "Soft Plastic JerkBait",
                "Neko Rig",
                "Shallow CrankBaits"
            }
            
        });
        
        
        //38.742006, -77.387581 - Bull Run
        displayModels.Add(new FisheryServiceDisplayModel()
        {
            Name = "Bull Run",
            Latitude = 38.742006,
            Longitude = -77.387581,
            Active = true,
            Nonce = "jXfQEh8DJYgNTw",
        });
        
        //38.676400, -77.166491 - Pohick Bay
        displayModels.Add(new FisheryServiceDisplayModel()
        {
            Name = "Pohick Bay",
            Latitude = 38.676400,
            Longitude = -77.166491,
            Active = true,
            Nonce = "MgV8nEzHHfCqlA"
        });
        
        //38.680453, -77.253105 - Occoquan
        displayModels.Add(new FisheryServiceDisplayModel()
        {
            Name = "Occoquan",
            Latitude = 38.680453,
            Longitude = -77.253105,
            Active = true,
            Nonce = "sbENw0V0XqvrQw"
        });
        
        //38.326407, -75.091446 - Ocean City
        displayModels.Add(new FisheryServiceDisplayModel()
        {
            Name = "Ocean City",
            Latitude = 38.326407,
            Longitude = -75.091446,
            Active = true,
            Nonce = "jTwiBXzREcfyQ"
        });
        
        //39.559366, -121.457063 - Lake Oroville
        displayModels.Add(new FisheryServiceDisplayModel()
        {
            Name = "Lake Oroville",
            Latitude = 39.559366,
            Longitude = -121.457063,
            Active = true,
            Nonce = "SJn4TAkdkThabA"
        });
        
        //39.795158, -122.357433 - Black Butte Lake 
        displayModels.Add(new FisheryServiceDisplayModel()
        {
            Name = "Black Butte Lake",
            Latitude = 39.795158,
            Longitude = -122.357433,
            Active = true,
            Nonce = "DQY4AbAAd2l9Ew"
        });
        
        return displayModels;

    }

    public FisheryServiceDisplayModel? GetFishery(string nonce)
    {
        //TODO - Plug this into a real database pull when the time comes
        return GetAllActiveFisheries().FirstOrDefault(x => x.Nonce == nonce);
    }
}