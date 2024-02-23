using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.Entities.Concrete
{
  public  class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double CompletionRate{  get; set; }
        public int CategoryId { get; set; }
        public string InstructorName { get; set; }


    }
}
