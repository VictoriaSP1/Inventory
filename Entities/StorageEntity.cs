using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }

        [Required]
        [StringLength(100)]
        public string StorageName { get; set; }

        public int TotalQuantity { get; set; }
    }
}
