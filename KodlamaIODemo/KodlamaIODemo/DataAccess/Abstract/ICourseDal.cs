using KodlamaIODemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.DataAccess.Abstract
{
    public interface ICourseDal
    {
        List<Course>GetCourses();
        void Add(Course course);
        void Remove(Course course);
    }
}
