using KodlamaIODemo.Business.Abstract;
using KodlamaIODemo.DataAccess.Abstract;
using KodlamaIODemo.DataAccess.Concrete;
using KodlamaIODemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.Business.Concrete
{
   public class InstructorManager:IInstructorManager
    {
        private readonly IInstructorDal _instructorDal;
       public InstructorManager(IInstructorDal instructorDal) {
            _instructorDal = instructorDal;
        }
        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }
        public void Remove(Instructor instructor)
        {
            _instructorDal.Remove(instructor);
        }
        public List<Instructor> GetInstructors()
        {
            return _instructorDal.GetInstructors();
        }
        public void Delete(Instructor instructor)
        {
            _instructorDal.Remove(instructor);
        }
    }
}
