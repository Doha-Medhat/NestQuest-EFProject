using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestQuest.Model
{
    internal class Client
    {
        [Key]
        public int clientId { get; set; }
        public string FullName { get; set; }
        [Phone]
        public string PhoneNumper { get; set; }
        [EmailAddress]
        public string Emai { get; set; }
        [ForeignKey("InterestedPropId")]
        public Properties InterestedProp { get; set; }


        //navigation one to many
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}

