using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppDETAug2022.Pages
{
    public class helowebModel : PageModel
    {
        public string Message { get; private set; }
        public int Discount { get; set; }

        public void OnGet()
        {
            Message = "ASP.Net core Rocking !! ";
            Discount = 10;
        }
    }
}
