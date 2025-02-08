using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestQuest.Model
{
    public class Properties
    {
        [Key]
        public int propId { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; } // rent or sale
        public string Location { get; set; }
        public string Area { get; set; }
        public DateTime CreatedAt { get; set; }
   

        [ForeignKey("Owners")]
        public int? ownerId { get; set; }

        public virtual ICollection<Transaction> transactions { get; set; }
        public virtual ICollection<PropertyImage> ProperityImages { get; set; }
        
        public virtual User Owner { get; set; }

    }
}
