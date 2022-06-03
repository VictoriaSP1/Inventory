using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class ProductEntity
    {
        [Key]
        [StringLength(10)]
        public string ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        [StringLength(600)]
        public string ProductDescription { get; set; }

        public int TotalQuatity { get; set; }

        //Una categoría para muchos productos
        public string CategoryId { get; set; }
        public CategoryEntity Category { get; set; }

        //Un producto, multiples almacenamientos
        public ICollection<StorageEntity> Storages { get; set; }

    }
}
