using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StepUp.Models;

namespace StepUp.Pages
{
    public class MenModel : PageModel
    {
        public List<Shoe> Shoes { get; set; }

        public string GetShoeImageUrl(string imagePath)
        {
            return $"~/images{imagePath}";
        }

        public void OnGet()
        {
            var shoesList = new List<Shoe>
        {
            new Shoe("men", "Nike Air Max", "adults", 299.99m, "\\picOfShoes\\ShoesForSale\\NikeAirMax.jpeg", "Nike Air Max"),

            new Shoe("men", "PUMAtraning", "adults", 299.99m, "\\picOfShoes\\ShoesForSale\\PumaRunning.jpeg", "PUMAtraning"),

            new Shoe("men", "UltraRun5", "adults", 150.99m, "\\picOfShoes\\ShoesForSale\\UltraRun5.jpg", "UltraRun5"),

            new Shoe("men", "UltraRun5", "adults", 150.99m, "\\picOfShoes\\ShoesForSale\\UltraRun5.jpg", "UltraRun5")
        };

            {

            }
            foreach (var shoe in shoesList)
            {
                Console.WriteLine(shoe.ToString());
            }

            Shoes = shoesList;
        }
    }
}
