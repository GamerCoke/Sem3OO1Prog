using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace OresundbronLibrary
{
    public class OresundMC : MC
    {
        public override double Price()
        {
            if (BroBizz)
            {
                return 92;
            }
            else
            {
                return 235;
            }
        }

        public override string VehicleType()
        {
            return $"Oresund MC";
        }
    }
}
