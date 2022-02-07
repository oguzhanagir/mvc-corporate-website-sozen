using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SocialMediaManager
    {
        Repository<SocialMedia> reposocial = new Repository<SocialMedia>();

        public List<SocialMedia> GetAll()
        {
            return reposocial.List();
        }

        public int SocialMediaAddBL(SocialMedia p)
        {
            SocialMedia socialMedia = reposocial.Find(x => x.SocialMediaID == p.SocialMediaID);
            socialMedia.Twitter = p.Twitter;
            socialMedia.İnstagram = p.İnstagram;
            socialMedia.Facebook = p.Facebook;
            socialMedia.Linkedin = p.Linkedin;

            return reposocial.Update(socialMedia);
        }


    }
}
