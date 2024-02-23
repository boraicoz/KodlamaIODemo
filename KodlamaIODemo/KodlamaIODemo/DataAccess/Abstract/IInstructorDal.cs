using KodlamaIODemo.DataAccess.Concrete;
using KodlamaIODemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.DataAccess.Abstract
{
    public interface IInstructorDal
    {
        List<Instructor> GetInstructors();
        void Add(Instructor instructor);
        void Remove(Instructor instructor);
    }
}
