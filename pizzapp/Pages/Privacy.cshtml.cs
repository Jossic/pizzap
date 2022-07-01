using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using pizzapp.Data;
using pizzapp.Models;


namespace pizzapp.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private DataContext _dataContext;

        public PrivacyModel(ILogger<PrivacyModel> logger, DataContext dataContext)
        {
            _logger = logger;
            _dataContext = dataContext;
        }

        public void OnGet()
        {
            // var pizza = new Pizza() { Name = "Reine", Price = 9 };
            // _dataContext.Pizzas.Add(pizza);
            // _dataContext.SaveChanges();
        }
    }
}
