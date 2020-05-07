﻿using BH.oM.Base;
using BH.oM.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.oM.GraphFlow
{
    public class Source : BHoMObject, INode
    {
        public virtual double Incoming { get; set; } = 0;
        public virtual double Outgoing { get; set; } = 0.0;
        public virtual double Capacity { get; set; } = 0;
        public virtual double FlowRate { get; set; } = 20;
        public virtual double Throughput { get; set; } = 0;
        public virtual Point Location { get; set; } = new Point();
    }
}
