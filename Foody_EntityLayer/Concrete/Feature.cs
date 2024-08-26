using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Foody_EntityLayer.Concrete
{
    public class Feature
    {
        public int FeatureId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
