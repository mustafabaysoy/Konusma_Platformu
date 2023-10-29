using EntityLayer_.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer_.Abstract
{
    public internal interface ICategoryService
    {
        List<Category> GetList();
    }
}
