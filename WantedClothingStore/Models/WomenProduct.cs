namespace WantedClothingStore.Models
{
    public class WomenProduct : ProductBase
    {
        public string DressType { get; set; } // Example: Casual, Formal, Party
        public string FabricType { get; set; } // Example: Cotton, Polyester, Silk
        public string Color { get; set; } // Example: Red, Blue
        public bool IsPopularItem { get; set; } // Example: true or false

        // Add CategorySpecificAttribute if it's needed
        public string CategorySpecificAttribute { get; set; }
    }
}