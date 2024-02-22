using Domain;
namespace AuthenticationService.Tests;

public class UserRegister
{
    [Fact]
    public void UserSubmitName_ShouldReturnCorrectName()
    {
        var user = new User();
        user.Name = "João";

        Assert.Equal(user.Name, "João");
    }

    [Theory]
    [InlineData("joao@gmail.com", true)]
    [InlineData("xpto", false)]
    public void WhenUserSubmitValidEmail_ShouldReturnIfItsValid(string email, bool isValid)
    {
        var user = new User();
        bool emailIsValid = user.CheckValidEmail(email);

        Assert.Equal(emailIsValid, isValid);
    }
}
