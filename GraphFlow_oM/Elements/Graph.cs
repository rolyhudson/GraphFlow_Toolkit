using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.oM.GraphFlow
{
    public class Graph
    {
        public virtual List<INode> Nodes { get; set; } = new List<INode>();
        public virtual List<ILink> Links { get; set; } = new List<ILink>();
        public virtual int Step { get; set; } = 0;
    }
}
