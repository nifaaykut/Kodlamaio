using Kodlamaio.DataAccess.Abstracts;
using Kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        List<Course> _courses;
        public CourseDal() 
        {
            _courses = new List<Course>();
            _courses.Add(new Course { courseId = 1, courseName = "C" }) ;

        }
        public void Add(Course course)
        {
            _courses.Add(course);

        }

        public void Delete(Course course)
        {
            var courseDelete = _courses.Where(c=>c.courseId == course.courseId).SingleOrDefault();
            if (courseDelete != null) 
            {
                _courses.Remove(courseDelete);
            }
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public void Update(Course course)
        {
           var courseUpdate = _courses.Where(c=>c.courseId==course.courseId).SingleOrDefault();
            if (courseUpdate != null) 
            {
                courseUpdate = course;
            }
        }
    }
}
