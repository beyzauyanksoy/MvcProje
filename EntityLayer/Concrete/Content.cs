using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Content
    {
        [Key]
        public int ContentID { get; set; }

        [StringLength(1000)]
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }

        //Content yazar
        //Content başlık
        public bool ContentStatus { get; set; }

        //heading ilişkisi
        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }

        //writer ilişkisi
       public int? WriterID { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
