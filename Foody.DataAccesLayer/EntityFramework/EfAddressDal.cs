using Foody.DataAccesLayer.Abstract;
using Foody.DataAccesLayer.Context;
using Foody.DataAccesLayer.Repositories;
using Foody_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DataAccesLayer.EntityFramework
{
    public class EfAddressDal : GenericRepository<Address>, IAddressDal
    {
        public EfAddressDal(FoodyContext context) : base(context)
        {
        }
    }
}
