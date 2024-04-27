using Kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        void Add(Course course);
        List<Course> GetAll();
        void Delete(Course course);
        void Update(Course course);
    }
}
