using Bridge;

namespace StoreBaeltTicketLibrary
{
    public interface IStorebaeltRepository
    {
        void AddTicket(BaseVehicle vehicle);
        List<BaseVehicle> GetAllTickets();
        List<BaseVehicle> GetByLicense(string licenseplate);
    }
}
