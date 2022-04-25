using Microsoft.AspNetCore.Mvc.Rendering;

namespace Prueba.Models.ViewModels
{
    public class CustomerCreation
    {
        public Customer Customer { get; set; }
        public List<SelectListItem> CustomerTypes { get; set; }
    }
}
