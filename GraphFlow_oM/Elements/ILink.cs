﻿using BH.oM.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.oM.GraphFlow
{
    public interface ILink : IBHoMObject
    {
        INode Start { get; set; }
        INode End { get; set; }
    }
}
