using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StefansSuperShop.Pages
{
    [BindProperties]
    public class SubsribeModel : BasePageModel
    {
        [EmailAddress]
        [Required]
        public string Epost { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                //Kolla om redan subscriber?
                //Om allt g�r bra - vad ska h�nda?
            }

            return Page();


        }
    }
}
