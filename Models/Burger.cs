namespace csharp_burgershack.Models
{
  public class Burger
  {
    public Burger(string name, string description, double price)
    {
      this.Name = name;
      this.Description = description;
      this.Price = price;
    }
    public Burger()
    {

    }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int Id { get; set; }
  }
}