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
        public static Graph Graph(Topology topology,int x = 3,int y = 3)
        {
            switch (topology)
            {
                case Topology.Chain:
                    return Chain(x);
                case Topology.Grid:
                    return Grid(x, y);
                case Topology.Pentagon:
                    return Pentagon();
                case Topology.Diamond:
                    return Diamond();
                default:
                    return Chain(x);
            }
        }
        /***************************************************/
        /****           Private Methods                 ****/
        /***************************************************/
        private static Graph Chain(int nodeCount)
        {
            Graph graph = new Graph();
            for (int i = 0; i < nodeCount; i++)
            {
                if (i == 0)
                    graph.Nodes.Add(new Source()
                    {
                        Location = Geometry.Create.Point(i * 1, 0, 0),
                        Incoming = 1000

                    });

                else if (i == nodeCount - 1)
                    graph.Nodes.Add(new Sink()
                    {
                        Location = Geometry.Create.Point(i * 1, 0, 0)
                    }); 

                else
                    graph.Nodes.Add(new Node()
                    {
                        Location = Geometry.Create.Point(i * 1, 0, 0)
                    });

                if (i > 0)
                    graph.Links.Add(new Link() { End = graph.Nodes[i], Start = graph.Nodes[i - 1] });
            }
            return graph;
        }
        private static Graph Grid(int x,int y)
        {
            Graph graph = new Graph();
            
            return graph;
        }
        private static Graph Diamond()
        {
            Graph graph = new Graph();

            return graph;
        }
        private static Graph Pentagon()
        {
            Graph graph = new Graph();

            return graph;
        }
    }
}
