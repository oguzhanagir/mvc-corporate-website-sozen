using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GalleryManager
    {
        Repository<Gallery> repogallery = new Repository<Gallery>();

        public List<Gallery> GetAll()
        {
            return repogallery.List();
        }
        public int GalleryAddBl(Gallery p)
        {
            if (p.GalleryImage == "")
            {
                return -1;
            }
            return repogallery.Insert(p);

        }
    }
}
