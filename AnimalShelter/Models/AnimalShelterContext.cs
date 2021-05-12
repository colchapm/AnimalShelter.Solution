using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }  //"items" was our table and we had "Items" "animals" is our table and we have "Animals"
                                                //Item thisItem = _db.Items.FirstOrDefault(item => item.ItemId == id);
    public AnimalShelterContext(DbContextOptions options) : base(options) { }
  }
}