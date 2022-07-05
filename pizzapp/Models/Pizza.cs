using System.ComponentModel.DataAnnotations;

namespace pizzapp.Models;

public class Pizza
{
    public int PizzaId { get; set; }
    [Display(Name= "Nom")]
    public string Name { get; set; }
    [Display(Name= "Prix")]
    public float Price { get; set; }
    [Display(Name= "Vegan")]
    public bool Vegan { get; set; }
    [Display(Name= "Ingrédients")]
    public string Ingredients { get; set; }
}