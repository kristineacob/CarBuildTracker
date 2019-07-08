using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuildTracker
{
    class Program
    {
        static void Main(string[] args)
        {


            ////Object = instance of a class
            //var customerBuild = new Build();
            //{
            //    customerBuild.CustomerName = "Kristine";
            //    customerBuild.VinNumber = 2064128746;
            //    customerBuild.YearMakeModel = 1992 Honda Civic;
            //};
            //customerBuild.Withdraw(250);
            //Console.WriteLine($"Build Number: {customerBuild.BuildNumber}," +
            //    $"Vin Number: {customerBuild.VinNumber}," +
            //    $"Balance: {customerBuild.Balance:C}," +
            //    $"Build Start Date: {customerBuild.BuildStartDate}");


            //var customerBuild2 = new Build();
            //{
            //    customerBuild2.CustomerName = "Thomas";
            //    customerBuild2.VinNumber = 2069474889;
            //    customerBuild2.YearMakeModel = 2006;
            //};
            //customerBuild.Withdraw(250);
            //Console.WriteLine($"Build Number: {customerBuild2.BuildNumber}," +
            //    $"Vin Number: {customerBuild2.VinNumber}," +
            //    $"Balance: {customerBuild2.Balance:C}," +
            //    $"Build Start Date: {customerBuild2.BuildStartDate}");

            Console.WriteLine("Welcome to Automotive Build Tracker!");
            while(true){ 
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Create a new build account");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3 Print all account information");

            var userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "Exit":
                        Console.WriteLine("Your Automotive Build is saved. Have a great day!");
                        return;
                    case "Create a New Build":
                        Console.Write("First and Last Name: ");
                        var customerName = Console.ReadLine();
                        Console.WriteLine("Account Types: ");
                        var accountTypes = Enum.GetNames(typeof(Type));
                        for (var i = 0; i < accountTypes.Length; i++)
                        {
                            Console.WriteLine($"{i}. {accountTypes[i]}");
                        }
                        Console.Write("Select an account type: ");
                        var accountType = Convert.ToInt32(Console.ReadLine());
                        var customerBuild = Tracker.CreateCustomerBuild(customerName);
                        Console.WriteLine($"Build Number: {customerBuild.BuildNumber}," +
                            $"Vin Number: {customerBuild.VinNumber}," +
                            $"Balance: {customerBuild.Balance:C}," +
                            $"Build Start Date: {customerBuild.BuildStartDate}");
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    default:
                        break;
                }
            }

        }


    }
}
