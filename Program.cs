using ParkingSystem.Models;
public class Program
{
    static void Main()
    {
        // variables
        bool endApp = false;
        string ownerName = string.Empty;
        string licencePlate = string.Empty;

        Parking parking = new Parking(ownerName, licencePlate);

        // starts here
        Console.WriteLine("Console Mode Parking System\r");
        Console.WriteLine("---------------------------\n");

        while (!endApp)
        {
            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\t[1] - Check in vehicle");
            Console.WriteLine("\t[2] - Check out vehicle");
            Console.WriteLine("\t[3] - Vehicle list");
            Console.WriteLine("\t[4] - Close");
            Console.Write("Your option? ");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("CKECK-IN");
                    Console.WriteLine("--------\n");

                    Console.Write("Enter the licence plate: ");
                    licencePlate = Console.ReadLine();
                    Console.Write("Enter the name of the vehicle owner: ");
                    ownerName = Console.ReadLine();
                    parking.ChekinVehicle(ownerName, licencePlate);
                    break;
                case "2":
                    break;
                case "3":
                    parking.VehicleList();
                    break;
                case "4":
                    // Wait for the user to respond before closing
                    Console.Write("Press <Y> and <Enter> to close the app, or press any other key and <Enter> to continue: ");
                    if (Console.ReadLine() == "y")
                        endApp = true;
                    // end if
                    break;
                default:
                    Console.WriteLine("This is not valid input. Please enter a valid option!");
                    break;
                // end case
            }
        }
    }
}