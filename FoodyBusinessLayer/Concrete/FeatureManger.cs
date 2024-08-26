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
    public class FeatureManger : IFeatureService
    {
        private readonly IfeatureDal _featureDal;

        public FeatureManger(IfeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TDelete(Feature entity)
        {
            _featureDal.Delete(entity);
        }

        public List<Feature> TGetAll()
        {
            return _featureDal.GetAll();
        }

        public Feature TGetById(int id)
        {
            return _featureDal.GetById(id);
        }

        public void TInsert(Feature entity)
        {
            _featureDal.Insert(entity);
        }

        public void TUpdate(Feature entity)
        {
            _featureDal.Update(entity);
        }
    }
}
