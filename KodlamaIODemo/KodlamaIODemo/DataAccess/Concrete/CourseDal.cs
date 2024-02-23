using KodlamaIODemo.DataAccess.Abstract;
using KodlamaIODemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.DataAccess.Concrete
{
    public class CourseDal:ICourseDal
    {
       private  List<Course> _courses;
        
        public CourseDal(List<Course> courses) {
            _courses= courses;

        }

       public  void Add(Course course)
        {
            _courses.Add(course);  
        }
        public List<Course> GetCourses() 
        {  return _courses;  }
        public void Remove(Course course)
        {
            _courses.Remove(course);
        }
        
    }
}
