using EShopWeb.Models.Identity;
using System;
using System.Collections;
using System.Collections.Generic;

namespace EShopWeb.Models.Domain
{
    public class ShoppingCart
    {
        public Guid Id { get; set; }
        public string OwnerId { get; set; }
        public EShopApplicationUser Owner { get; set; }
        public virtual ICollection<ProductInShoppingCart> ProductInShoppingCarts { get; set; }
    }
}
