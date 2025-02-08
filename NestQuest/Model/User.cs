using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestQuest.Model
{
    internal class User
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
         
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }

        //Navigation Prop "one to many
        //owners
        public virtual ICollection<Properties> properties { get; set; }
        //clients
        public virtual ICollection<Transaction> Transactions { get; set; }

    }
}
