using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        [StringLength(50)]
        public string WriterName { get; set; }
        [StringLength(600)]
        public string WriterAbout { get; set; }
        public string WriterMail { get; set; }
        [StringLength(20)]
        public string WriterPassword { get; set; }
        public string WriterImage { get; set; }
        public bool WriterStatus { get; set; }
        //Blog
        public List<Blog> Blogs { get; set; }
    }
}
