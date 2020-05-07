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
        public static void Throughput(this INode node, double amount)
        {
            //handles tracking total node throughput and updates outgoing
            node.Throughput += amount;
            node.Outgoing -= amount;
        }
    }
}
