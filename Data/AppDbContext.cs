using ApiAuth.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApiAuth.Data;

public class AppDbContext : IdentityDbContext<ApplicationUser>
{
    public DbSet<Feedback> Feedbacks { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}