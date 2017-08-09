using System;
/* Represent basic functionality of Interface
 * Define couple of plans to achieve desire result depending on client request. 
 * Execute plan or algorithms at a run time.
 */
namespace DesignPatterns.Behavioral
    {
    /// <summary>
    ///Statergy context 
    /// </summary>
    public interface ICompanyPolicies
        {
        string DefinePolicies ();
        }

    /// <summary>
    ///Concreate stratergy
    /// </summary>
    public class SeniorSoftwareEngineer : ICompanyPolicies
        {
        public string DefinePolicies ()
            {
            return "Policies for senior software engineer";
            }
        }

    /// <summary>
    ///Concreate stratergy
    /// </summary>
    public class TeamLeadEngineer : ICompanyPolicies
        {
        public string DefinePolicies ()
            {
            return "Policies for Team lead engineer";
            }
        }

    /// <summary>
    ///Concreate stratergy
    /// </summary>
    public class AssociateEngineer : ICompanyPolicies
        {
        public string DefinePolicies ()
            {
            return "Policies for Associate software engineer";
            }
        }

    public class StratergyContext
        {
        ICompanyPolicies iCompanyPolicy;
        public StratergyContext (ICompanyPolicies iCompanyPolicy)
            {
            this.iCompanyPolicy = iCompanyPolicy;
            }
        public void DisplayPolicies ()
            {
            Console.WriteLine(this.iCompanyPolicy.DefinePolicies());
            }
        }

    /// <summary>
    /// Client
    /// </summary>
    public class StratergyDesignPattern
        {
        public static void Main (string[] args)
            {
            StratergyContext context = new StratergyContext(new SeniorSoftwareEngineer());
            Console.WriteLine("**************Policies for Senior software engineer***********");
            context.DisplayPolicies();
            Console.WriteLine();

            context = new StratergyContext(new TeamLeadEngineer());
            Console.WriteLine("**************Policies for team lead engineer***********");
            context.DisplayPolicies();
            Console.WriteLine();

            context = new StratergyContext(new AssociateEngineer());
            Console.WriteLine("**************Policies for associate software engineer***********");
            context.DisplayPolicies();
            Console.WriteLine();

            Console.ReadKey();
            }
        }
    }
