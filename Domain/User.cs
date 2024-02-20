namespace Domain;

public class User
{
    public string Name {get; set;}
    private string DateOfBirth {get; set;}
    private string Address {get; set;}
    private string CPF {get; set;}
    private string AnualSalary {get; set;}

    public User()
    {
        this.Name = "João Pedro Vanderlei";
        this.DateOfBirth = "02/01/2003";
        this.Address = "Av. Marechal Fiuza de Castro";
        this.CPF = "386.778.230-00";
        this.AnualSalary = "100.000,00";
    }
}
