using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary
{
    public class StorebaeltRepository : IStorebaeltRepository
    {
        public static List<BaseVehicle> Tickets { get; } = new List<BaseVehicle>();

        public void AddTicket(BaseVehicle vehicle)
        {
            Tickets.Add(vehicle);
        }

        public List<BaseVehicle> GetAllTickets()
        {
            foreach (BaseVehicle ticket in Tickets)
            {
                Console.WriteLine($"Licenseplate: {ticket.Licenseplate}, Vehicle Type: {ticket.GetType()}, Has BroBizz? {ticket.BroBizz}\n Total Price: {ticket.Price}\n");
            }
            return Tickets;
        }

        public List<BaseVehicle> GetByLicense(string licenseplate)
        {
            var query = from ticket in Tickets
                        where ticket.Licenseplate == licenseplate
                        select ticket;
            List<BaseVehicle> list = query.ToList();
            return list;
        }
    }
}
