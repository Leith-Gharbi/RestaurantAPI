﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Models
{
    public class OrderMaster
    {
        [Key]
        public long OrderMasterId { get; set; }
        [Column(TypeName="nvarchar(75)")]
        public string OrderNumber { get; set; }
        
        public int CustomerId { get; set; }
        // We added this line below to set the foreign keys
        public Customer Customer { get; set; }

        [Column(TypeName = "nvarchar(75)")]
        public string PMethod { get; set; }

        public decimal GTotal { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        [NotMapped]
        public String  DeletedOrderItemIds { get; set; }

    }
}
