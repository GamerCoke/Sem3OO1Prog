using Bridge;

namespace OresundbronLibrary
{
    public class OresundCar : Car
    {
        public override double Price()
        {
            // Not specified if Weekend 
            if (BroBizz)
            {
                return 178;
            }
            else
            {
                return 460;
            }
        }

        public override string VehicleType()
        {
            return $"Oresund Car";
        }
    }
}
