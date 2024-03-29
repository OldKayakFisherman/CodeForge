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
    [HttpGet("/apiv1/fisheries/all")]
    public IActionResult All()
    {
        return new JsonResult(_fisheryService.GetAllActiveFisheries());
    }

    //Get
    [HttpGet("/apiv1/fisheries/fishery/{fisheryNonce}")]  
    public IActionResult GetFishery(string fisheryNonce)
    {
        FisheryServiceDisplayModel? model = _fisheryService.GetFishery(fisheryNonce);
        
        return new JsonResult(_fisheryService.GetFishery(fisheryNonce));
    }
    
    [Route("/Fishery/Detail/{fisheryNonce}")]
    public IActionResult Detail(string fisheryNonce)
    {
        FisheryServiceDisplayModel? model = _fisheryService.GetFishery(fisheryNonce);
        
        return View(model);
    }
    
    [Route("/")]
}