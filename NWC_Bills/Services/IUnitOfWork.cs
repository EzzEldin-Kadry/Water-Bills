namespace NWC_Bills.Services
{
     public interface IUnitOfWork
    {
        EstateTypes_Service EstateType{ get; }
        SubscribersData_Service SubscribersData { get; }
        SubscriptionData_Service SubscriptionData { get; }
        InvoiceData_Service InvoiceData { get; }
        DefaultSliceValue_Service DefaultSlice { get; }
        Task Save();
        void ClearTracks();
    }
}
