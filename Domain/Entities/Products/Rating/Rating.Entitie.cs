public class RatingEntitie{
    public string ID { get; set;} = Guid.NewGuid().ToString();
    public float Rate {get; set;}
    public string Comment {get; set;} = null!;
    public string[] PicUrl {get; set;} = null!; 

    public string IdProduct {get; set;} = null!;
    public Product product {get; set;} = null!;
    public string IdUser {get; set;} = null!;
    public UserEntitie userEntitie {get; set;} = null!;
}