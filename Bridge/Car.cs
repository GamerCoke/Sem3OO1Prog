namespace Bridge
{
    /// <summary>
    /// This is a Car class
    /// </summary>
    public class Car : BaseVehicle
    {
        /// <summary>
        /// Actual storage of licenseplate
        /// </summary>
        private string _licenseplate;

        /// <summary>
        /// The license on the licenseplate, of the car
        /// 
        /// Contains exception handling
        /// License needs to be less than 7 characters long, and not null
        /// </summary>
        public new string Licenseplate
        {
            get => _licenseplate;
            set
            {
                if (value != null && value.Length > 7)
                {
                    throw new ArgumentException("Licenseplates cannot be longer than 7 characters.");
                }
                if (value == null)
                {
                    throw new ArgumentException("Licenseplates not allowed to be null");
                }
                _licenseplate = value;
            }
        }

        /// <summary>
        /// The Date for registration of transaction
        /// </summary>
        public new DateTime Date;

        /// <summary>
        /// This checks for use of a BroBizz(tm)
        /// </summary>
        public new bool BroBizz = false;


        /// <summary>
        /// Returns the price for crossing the bridge
        /// </summary>
        /// <returns>230</returns>
        public override double Price()
        {
            if (BroBizz)
                return 230 * 0.9;
            return 230;
        }

        /// <summary>
        /// Returns the type of vehicle
        /// </summary>
        /// <returns>"Car"</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
