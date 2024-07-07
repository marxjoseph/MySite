using System.ComponentModel.DataAnnotations;

namespace MySite.Models;

public class LoginInformation
{
    [Required(ErrorMessage = "The username or password you entered does not exist.")]
    public string Username { get; set; } = string.Empty;
    [Required]
    public string Password { get; set; } = string.Empty;
}
