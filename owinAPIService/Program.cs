using System;
using Microsoft.Owin.Hosting;
using System.Data.Entity;
using owinAPIService.Model;

namespace owinAPIService
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up and seed the database:
            Console.WriteLine("Initializing and seeding database...");
            Database.SetInitializer(new ApplicationDbInitializer());
            var db = new ApplicationDbContext();
            Console.WriteLine("Initializing and seeding database with company records...");

            // Specify the URI to use for the local host:
            string baseUri = "http://localhost:8080";

            Console.WriteLine("Starting web Server...");
            WebApp.Start<Startup>(baseUri);
            Console.WriteLine("Server running at {0} - press Enter to quit. ", baseUri);
            Console.ReadLine();
        }
    }
}