using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class InputOutputEntity
    {
        [Key]
        [StringLength(50)]
        public string InputOutputId { get; set; }

        [Required]
        public DateTime InputOutputDate { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public bool IsInput { get; set; }

        //Un almacenamiento, muchas entradas/salidas
        public string StorageId { get; set; }
        public StorageEntity Storage { get; set; }

    }
}
