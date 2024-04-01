﻿using System.ComponentModel.DataAnnotations.Schema;

namespace be_shop.Entites
{
    [Table("customer")]
    public class Customer: IAuditableEntity
    {
        public string? name { get; set; }
        public string? code { get; set; }
        public string? phone { get; set; }
        public int? province_code { get; set; }  // code tỉnh
        public string? email { get; set; }
        public string? address { set; get; }
        public int count_purchases { get; set; } = 0;
        public double total_price { get; set; } = 0;
    }
}
