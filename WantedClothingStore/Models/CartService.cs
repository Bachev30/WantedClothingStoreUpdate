// CartService.cs
using WantedClothingStore.Models;
using System.Collections.Generic;

namespace WantedClothingStore.Services
{
    public class CartService
    {
        private readonly List<ProductBase> _cartItems = new List<ProductBase>();

        public void AddToCart(ProductBase product)
        {
            _cartItems.Add(product);
        }

        public void RemoveFromCart(int productId)
        {
            _cartItems.RemoveAll(p => p.Id == productId);
        }

        public List<ProductBase> GetCartItems()
        {
            return _cartItems;
        }

        public double GetTotalPrice()
        {
            double total = 0;
            foreach (var item in _cartItems)
            {
                total += item.Price;
            }
            return total;
        }

        public void ClearCart()
        {
            _cartItems.Clear();
        }
    }
}