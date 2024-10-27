using ApiAuth.Data;
using ApiAuth.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ApiAuth.Controllers;

[ApiController]
[Route("[controller]")]
public class FeedbackController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;

    public FeedbackController(AppDbContext context, UserManager<ApplicationUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }
    
    [HttpGet]
    public IActionResult Index()
    {
        return Ok(_context.Feedbacks.ToArray());
    }

    /// <summary>
    /// Feedback güncellemesi yapar.
    /// </summary>
    /// <param name="id">Feedback ID'si.</param>
    /// <returns>Güncellenen feedback</returns>
    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody]Feedback model)
    {
        return Ok(id.ToString());
    }

    [HttpDelete]
    public IActionResult Delete()
    {
        return NoContent();
    }
}