// See https://aka.ms/new-console-template for more information

using Kodlamaio.Business.Concrete;
using Kodlamaio.DataAccess.Concrete;
using Kodlamaio.Entities;

CategoryManager categoryManager = new CategoryManager(new CategoryDal());
List<Category> categories = categoryManager.GetAll();
for (int i = 0; i < categories.Count; i++) 
{
    Console.WriteLine(categories[i].categoryName + " / " + categories[i].description);
}


