using Foody.DataAccesLayer.Abstract;
using Foody_EntityLayer.Concrete;
using FoodyBusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodyBusinessLayer.Concrete
{
    public class CategoryManager : ICatgeoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TDelete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public List<Category> TGetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void TInsert(Category entity)
        {
            _categoryDal.Insert(entity);
        }

        public void TUpdate(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
