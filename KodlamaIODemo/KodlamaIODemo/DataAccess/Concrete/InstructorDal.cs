using KodlamaIODemo.DataAccess.Abstract;
using KodlamaIODemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.DataAccess.Concrete
{
    public class InstructorDal:IInstructorDal
    {
        List<Instructor> _instructors;
        public InstructorDal(List<Instructor> instructors)
        {
           _instructors = instructors;
        }
       public void Add(Instructor instructor) {
           _instructors.Add(instructor);
        
        }
       public void Remove(Instructor instructor)
        {
            _instructors.Remove(instructor);
        }
        public List<Instructor>GetInstructors()
        {
            return _instructors;
        }
                                
    }
}
