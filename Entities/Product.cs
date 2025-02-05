﻿using csharp_api_aspnetcore_action_filters.Contracts;
using System.ComponentModel.DataAnnotations;

namespace csharp_api_aspnetcore_action_filters.Entities
{
	public class Product : IEntity
	{
		[Key]
		public int ProductId { get; set; }

		[Required(ErrorMessage = "Product code is required")]
		public int? ProductCode { get; set; } = null;

		[Required(ErrorMessage = "Product name is required")]
		public string? ProductName { get; set; } = null;
	}
}
