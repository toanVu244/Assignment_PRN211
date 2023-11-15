using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Equipment
    {
        public Equipment()
        {
            ProductEquipments = new HashSet<ProductEquipment>();
        }

        public string EquipmentId { get; set; } = null!;
        public string? Name { get; set; }
        public string? Type { get; set; }

        public virtual ICollection<ProductEquipment> ProductEquipments { get; set; }
    }
}
