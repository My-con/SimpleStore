using System.Diagnostics.CodeAnalysis;

public class Product{
    public string ID { get; set;} = Guid.NewGuid().ToString();
    public required string Title {get; set;}
    public required string[] PicUrl {get; set;}
    public float Price {get;set;}
    public float Discount {get; set;}
    public required string Description{get; set;}

    public List<RatingEntitie> Rating {get; set;}  = [];
    
}