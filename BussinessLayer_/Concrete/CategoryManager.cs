using DataAccessLayer.Concrete.Repositories;
using EntityLayer_.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer_.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAll()
        {
            return repo.List();
        }
    }
}
