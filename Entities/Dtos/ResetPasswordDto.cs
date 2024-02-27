using System.ComponentModel.DataAnnotations;

namespace Entities;

public record ResetPasswordDto
{
    public string? UserName { get; init; }

    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Password is required.")]
    public string? Password { get; init; }

    [DataType(DataType.Password)]
    [Required(ErrorMessage = "ConfirmPassword is required.")]
    [Compare("Password", ErrorMessage = "The passwords you entered do not match. Please re-enter your password.")]
    public string? ConfirmPassword { get; init; }
}
