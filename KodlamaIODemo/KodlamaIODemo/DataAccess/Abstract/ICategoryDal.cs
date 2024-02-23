using KodlamaIODemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.DataAccess.Abstract
{
  public  interface ICategoryDal
    {
        List<Category> GetCategories();
        void Add(Category category);
        void Remove(Category category);

    }
}
