namespace WantedClothingStore.Models
{
    public abstract class ProductBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Size { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}