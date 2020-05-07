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
        public static void Transition(this INode node, Graph graph)
        {
            //supply node only makes more availble at flow rate
            if (node is Node || node is Sink)
            {
                //get supply nodes
                IEnumerable<INode> suppliers = graph.Links.Where(x => x.End.Equals(node)).Select(x => x.Start);
                //remaining capacity on this node
                double space = node.Capacity - (node.Incoming + node.Outgoing);
                //available to join node
                double available = 0;

                foreach (INode n in suppliers)
                    available += n.Outgoing;

                double incomingNew = Math.Min(space, available);
                // add the incoming
                node.Incoming += incomingNew;
                // remove from suppliers by equal proportions
                foreach (INode n in suppliers)
                    n.Throughput(incomingNew / suppliers.Count());
            }

            node.Outgoing += node.FlowRate;
            node.Incoming -= node.FlowRate;
        }
    }
}
