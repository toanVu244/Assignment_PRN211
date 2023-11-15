﻿using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
            ProductEquipments = new HashSet<ProductEquipment>();
        }

        public string ProductId { get; set; } = null!;
        public string? ProductName { get; set; }
        public string? BirdType { get; set; }
        public string? Model { get; set; }
        public decimal? Price { get; set; }
        public string? Description { get; set; }
        public int? Status { get; set; }
        public int? Size { get; set; }
        public string? ProductMaterial { get; set; }
        public string? BirdCageType { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ProductEquipment> ProductEquipments { get; set; }
    }
}
