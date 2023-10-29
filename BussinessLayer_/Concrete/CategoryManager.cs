using BussinessLayer_.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer_.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer_.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        //GenericRepository<Category> repo = new GenericRepository<Category>();

        //public List<Category> GetAllBL()
        //{
        //    return repo.List();
        //}
        //public void CategoryAddBL(Category p)
        //{
        //    if (p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryDesciprition == "" || p.CategoryName.Length > 51)
        //    {
        //        //hata mesjı
        //    }
        //    else
        //    {
        //        repo.Insert(p);
        //    }
        //}
        public List<Category> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
