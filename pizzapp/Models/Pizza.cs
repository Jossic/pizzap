namespace pizzapp.Models;

public class Pizza
{
    public int PizzaId { get; set; }
    public string Name { get; set; }
    public float Price { get; set; }
    public bool Vegan { get; set; }
    public string Ingredients { get; set; }
}