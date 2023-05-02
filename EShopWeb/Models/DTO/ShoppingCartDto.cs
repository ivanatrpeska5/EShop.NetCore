using EShopWeb.Models.Domain;
using System.Collections.Generic;

namespace EShopWeb.Models.DTO
{
    public class ShoppingCartDto
    {
        public List<ProductInShoppingCart> Products { get; set; }

        public double TotalPrice { get; set; }
    }
}
