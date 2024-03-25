using Microsoft.EntityFrameworkCore;

public class SimpleDB : DbContext{
    public DbSet<UserEntitie> userEntities {get; set;}
    public DbSet<RatingEntitie> RatingEntities {get; set;}



    protected  override void OnConfiguring(DbContextOptionsBuilder Options) => Options.UseSqlite("Data Source=SimpleDB.db");
    
}