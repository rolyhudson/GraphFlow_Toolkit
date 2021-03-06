﻿/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2020, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

using BH.Engine.Geometry;
using BH.oM.Geometry;
using BH.oM.GraphFlow;
using BH.oM.Reflection.Attributes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace BH.Engine.GraphFlow
{
    public static partial class Query
    {
        /***************************************************/
        /**** Public Methods                            ****/
        /***************************************************/
        
        public static CompositeGeometry Geometry(this Graph graph)
        {
            List<IGeometry> geometries = new List<IGeometry>();
            foreach (ILink link in graph.Links)
                geometries.Add(link.Geometry());

            foreach (INode node in graph.Nodes)
                geometries.Add(node.Geometry());

            return BH.Engine.Geometry.Create.CompositeGeometry(geometries);
        }
        /***************************************************/
        public static IGeometry Geometry(this INode node)
        {
            return BH.Engine.Geometry.Create.Circle(node.Location,0.2);
        }
        /***************************************************/
        public static CompositeGeometry Geometry(this ILink link)
        {
            List<IGeometry> geometries = new List<IGeometry>();
            geometries.Add(BH.Engine.Geometry.Create.Line(link.Start.Location, link.End.Location));
            geometries.Add(link.AddArrow());
            return BH.Engine.Geometry.Create.CompositeGeometry(geometries);
        }
        /***************************************************/
        private static CompositeGeometry AddArrow(this ILink link)
        {
            Vector back =  link.Start.Location - link.End.Location;
            Vector perp = back.CrossProduct(Vector.ZAxis);
            back = back * 0.1;
            perp = perp * 0.025;
            Point p1 = link.End.Location + (back + perp);
            Point p2 = link.End.Location + (back - perp);
            List<IGeometry> geometries = new List<IGeometry>();
            geometries.Add(BH.Engine.Geometry.Create.Line(link.End.Location,p1));
            geometries.Add(BH.Engine.Geometry.Create.Line(link.End.Location, p2));
            return BH.Engine.Geometry.Create.CompositeGeometry(geometries);
        }
    }
}
