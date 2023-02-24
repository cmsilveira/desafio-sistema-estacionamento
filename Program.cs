public class Program
{
    static void Main()
    {
        bool endApp = false;

        Console.WriteLine( "Console Mode Parking System\r" );
        Console.WriteLine( "---------------------------\n" );

        while( !endApp )
        {
            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\t[1] - Check in vehicle");
            Console.WriteLine("\t[2] - Check out vehicle");
            Console.WriteLine("\t[3] - Vehicle list");
            Console.WriteLine("\t[4] - Close");
            Console.Write("Your option? ");

            string option = Console.ReadLine();

            switch( option )
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
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