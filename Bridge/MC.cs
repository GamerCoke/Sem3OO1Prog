using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// This is a MC class
    /// </summary>
    public class MC : BaseVehicle
    {
        /// <summary>
        /// Actual storage of licenseplate
        /// </summary>
        private string _licenseplate;

        /// <summary>
        /// Licenseplate for the MC
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
        /// Date of entry
        /// </summary>
        public new DateTime Date;

        /// <summary>
        /// This checks for use of a BroBizz(tm)
        /// </summary>
        public new bool BroBizz = false;


        /// <summary>
        /// Returns price
        /// </summary>
        /// <returns>120</returns>
        public override double Price()
        {
            if (BroBizz)
                return 120 * 0.9;
            return 120;
        }

        /// <summary>
        /// Returns Vehicle type
        /// </summary>
        /// <returns>"MC"</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
