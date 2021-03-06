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
        public int CommentId { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Mail { get; set; }

        [StringLength(300)]
        public string CommentText { get; set; }

        public int ProductID { get; set; }
        public virtual  Product Products { get; set; }

    }
}
