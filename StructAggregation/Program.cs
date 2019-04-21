using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Trainee train = new Trainee();
            string trFN = train.TraineeName("Alex", "Saltykov");
            train.email = "SaltykovAlexx@gmail.com";
            train.gitHub = "https://github.com/SaltykovAlexx?tab=repositories";
            Group gr = new Group("DevOps-159", train);
            Console.WriteLine();
            Console.WriteLine("{0} ({1}) is a student of {2}", trFN, train.email, gr.groupName);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
