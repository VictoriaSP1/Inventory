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
        public DateTime LastUpdate { get; set; }

        public int PartialQuantity { get; set; }

        //Un producto, multiples almacenamientos
        public string ProductId { get; set; }
        public ProductEntity Product { get; set; }

        //Muchos almacenamientos, una bodega
        public string WarehouseId { get; set; }
        public WarehouseEntity Warehouse { get; set; }

        //Un almacenamiento, muchas entradas/salidas
        public ICollection<InputOutputEntity> InOut { get; set; }

    }
}
