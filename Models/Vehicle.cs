namespace ParkingSystem.Models;

public class Vehicle
{
    public string Owner { get; set; }
    public string LicencePlate { get; }
    public DateTime Time { get; }

    public Vehicle( string owner, DateTime time, string licencePlate )
    {
        Owner = owner;
        Time = time;
        LicencePlate = licencePlate;
    }
}