namespace DistanceCalculator.Model;

public class BingMapsApiResponse
{
    public string AuthenticationResultCode { get; set; }
    public List<ResourceSet> ResourceSets { get; set; }
    public int StatusCode { get; set; }
    public string StatusDescription { get; set; }
    public string TraceId { get; set; }
}
