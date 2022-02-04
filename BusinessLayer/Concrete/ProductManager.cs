﻿using DataAccessLayer.Concrete;
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

    }
}
