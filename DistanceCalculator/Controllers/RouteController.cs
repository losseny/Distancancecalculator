using System.Diagnostics.CodeAnalysis;
using DistanceCalculator.Model;
using Flurl.Http;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace DistanceCalculator.Controllers;

[ApiController]
[Route("[controller]")]
[EnableCors("MyPolicy")]
public class BingMapsController : ControllerBase
{

    [HttpGet]
    [SuppressMessage("ReSharper.DPA", "DPA0011: High execution time of MVC action", MessageId = "time: 928ms")]
    public Task<BingMapsApiResponse> Get([FromQuery(Name = "departure")] string departure, [FromQuery(Name = "destination")] string destination)
    {
        const string bingMapsKey = "Ahk8EB2_cVR61M2LUmpPOaN3AcRhaghzXYGAlqVWivCQfOfNR8x-0ls51WEo-PVF";
        var url = $"http://dev.virtualearth.net/REST/V1/Routes?wayPoint.1={departure}&wayPoint.2={destination}&key={bingMapsKey}";
        return url.GetJsonAsync<BingMapsApiResponse>();
    }

}
