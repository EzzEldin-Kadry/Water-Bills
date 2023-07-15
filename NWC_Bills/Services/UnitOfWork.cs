using Microsoft.EntityFrameworkCore;
using NWC_Bills.Models;

namespace NWC_Bills.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;
        public UnitOfWork(ApplicationDbContext dbContext) 
        {
            _dbContext = dbContext;
            EstateType = new(_dbContext);
            SubscribersData = new(_dbContext);
            SubscriptionData = new(_dbContext);
            InvoiceData = new(_dbContext);
            DefaultSlice = new(_dbContext);
        }
        public EstateTypes_Service EstateType { get; private set; }
        public SubscribersData_Service SubscribersData { get; private set; }
        public SubscriptionData_Service SubscriptionData { get; private set; }
        public InvoiceData_Service InvoiceData { get; private set; }
        public DefaultSliceValue_Service DefaultSlice { get; private set; }

        public void ClearTracks()
        {
            _dbContext.ChangeTracker.Clear();
        }
        public async Task Save()
        {
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch(DbUpdateException _)
            {

            }
        }
    }
}
