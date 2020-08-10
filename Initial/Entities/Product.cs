using System;
using System.ComponentModel.DataAnnotations;
using BakeSale.Core;

namespace BakeSale.BakeSaleApplication.Entities
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Money Price { get; set; }
    }
}