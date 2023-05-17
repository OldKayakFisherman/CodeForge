using FisheryMaps.Services;
using Microsoft.AspNetCore.Mvc;

namespace FisheryMaps.Controllers;

public class FisheryController : Controller
{

    private readonly FisheryService _fisheryService;
    
    public FisheryController
        (
            FisheryService fisheryService    
        )
    {
        _fisheryService = fisheryService;
    }
    
    // GET
    [HttpGet("/api/fisheries/all")]
    public IActionResult All()
    {
        return new JsonResult(_fisheryService.GetAllActiveFisheries());
    }
}