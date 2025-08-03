
// Import ASP.NET Core MVC namespace for controller functionality
using Microsoft.AspNetCore.Mvc;

[ApiController] // Indicates this is an API controller
[Route("[controller]")] // Sets the route to /Authors (controller name)
public class AuthorsController : ControllerBase // Inherits from ControllerBase for API features
{
    // Field to hold the database context
    private readonly AppDbContext _context;

    // Constructor receives the AppDbContext via dependency injection
    public AuthorsController(AppDbContext context)
    {
        _context = context; // Assign the injected context to the field
    }

    // HTTP POST endpoint to create a new Author
    [HttpPost]
    public IActionResult Create(Author author)
    {
        // Add the new author to the Authors table
        _context.Authors.Add(author);
        // Save changes to the database
        _context.SaveChanges();
        // Return a 201 Created response with the new author's data
        return CreatedAtAction(nameof(Create), new { id = author.Id }, author);
    }
}