﻿using BH.oM.GraphFlow;
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
        public static void Dispatch(this INode node,Graph graph)
        {
            IEnumerable<INode> destination = graph.Links.Where(x => x.Start.Equals(node)).Select(x => x.End);

            foreach (INode n in destination)
                n.Incoming += node.Occupancy / destination.Count();
        }
    }
}
