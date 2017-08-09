/*Factory method design pattern:
 * It is used to create an object. Standard way to create an object.
 * Interface is used for creating an object.
 */
using System;
namespace DesignPatterns.Creational
    {
    /// <summary>
    /// Factory interface
    /// </summary>
    public interface IFactory
        {
        void Drive (int distance);
        }
    
    /// <summary>
    /// A concreate product class
    /// </summary>
    public class Scooter : IFactory
        {
        public void Drive (int distance)
            {
            Console.WriteLine("Distance covered by scooter: " + distance);
            }
        }
    /// <summary>
    /// Concrete product class
    /// </summary>
    public class Bike : IFactory
        {
        public void Drive (int distance)
            {
            Console.WriteLine("Distance covered by Bike: " + distance);
            }
        }

    /// <summary>
    /// Creator abstract class
    /// </summary>
    public abstract class VahicleFactory
        {
        public abstract IFactory GetVehicleFactory (string vahicle);
        }

    /// <summary>
    /// Concrete class
    /// </summary>
    public class ConcreteVehicle : VahicleFactory
        {
        public override IFactory GetVehicleFactory (string vehicle)
            {
            switch ( vehicle )
                {
                case "Scooter":
                    return new Scooter();
                case "Bike":
                    return new Bike();
                default:
                    throw new ApplicationException("Wrong input");
                }
            }
        }

    /// <summary>
    /// Consumer class
    /// </summary>
    class FactoryDesingPattern
        {
        public static void Main (string[] args)
            {
            VahicleFactory vehicleObj = new ConcreteVehicle();
            IFactory scooter = vehicleObj.GetVehicleFactory("Scooter");
            scooter.Drive(20);

            IFactory bike = vehicleObj.GetVehicleFactory("Bike");
            bike.Drive(40);

            Console.ReadKey();
            }
        }
    }
