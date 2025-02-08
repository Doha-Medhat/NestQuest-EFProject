using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestQuest.Model
{
    public class PropertyImage
    {
        [Key]
        public int ImgId { get; set; }
        public string ImgUrl { get; set; }
        public int PropId { get; set; }

        //Navigation "one to many"
        [ForeignKey("PropId")]
        public virtual Properties property { get; set; }
    }
}
