using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StepUp.Pages.main
{
    public class verifyModel : PageModel
    {
        [BindProperty]
        public bool Verify { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (Verify == false)
            {
                return Page();
            }

            return RedirectToPage("open");
        }
    }
}