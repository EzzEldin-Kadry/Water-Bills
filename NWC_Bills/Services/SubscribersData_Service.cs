using Microsoft.EntityFrameworkCore;
using NWC.Repository;
using NWC_Bills.Models;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace NWC_Bills.Services
{
    public class SubscribersData_Service : Repository<NwcSubscriberFile>
    {
        public SubscribersData_Service(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public void Update(NwcSubscriberFile subscriberFile)
        {
            this._db.NwcSubscriberFiles.Update(subscriberFile);
        }
    }
}
