using EShopWeb.Models.Domain;
using System;

namespace EShopWeb.Models.DTO
{
    public class AddToShoppingCardDto
    {
        public Product SelectedProduct { get; set; }
        public Guid SelectedProductId { get; set; }
        public int Quantity { get; set; }
    }
}
