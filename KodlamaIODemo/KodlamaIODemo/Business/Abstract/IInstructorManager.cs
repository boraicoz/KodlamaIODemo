using KodlamaIODemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.Business.Abstract
{
   public interface IInstructorManager
    {
        List<Instructor>GetInstructors();
        void Add(Instructor instructor);
        void Delete(Instructor instructor);

    }
}
