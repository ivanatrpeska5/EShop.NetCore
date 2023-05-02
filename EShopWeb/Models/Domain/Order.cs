using EShopWeb.Models.Identity;
using System;
using System.Collections.Generic;

namespace EShopWeb.Models.Domain
{
	public class Order
	{
		public Guid Id { get; set; }
		public string UserId { get; set; }
		public EShopApplicationUser User { get; set; }
		public virtual ICollection<ProductInOrder> ProductInOrders { get; set; }

	}
}
