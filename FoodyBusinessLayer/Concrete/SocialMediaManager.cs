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
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public void TDelete(SocialMedia entity)
        {
            _socialMediaDal.Delete(entity);
        }

        public List<SocialMedia> TGetAll()
        {
           return _socialMediaDal.GetAll();
        }

        public SocialMedia TGetById(int id)
        {
            return _socialMediaDal.GetById(id);
        }

        public void TInsert(SocialMedia entity)
        {
           _socialMediaDal.Insert(entity);
        }

        public void TUpdate(SocialMedia entity)
        {
            _socialMediaDal.Update(entity);
        }
    }
}
