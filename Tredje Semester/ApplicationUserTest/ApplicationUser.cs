using Microsoft.AspNetCore.Identity;
public class ApplicationUser : IdentityUser
{
    public string FName { get; set; }
    public string LName { get; set; }
}