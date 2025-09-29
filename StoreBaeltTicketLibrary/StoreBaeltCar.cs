using Bridge;

namespace StoreBaeltTicketLibrary
{
    public class StoreBaeltCar : Car
    {
        public bool Weekend = false;
        public override double Price()
        {
            double baseprice = 230;
            if (Weekend)
            {
                baseprice = baseprice * 0.85; 
            }
            if (BroBizz)
            {
                baseprice = baseprice * 0.9;
            }
            return baseprice;
        }
    }
}
