using RestaurantService.Domain.Common.Base;

namespace RestaurantService.Domain.Shared.ValueObjects;

public class GeoLocation : ValueObject
{
    public GeoLocation(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }
    public double Latitude { get; private set; }
    public double Longitude { get; private set; }
    

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Latitude;
        yield return Longitude;

    }
}
