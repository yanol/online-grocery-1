using System;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using GroceryServiceProject.Models;
using MyConsoleApp.Data;

namespace GroceryServiceProject {

    public class GroceryWorkflow
    {
        public List<ProductCategory> Categories { get;set;}

        public void Connect()
        {
            var connectionString = "Database=grocery;Server=.;user=SA;password=Q123rewq;TrustServerCertificate=True;MultiSubnetFailover=True;";

            using (var conn = new SqlConnection(connectionString))
            {
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                optionsBuilder.UseSqlServer(connectionString);
                //_context = new ApplicationDbContext(optionsBuilder.Options); 

                conn.Open();  // Open the connection  
                using (var context = new AppDbContext(optionsBuilder.Options))
                {
                    Categories = context.CategorySet.ToList(); 
                    foreach (var category in Categories)
                        {
                            Console.WriteLine($"Id: {category.id}, Name: {category.name}");
                        }
                }
                conn.Close(); // Close the connection  
            }
        }
    }
}