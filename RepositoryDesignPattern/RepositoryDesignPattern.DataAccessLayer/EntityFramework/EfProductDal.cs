using Microsoft.EntityFrameworkCore;
using RepositoryDesignPattern.DataAccessLayer.Abstract;
using RepositoryDesignPattern.DataAccessLayer.Concrete;
using RepositoryDesignPattern.DataAccessLayer.Repositories;
using RepositoryDesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.DataAccessLayer.EntityFramework
{
    //Burada  miras alma işlemi yaparken IProductDal dememizin nedeni 
    public class EfProductDal:GenericRepository<Product>,IProductDal
    {
        private readonly Context _context;
        public EfProductDal(Context context):base(context)
        {
            _context=context;
        }

       
        /// Burada Product içerisine categoryi dahil ediyoruz.Category adını product listesinde görüntülemek için extension methot yazıyoruz. Generic dışında bir methot.        
        public List<Product> ProductListWithCategory()
        {
          return  _context.Products.Include(X=> X.Category).ToList();
        }
    }
}
