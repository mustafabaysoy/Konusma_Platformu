﻿using EntityLayer_.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer_.Abstract
{
    public  interface ICategoryService
    {
        List<Category> GetList();
        void CategoryAdd(Category category);
    }
}
