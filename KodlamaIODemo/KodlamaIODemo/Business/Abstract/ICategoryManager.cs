using KodlamaIODemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.Business.Abstract
{
    public interface ICategoryManager
    {
       List<Category> GetCategories();
       void Delete(Category category);
       void Add(Category category); 
    }
}
