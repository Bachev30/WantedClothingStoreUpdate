namespace WantedClothingStore.Models
{
    public class MenProduct : ProductBase
    {
        public string ClothingType { get; set; } // Example: Shirt, Jeans, Jacket
        public string Material { get; set; } // Example: Denim, Cotton, Wool
        public string FitType { get; set; } // Example: Slim Fit, Regular Fit, Loose Fit
        public string Color { get; set; } // Example: Blue, Red
        public bool IsPopularItem { get; set; } // Example: true or false

        // Add CategorySpecificAttribute if it's needed
        public string CategorySpecificAttribute { get; set; }
    }
}

