using BH.oM.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.oM.GraphFlow
{
    public class Link : BHoMObject, ILink
    {
        public virtual INode Start { get; set; } = new Node();
        public virtual INode End { get; set; } = new Node();
    }
}