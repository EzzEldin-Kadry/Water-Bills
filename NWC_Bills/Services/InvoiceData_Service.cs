using Microsoft.EntityFrameworkCore;
using NWC.Repository;
using NWC_Bills.Models;
using System.Runtime.CompilerServices;

namespace NWC_Bills.Services
{
    public class InvoiceData_Service : Repository<NwcInvoice>
    {
        public InvoiceData_Service(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public void Add(NwcInvoice invoice)
        {
            this._db.NwcInvoices.Add(invoice);
        }
        public void Update(NwcInvoice invoice)
        {
            this._db.NwcInvoices.Update(invoice);
        }
        public bool Any(string subscriberCode)
        {
            return dbSet.Any(x => x.NwcInvoicesSubscriberNo == subscriberCode);
        }
        public bool AnyInvoiceNo(string invoiceNo)
        {
            return dbSet.Any(x => x.NwcInvoicesNo == invoiceNo);
        }
        public string GetHeighestNo()
        {
            IQueryable<NwcInvoice> query = dbSet.AsNoTracking();
            return query.Select(x => x.NwcInvoicesNo).ToList().OrderBy(x => x, new CustomComparer()).ToList().FirstOrDefault();
        }
    }
}
