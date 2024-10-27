using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace ApiAuth.Models;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Avatar { get; set; }
    public string Nickname { get; set; }
    
    [NotMapped]
    public string FullName => $"{FirstName} {LastName}";
}