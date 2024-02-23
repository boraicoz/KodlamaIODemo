using KodlamaIODemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodlamaIODemo.Business.Abstract;
using KodlamaIODemo.DataAccess.Abstract;
using KodlamaIODemo.DataAccess.Concrete;

namespace KodlamaIODemo.Business.Concrete
{
    internal class CategoryManager:ICategoryManager
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal category) { 
        
             _categoryDal= category;
        }

       public List<Category> GetCategories()
        {
            return _categoryDal.GetCategories();
        }
        
        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }
        public void Delete(Category category) 
        {
          _categoryDal.Remove(category);
        }
   
        


    }
}
