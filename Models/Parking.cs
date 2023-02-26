namespace ParkingSystem.Models;
public class Parking
{
    // attributes
    public string OwnerName { get; }
    public string LicencePlate { get; }
    DateTime Time { get; set; }

    public Parking(string ownerName, string licencePlate)
    {
        decimal valuePerHour = Convert.ToDecimal(3.00);
        OwnerName = ownerName;
        LicencePlate = licencePlate;
    }

    private List<Parking> allVehicles = new List<Parking>();

    // methods
    public void ChekinVehicle(string owner, string licencePlate)
    {
        var checkin = new Parking(owner, licencePlate);
        checkin.Time = DateTime.Now;
        allVehicles.Add(checkin);
    }

    public void VehicleList()
    {
        if (allVehicles.Any())
        {
            Console.WriteLine("\nVEHICLE LIST");
            Console.WriteLine("------------");
            Console.WriteLine("Entry Time\t\tOwner\t\tLicence Plate");
            {
                foreach (var item in allVehicles)
                {
                    Console.WriteLine($"{item.Time.ToShortTimeString()}\t\t{item.OwnerName}\t\t{item.LicencePlate}");
                }
                Console.WriteLine("\n");
            }
        }
        else
        {
            Console.WriteLine("There are no open-entry vehicles in the parking lot.\n");
        }
    }
}