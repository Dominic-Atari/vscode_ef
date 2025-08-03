
// Import EF Core namespace for DbContext and related features
using Microsoft.EntityFrameworkCore;

// The application's database context, manages entity classes and database connection
public class AppDbContext : DbContext
{
    // Represents the Authors table in the database
    public DbSet<Author> Authors { get; set; }

    // Configures the database connection to use MySQL
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        // Replace the connection string with your actual MySQL credentials
        => options.UseMySQL("server=localhost;database=dbschema;user=dbschema;password=dbschema;");
}
// to use MySQL, you need to install the MySQL.EntityFrameworkCore package
// run this in terminal dotnet ef migrations add InitialCreate
// there was an error and I run dotnet tool install --global dotnet-ef
// then run dotnet ef database update
// at this point, you need to create schema in MySql with previlages, password and user and if you want link it to Dbeaver
// then you can run the command dotnet ef migrations add InitialCreate
// and then dotnet ef database update
// to update the database with the latest changes in the model



// to work with api
// run this in terminal dotnet add package Microsoft.AspNetCore.Mvc
