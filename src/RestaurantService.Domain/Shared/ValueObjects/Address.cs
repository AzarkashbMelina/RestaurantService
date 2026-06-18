using RestaurantService.Domain.Common.Base;

namespace RestaurantService.Domain.Shared.ValueObjects;

public class Address : ValueObject
{
    public Address(string city, string townShip, string street, string unit,
        string number, string fullAddress, string location)
    {
        City = city;
        TownShip = townShip;
        Street = street;
        Unit = unit;
        Number = number;
        FullAddress = fullAddress;
        
        Location = Location ?? throw new ArgumentNullException(nameof(location));
    }
    public string City { get; private set; }
    public string TownShip { get; private set; } //shahrestan
    public string Street { get; private set; }
    public string Unit { get; private set; }
    public string Number { get; private set; }
    public string FullAddress { get; private set; }
    public string Location { get; private set; }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return City;
        yield return TownShip; //shahrestan
        yield return Street;
        yield return Unit; //vahed
        yield return Number; //pelak
        yield return FullAddress; //it should be execute from location automatically and editable
        yield return Location;
    }
}
