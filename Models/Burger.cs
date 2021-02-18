namespace csharp_burgershack.Models
{
  public class Burger
  {
    public Burger(string name, string description, int price)
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
    public int Price { get; set; }
    public int Id { get; set; }
  }
}