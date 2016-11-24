using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Amanet
{
    public partial class AmanetEntities : DbContext
    {
        public AmanetEntities(string _conS)
            : base(_conS)
        {
        }
    }
}
