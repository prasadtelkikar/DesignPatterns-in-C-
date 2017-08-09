using System;
using System.Collections.Generic;
/*BuilderDesignPattern: Builder pattern builds a complex object by using step by step approach.
 * Builder interface defines the steps to build the final object. Builder is independent from object creation process
 */
namespace DesignPatterns.Creational
    {
    /// <summary>
    /// Vehicle base class - Product
    /// </summary>
    public class Vehicle
        {
        public string Model
            {
            get;
            set;
            }
        public string TopSpeed
            {
            get;
            set;
            }
        public string Body
            {
            get;
            set;
            }
        public List<string> Accessories
            {
            get;
            set;
            }
        public Vehicle ()
            {
            Accessories = new List<string>();
            }
        public void ShowInfo ()
            {
            Console.WriteLine($"Model :{Model}");
            Console.WriteLine($"Top speed :{TopSpeed}");
            Console.WriteLine($"Body: {Body}");
            Console.WriteLine("Accessories");
            foreach ( string acc in Accessories )
                {
                Console.WriteLine($"\t{acc}");
                }
            }
        }

    /// <summary>
    /// Builder Interface - Interface for the product
    /// </summary>
    public interface IVehicleBuilder
        {
        void SetModel ();
        void SetTopSpeed ();
        void SetBody ();
        void SetAccessories ();
        Vehicle GetObject ();
        }

    /// <summary>
    /// Consumer fo Builder interface - Implementation of different products
    /// </summary>
    public class HeroVehicle : IVehicleBuilder
        {
        Vehicle heroVehicle = new Vehicle();
        public void SetModel ()
            {
            heroVehicle.Model = "Hero Passion";
            }
        public void SetTopSpeed ()
            {
            heroVehicle.TopSpeed = "125 km/hr";
            }
        public void SetBody ()
            {
            heroVehicle.Body = "Metal";
            }
        public void SetAccessories ()
            {
            heroVehicle.Accessories.Add("Mirrors");
            heroVehicle.Accessories.Add("Seat cover");
            }
        public Vehicle GetObject ()
            {
            return heroVehicle;
            }
        }

    /// <summary>
    /// Builder interface
    /// </summary>
    public class HondaVehicle : IVehicleBuilder
        {
        Vehicle heroVehicle = new Vehicle();
        public void SetModel ()
            {
            heroVehicle.Model = "Unicorn";
            }
        public void SetTopSpeed ()
            {
            heroVehicle.TopSpeed = "150 km/hr";
            }
        public void SetBody ()
            {
            heroVehicle.Body = "Metal";
            }
        public void SetAccessories ()
            {
            heroVehicle.Accessories.Add("Mirrors");
            heroVehicle.Accessories.Add("Seat cover");
            }
        public Vehicle GetObject ()
            {
            return heroVehicle;
            }
        }
    public class VehicleCreator
        {
        private readonly IVehicleBuilder objBuilder;
        public VehicleCreator (IVehicleBuilder obj)
            {
            objBuilder = obj;
            }
        public void CreateVehicle ()
            {
            objBuilder.SetBody();
            objBuilder.SetTopSpeed();
            objBuilder.SetModel();
            objBuilder.SetAccessories();
            }
        public Vehicle GetVehicle ()
            {
            return objBuilder.GetObject();
            }
        }

    /// <summary>
    /// Client
    /// </summary>
    class BuildDesignPattern
        {
        public static void Main (string[] args)
            {
            var heroVehicleCreator = new VehicleCreator(new HeroVehicle());
            heroVehicleCreator.CreateVehicle();
            var obj = heroVehicleCreator.GetVehicle();

            obj.ShowInfo();

            Console.WriteLine("----------------------------------------");
            var vehicleCreator = new VehicleCreator(new HondaVehicle());
            vehicleCreator.CreateVehicle();
            var hondaObj = vehicleCreator.GetVehicle();

            hondaObj.ShowInfo();

            Console.ReadKey();
            }
        }
    }
