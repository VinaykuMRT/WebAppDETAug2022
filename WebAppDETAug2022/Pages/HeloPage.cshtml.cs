using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;
using WebAppDETAug2022.Services;

namespace WebAppDETAug2022.Pages
{
    public class HeloPageModel : PageModel
    {
       // public Helo1 ob { get; set; }
      //  public Helo2 ob { get; set; }

        public string Message { get; set; }
        public void OnGet()
        {
       //     ob = new Helo2();
       //     Message = ob.SayHelo("vinsy");
        }
    }
}
