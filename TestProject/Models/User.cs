using System.ComponentModel.DataAnnotations;

namespace TestProject.Models;

public class User
{
    public int Id { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string UserName { get; set; }

    [Required]
    public string Password { get; set; }

    [Required]
    public string Role { get; set; }

}