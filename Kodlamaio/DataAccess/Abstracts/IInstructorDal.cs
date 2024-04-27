using Kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        void Add(Instructor ınstructor);
        List<Instructor> GetAll();
        void Update(Instructor ınstructor);
        void Delete(Instructor ınstructor);

    }
}
