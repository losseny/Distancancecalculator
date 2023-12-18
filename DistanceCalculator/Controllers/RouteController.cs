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
    public async Task<BingMapsApiResponse> Get([FromQuery(Name = "departure")] string departure, [FromQuery(Name = "destination")] string destination)
    {
        const string bingMapsKey = "Ahk8EB2_cVR61M2LUmpPOaN3AcRhaghzXYGAlqVWivCQfOfNR8x-0ls51WEo-PVF";
        const string startPoint = "Schiedam Centrum, 3112 NA Schiedam";
        const string endPoint = "Muiderpoort, Sarphatistraat, 1018 AV Amsterdam";
        var url = $"http://dev.virtualearth.net/REST/V1/Routes?wayPoint.1={departure}&wayPoint.2={destination}&key={bingMapsKey}";

        Console.WriteLine(departure);
        Console.WriteLine(destination);
        Console.WriteLine(url);

        return await url.GetJsonAsync<BingMapsApiResponse>();
    }

}
