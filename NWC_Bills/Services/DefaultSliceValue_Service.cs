using NWC.Repository;
using NWC_Bills.Models;
using System.Runtime.CompilerServices;

namespace NWC_Bills.Services
{
    public class DefaultSliceValue_Service : Repository<NwcDefaultSliceValue>
    {
        public DefaultSliceValue_Service(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
