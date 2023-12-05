﻿using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public string? ProductId { get; set; }
        public int? Quantity { get; set; }

        public virtual OrderInfo Order { get; set; } = null!;
        public virtual Product? Product { get; set; }
    }
}
