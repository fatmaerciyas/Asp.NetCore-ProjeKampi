using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        [StringLength(30)]
        public string CommentUserName { get; set; }
        [StringLength(30)]
        public string CommentTitle { get; set; }
        [StringLength(400)]
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public int BlogScore { get; set; }
        public bool CommentStatus { get; set; }

        //Blog
        public int BlogID { get; set; }
        public Blog Blog { get; set; }
    }
}
