using System;
/* It is used to create a duplicate objects or clone of current object.
 * It provides an interface for creating a part of a product. 
 */
namespace DesignPatterns
    {
    public interface IEmployee
        {
        IEmployee Clone ();
        string GetDetails ();
        }

    public class Developer : IEmployee
        {
        public string Name
            {
            get;set;
            }
        public string Role
            {
            get;set;
            }
        public string PreferredLanguage
            {
            get;set;
            }
       public IEmployee Clone ()
            {
            return (IEmployee) MemberwiseClone();
            }
        public string GetDetails ()
            {
            return $"{Name} - {Role} - {PreferredLanguage}";
            }
        }

    public class Typist : IEmployee
        {
        public string Name
            {
            get;set;
            }
        public string Role
            {
            get;set;
            }
        public string PreferredLanguage
            {
            get;set;
            }
        public IEmployee Clone()
            {
            return (IEmployee) MemberwiseClone();
            }
        public string GetDetails ()
            {
            return $"{Name} - {Role} - {PreferredLanguage}";
            }
        }
    public class PrototypePattern
        {
        public static void Main (string[] args)
            {
            Developer dev = new Developer();
            dev.Name = "Prasad";
            dev.Role = "Developer";
            dev.PreferredLanguage = "C#";

            Developer devCopy = (Developer)dev.Clone();
            Console.WriteLine(devCopy.GetDetails());
            
            Typist typist = new Typist();
            typist.Name = "Telkikar";
            typist.Role = "Typist";
            typist.PreferredLanguage = "English";

            Typist typistCopy = (Typist) typist.Clone();
            Console.WriteLine(typistCopy.GetDetails());

            Console.ReadKey();
            }
        }
    }
