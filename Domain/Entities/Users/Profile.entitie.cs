public abstract class Adress{
    public int CodeCity;
    public string? City;
    public string? Street;
    public int StreetNumber;
    public string? AdressType;
}

public class ProfileEntitie{
    public string? FirstName { get; set;}
    public string? LasttName { get; set;}
    public DateTime DateOfBirth;
    public Adress? Adress { get; set;}
    public int? PhoneNumber {get;set;}

    public string IdUser {get; set;}
    public UserEntitie userEntitie {get; set;} = null!;

}