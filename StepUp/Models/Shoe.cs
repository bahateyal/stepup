using System.Xml.Linq;

namespace StepUp.Models
{
    public class Shoe
    {
        public string Gender { get; set; }
        public string Category { get; set; }
        public string AgeGroup { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }


        public Shoe(string gender, string category, string ageGroup, decimal price, string imageUrl, string name)
        {
            Gender = gender;
            Category = category;
            AgeGroup = ageGroup;
            Price = price;
            ImageUrl = imageUrl;
            Name = name;

        }

        public override string ToString()
        {
            return $"{Gender} | {Category} | {AgeGroup} | {Price:C} | {ImageUrl}";
        }
    }
}
