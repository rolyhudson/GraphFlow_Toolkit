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
        public static string Status(this INode node)
        {
            if(node is Node)
                return String.Format("Incoming: {0}, Outgoing: {1}, Total: {2}", node.Incoming, node.Outgoing, node.Incoming + node.Outgoing);

            if(node is Sink)
                return String.Format("Exited: {0}", node.Outgoing);

            if(node is Source)
                return String.Format("Entered system: {0}", node.Throughput);
   
            return "";
        }
    }
}
