using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager
    {
        Repository<Product> repoproduct = new Repository<Product>();
        
        public List<Product> GetAll()
        {
            return repoproduct.List();
        }

        public List<Product> ProductByID(int id)
        {
            return repoproduct.List().Where(x => x.ProductID == id).ToList();
        }

        public int ProductAddBl(Product p)
        {
            if (p.ProductTitle == "" || p.ProductImage == "" || p.ProductTitle.Length <= 5 || p.ProductContent.Length <= 10 )
            {
                return -1;
            }
            return repoproduct.Insert(p);
           
        }

        public int DeleteProductBL(int p)
        {
            Product product = repoproduct.Find(x => x.ProductID == p);
            return repoproduct.Delete(product);
        }

        public Product FindProduct(int id)
        {
            return repoproduct.Find(x => x.ProductID == id);
        }

        public int UpdateProduct(Product p)
        {

            Product product = repoproduct.Find(x => x.ProductID == p.ProductID);
            product.ProductTitle = p.ProductTitle;
            product.ProductContent = p.ProductContent;
            product.ProductDate = p.ProductDate;
            product.ProductImage = p.ProductImage;
            product.CategoryID = p.CategoryID;
            product.AuthorID = p.AuthorID;

            return repoproduct.Update(product);
        }
    }
}
