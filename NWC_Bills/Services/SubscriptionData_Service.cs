using Microsoft.EntityFrameworkCore;
using NWC.Repository;
using NWC_Bills.Models;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace NWC_Bills.Services
{
    public class SubscriptionData_Service : Repository<NwcSubscriptionFile>
    {
        public SubscriptionData_Service(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public void Add(NwcSubscriptionFile subscriptionFile)
        {
            this.dbSet.Add(subscriptionFile);
        }
        public void Update(NwcSubscriptionFile subscriptionFile)
        {
            this._db.NwcSubscriptionFiles.Update(subscriptionFile);
        }
        public bool Any(string subscriberCode)
        {
            return dbSet.Any(x=> x.NwcSubscriptionFileSubscriberCode ==  subscriberCode);
        }
        public bool AnyBySubscription(string subscriptionNo)
        {
            return dbSet.Any(x => x.NwcSubscriptionFileNo == subscriptionNo);
        }
    }
}
