using System;

namespace EShopWeb.Models.Domain
{
	public class ProductInOrder
	{
		public Guid ProductId { get; set; }
		public virtual Product SelectedProduct { get; set; }

		public Guid OrderId { get; set; }
		public virtual Order UserOrder { get; set; }
	}
}
