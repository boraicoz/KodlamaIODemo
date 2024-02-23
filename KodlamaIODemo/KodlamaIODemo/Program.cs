using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodlamaIODemo.Business.Concrete;
using KodlamaIODemo.DataAccess.Concrete;
using KodlamaIODemo.Entities.Concrete;
namespace KodlamaIODemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var courseList= new List<Course> {


                new Course {Id=1,CategoryId=3,Name="Java",CompletionRate=0.3,InstructorName="Engin Demiroğ"},
                new Course{Id=2,CategoryId=3,Name="C#",CompletionRate=0.5,InstructorName="Bora Icoz"},
                new Course{Id=3,CategoryId=3,Name="C++",CompletionRate=0.8,InstructorName="Derin Yağız"}
            };

            var categoryList = new List<Category>
            {
                new Category{Id=1,Name="Grafik Tasarım"},
                new Category{Id=2,Name="Oyun Tasarım"},
                new Category{Id=3,Name="Yazılım"}
            };


            var instructorList = new List<Instructor>
            {
                new Instructor{Id=1,Name="Engin Demiroğ"},
                new Instructor{Id=2,Name="Bora Icoz"},
                new Instructor{Id=3,Name="Derin Yağız"}
            };

            var courseManager = new CourseManager(new CourseDal(courseList));
            var categoryManager= new CategoryManager(new CategoryDal(categoryList));
            var instructorManager=new InstructorManager(new InstructorDal(instructorList));

            var courses=courseManager.GetCourses();
            
            foreach(var course in courses)
            {
                Console.WriteLine(course);
            }

            Console.ReadLine();
        }
    }
}
