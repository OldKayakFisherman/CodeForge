using CommonLib.Geospatial;

namespace FisheryMaps.Services;

public class FisheryServiceDisplayModel
{
    public string Name { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public bool Active { get; set; }
    public string Nonce { get; set; }
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