using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodlamaIODemo.Entities.Concrete;

namespace KodlamaIODemo.Business.Abstract
{
    public interface ICourseManager
    {
        List<Course> GetCourses();
        void Add(Course course);
        void Remove(Course course);

    }
}
