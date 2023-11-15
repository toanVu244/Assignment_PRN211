using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class ProductEquipment
    {
        public string ProductEquipmentId { get; set; } = null!;
        public string? ProductId { get; set; }
        public string? EquipmentId { get; set; }

        public virtual Equipment? Equipment { get; set; }
        public virtual Product? Product { get; set; }
    }
}
