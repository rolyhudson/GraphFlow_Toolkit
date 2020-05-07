﻿using BH.oM.Base;
using BH.oM.Geometry;

namespace BH.oM.GraphFlow
{
    public interface INode : IBHoMObject
    {
        double Incoming { get; set; }
        double Outgoing { get; set; }
        double Capacity { get; set; }
        double FlowRate { get; set; }
        double Throughput { get; set; }
        Point Location { get; set; }
    }
}