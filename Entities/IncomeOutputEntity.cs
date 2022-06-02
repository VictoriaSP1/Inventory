using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class IncomeOutputEntity
    {
        [Key]
        [StringLength(50)]
        public string IncomeOutputId { get; set; }

        [Required]
        [StringLength(100)]
        public string IncomeOutputName { get; set; }

        public int IncomeQuantity { get; set; }
        public int OutputQuantity { get; set; }
        public int TotalQuantity { get; set; }
    }
}
