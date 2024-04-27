using Kodlamaio.Business.Abstracts;
using Kodlamaio.DataAccess.Abstracts;
using Kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.Business.Concrete
{
    public class CategoryManager : IGenericService<Category>
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal) 
        {
            _categoryDal = categoryDal;
        }
        public void Add(Category item)
        {
            _categoryDal.Add(item);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public void Remove(Category item)
        {
           _categoryDal.Delete(item);
        }

        public void Update(Category item)
        {
            _categoryDal.Update(item);
        }
    }
}
