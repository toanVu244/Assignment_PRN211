using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class OrderInfo
    {
        public OrderInfo()
        {
            OrderDetails = new HashSet<OrderDetail>();
            Payments = new HashSet<Payment>();
        }

        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public string? OrderStatus { get; set; }
        public string? Address { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public string? Country { get; set; }
        public string? Method { get; set; }
        public int? Rating { get; set; }
        public string? Description { get; set; }

        public virtual Account User { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
