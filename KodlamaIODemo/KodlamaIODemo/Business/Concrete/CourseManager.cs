using KodlamaIODemo.Business.Abstract;
using KodlamaIODemo.DataAccess.Concrete;
using KodlamaIODemo.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodlamaIODemo.Entities.Concrete;

namespace KodlamaIODemo.Business.Concrete
{
   public class CourseManager:ICourseManager
    {
        ICourseDal _courseDal;
        
        
        public CourseManager(ICourseDal courses) 
        {
            _courseDal = courses;
        }


         public void Add(Course course)
        {
            _courseDal.Add(course);
        } 
        public void Remove(Course course)
        {
            _courseDal.Remove(course);
        }
        public List<Course> GetCourses()
        {
            return _courseDal.GetCourses();
        }
     

    }
}
