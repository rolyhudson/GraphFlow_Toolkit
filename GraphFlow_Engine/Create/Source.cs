using BH.oM.GraphFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.Engine.GraphFlow
{
    public static partial class Create
    {
        /***************************************************/
        /****           Public Methods                  ****/
        /***************************************************/
        public static Source Source(int intialSupply)
        {
            return new Source() 
            { 
                Incoming = intialSupply 
            };
        }
    }
}
