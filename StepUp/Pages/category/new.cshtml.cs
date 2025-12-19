using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StepUp.Models;

namespace StepUp.Pages
{
    public class NewModel : PageModel
    {
        public List<Shoe> Shoes { get; set; }



        public string GetShoeImageUrl(string imagePath)
        {
            // הנחה שהנתיב של התמונה נמצא בתיקייה נכונה וניתן להציג אותה
            return $"~/images{imagePath}";
        }

        public void OnGet()
        {
            var shoesList = new List<Shoe>
    {
        new Shoe("men", "Nike Air Max", "adults", 299.99m, "\\picOfShoes\\ShoesForSale\\NikeAirMax.jpeg", "Nike Air Max"),

        new Shoe("men", "Adidas Style", "adults", 299.99m, "\\picOfShoes\\ShoesForSale\\SuperStarAdidas.jpg", "Adidas Style"),

        


    };

            foreach (var shoe in shoesList)
            {
                Console.WriteLine(shoe.ToString());
            }

            Shoes = shoesList;
        }
    }
}