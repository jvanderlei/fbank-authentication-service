using Domain;
namespace AuthenticationService.Tests;

public class UserRegister
{
    [Fact]
    public void WhenSubmitValidUserInfo_ShouldAllowToRegister(){
        string Name = "João Pedro Vanderlei";
        string DateOfBirth = "02/01/2003";
        string Address = "Av. Marechal Fiuza de Castro";
        string CPF = "386.778.230-00";
        string AnualSalary = "100.000,00";

        var user = new User();

        Assert.Equal(Name, user.Name);
    }
}
