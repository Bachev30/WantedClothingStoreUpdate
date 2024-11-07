using WantedClothingStore.Data;
using WantedClothingStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace WantedClothingStore.Services
{
    public class ProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<MenProduct> GetMenProducts(string size = null)
        {
            return string.IsNullOrEmpty(size) ?
                _context.MenProducts.ToList() :
                _context.MenProducts.Where(p => p.Size == size).ToList();
        }

        public IEnumerable<WomenProduct> GetWomenProducts(string size = null)
        {
            return string.IsNullOrEmpty(size) ?
                _context.WomenProducts.ToList() :
                _context.WomenProducts.Where(p => p.Size == size).ToList();
        }

        internal string? GetAllProducts()
        {
            throw new NotImplementedException();
        }
    }
}
