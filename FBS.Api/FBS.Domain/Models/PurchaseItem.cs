using System;

namespace FBS.Domain.Models
{
    public class PurchaseItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool MissingItem { get; set; }
        public Category Category {get; set;}
    }
}