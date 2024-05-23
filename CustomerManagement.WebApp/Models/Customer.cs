using System.ComponentModel.DataAnnotations;

public class Customer
{
    public int Id { get; set; }

    [Display(Name = "First Name")]
    [Required]
    public string FirstName { get; set; }

    [Display(Name = "Last Name")]
    [Required]
    public string LastName { get; set; }

    [Display(Name = "Email")]
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}
