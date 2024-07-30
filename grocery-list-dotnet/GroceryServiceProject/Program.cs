using System;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyConsoleApp.Data;

class Program
{
    static void Main(string[] args)
    {
        //var host = CreateHostBuilder(args).Build();

        var connectionString = "Database=grocery;Server=.;user=SA;password=Q123rewq;TrustServerCertificate=True;MultiSubnetFailover=True;";
        using (var conn = new SqlConnection(connectionString))
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            //_context = new ApplicationDbContext(optionsBuilder.Options); 

            conn.Open();  // Open the connection  
            using (var context = new AppDbContext(optionsBuilder.Options))
            {
                   var categories = context.CategorySet.ToList(); 
                   foreach (var category in categories)
                    {
                        Console.WriteLine($"Id: {category.id}, Name: {category.name}");
                    }
            }
            conn.Close(); // Close the connection  
        }
    }

        /* using (var scope = host.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            var context = services.GetRequiredService<AppDbContext>();

            // Query data
            var categories = context.CategorySet.ToList();
            //var productDetails = context.ProductDetails.Include(p => p.ProductCategory).ToList();

            Console.WriteLine("Product Categories:");
            foreach (var category in categories)
            {
                Console.WriteLine($"Id: {category.CategoryId}, Name: {category.CategoryName}");
            }

            /* Console.WriteLine("\nProduct Details:");
            foreach (var product in productDetails)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Category: {product.ProductCategory.Name}");
            } */
    

    static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
               var connectionString = "Database=grocery;Server=localhost;user=SA;password=Q123rewq";
                //var connectionString = ConfigurationManager.ConnectionStrings["AppDbContext"].ConnectionString;
                services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer(connectionString));
            });
}
