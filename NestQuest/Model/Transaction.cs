using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestQuest.Model
{

    //
    public class Transaction
    {

        [Key,Column(Order =0)]
        public int PropertyId { get; set; }
        [Key, Column(Order = 1)]
        public int ClientId { get; set; }
        public string Type { get; set; }// rent or buy
        

        public DateTime? TransDate { get; set; }

        [ForeignKey("PropertyId")]
        public virtual Properties Property { get; set; }
        [ForeignKey("ClientId")]
        public virtual User Client { get; set; } 


    }
}
