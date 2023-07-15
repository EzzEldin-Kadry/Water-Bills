using NWC.Repository;
using NWC_Bills.Models;
using System.Runtime.CompilerServices;

namespace NWC_Bills.Services
{
    public class EstateTypes_Service : Repository<NwcRrealEstateType>
    {
        public EstateTypes_Service(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public void Update(NwcRrealEstateType estate)
        {
            this._db.NwcRrealEstateTypes.Update(estate);
        }
    }
}
