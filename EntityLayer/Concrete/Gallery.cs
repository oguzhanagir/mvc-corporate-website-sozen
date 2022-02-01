using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Gallery
    {
        public Gallery()
        {
            GalleryImage = new List<string>();
        }

        [Key]
        public int GalleryID { get; set; }

        [StringLength(100)]
        public List<string> GalleryImage { get; set; }
        
    }
}
