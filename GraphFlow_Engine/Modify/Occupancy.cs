using BH.oM.GraphFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.Engine.GraphFlow
{
    public static partial class Modify
    {
        /***************************************************/
        /****           Public Methods                  ****/
        /***************************************************/
        public static void Occupancy(this INode node)
        {
            if (node.Incoming == 0)
                return;
            double space = node.Capacity - node.Occupancy;

            double toAdd = Math.Min(space, node.Incoming);
            node.Occupancy += toAdd;
            node.Incoming -= toAdd;
        }
    }
}
