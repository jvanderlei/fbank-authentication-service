using Domain;
namespace AuthenticationService.Tests;

public class UserRegister
{
    [Fact]
    public void UserSubmitInfo_ShouldReturnCorrectInfo()
    {
        var user = new User();
        user.Register(fullname, DOB, CPF, POA, Cellphone,email, password);

        Assert.Equal(user.Name, "João");
        Assert.Equal(user.DateOfBirth, DOB);
        Assert.Equal(user.CPF, cpf);
        Assert.Equal(user.POA, POA);
        Assert.Equal(user.Cellphone, Cellphone);
        Assert.Equal(user.Email, email);
    }



}
