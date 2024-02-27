using Microsoft.VisualBasic;

namespace Domain;

public class User
{
    public string Name {get; set;}    
    public string Email {get; set;}
    public User()
    {
    }

    public bool RegisterEmail(string email)
    {
        if(!email.Contains("@"))
            return false;
        Email = email;
        return true;

    }
}
