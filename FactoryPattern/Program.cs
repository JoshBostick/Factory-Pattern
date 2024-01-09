namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tires for the vehicle to you want to drive: ");
            var input = int.Parse(Console.ReadLine());

            var vehicle = VehicleFactory.GetVehicle(input);
            vehicle.Drive();
                        
        }
    }
}
