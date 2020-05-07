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
        public static Graph Step(this Graph graph, bool run = false, int steps = 1)
        {
            if(run)
            {
                int loops = 0;
                while (loops < steps)
                {
                    for (int i = 0; i < graph.Nodes.Count; i++)
                        graph.Nodes[i].Transition(graph);

                    graph.Step++;
                    loops++;
                }
                
            }
            return graph;
        }
    }
}
