using System;
/* Main purpose: Object needs to be instantiated once.
 * Class needs to declare constructor private
 * Declare static function to return created instance.
 * Private constructor for avoiding creation of instance
 */
namespace DesignPatterns.Creational
    {
    public class SingletonDesignPattern
        {
        private static SingletonDesignPattern instanceOfSingleton = null;
        private SingletonDesignPattern ()
            {
            }
        public static SingletonDesignPattern GetInstance ()
            {
            if ( instanceOfSingleton == null )
                {
                instanceOfSingleton = new SingletonDesignPattern();
                }
            return instanceOfSingleton;
            }
        public void DisplayMessage ()
            {
            Console.WriteLine("Instance of singleton class is created");
            }
        }
    class Singleton
        {
        public static void Main (string[] args)
            {
            SingletonDesignPattern instance = SingletonDesignPattern.GetInstance();
            instance.DisplayMessage();
            Console.ReadKey();
            }
        }
    }
