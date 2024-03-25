using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using System.Text;

public class UserEntitie : BaseTimeEntitie
{
    private string _password = null!;

    [Required]
    [Key]
    public string ID { get; set;} = Guid.NewGuid().ToString();

    [NotNull]
    [Required]
    [EmailAddress]
    [RegularExpression(@"^([\w\-]+\.)*[\w\- ]+@([\w\- ]+\.)+([\w\-]{2,3})$", ErrorMessage = "Digite no formato correto")]
    public string Email { get; set; } = null!;

    [NotNull]
    [RegularExpression(@"^\w{4,10}$ ^[a-zA-Z]\w{3,9}$ ^[a-zA-Z]\w*\d+\w*$", ErrorMessage ="Use uma senha um pouco mais forte!")]
    public string Password
    {
        get { return _password; }
        set
        {
            byte[] CalcMD5 = Encoding.ASCII.GetBytes(value + "Salt");
            _password = BitConverter.ToString(MD5.Create().ComputeHash(CalcMD5)).Replace("-", "");
        }
    }

    [DataType(DataType.ImageUrl)]
    public string? UrlPicture;


    public ProfileEntitie ProfileEntitie {get; set;} = new ProfileEntitie();
    public List<RatingEntitie> Rating {get; set;}  = [];

}