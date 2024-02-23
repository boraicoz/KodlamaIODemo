using KodlamaIODemo.DataAccess.Abstract;
using KodlamaIODemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.DataAccess.Concrete
{
    public class CategoryDal:ICategoryDal
    {
        List<Category> _categories;
        public CategoryDal(List<Category> categories) 
            {
                _categories = categories;
            }

         public void Add(Category category)
            {
            _categories.Add(category);
            
            }
        
       public  List<Category> GetCategories()
        {
            return _categories;
        }
       public   void Remove(Category category)
        {
            _categories.Remove(category);
        }
    

    }
}
