using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// This is a Base class for Vehicle classes to inherit from
    /// </summary>

    [ExcludeFromCodeCoverage]
    public abstract class BaseVehicle
    {
        /// <summary>
        /// Actual storage of the licenseplate, not strictly necessary if class is not used by itself
        /// </summary>
        private string _licenseplate;

        /// <summary>
        /// This is the licenseplate of the vehicle
        /// 
        /// Contains exception handling, not strictly necessary if class is not used by itself
        /// License needs to be less than 7 characters long, and not null
        /// </summary>
        public string Licenseplate
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
        /// This is the registered entry date
        /// </summary>
        public DateTime Date;

        /// <summary>
        /// This checks for use of a BroBizz(tm)
        /// </summary>
        public bool BroBizz = false;

        /// <summary>
        /// This is the price for the vehicle
        /// </summary>
        /// <returns>double</returns>
        public abstract double Price();

        /// <summary>
        /// This is the vehicle type
        /// </summary>
        /// <returns>string</returns>
        public abstract string VehicleType();
    }
}
