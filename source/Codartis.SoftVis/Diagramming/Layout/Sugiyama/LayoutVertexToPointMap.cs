﻿using Codartis.SoftVis.Geometry;
using Codartis.Util;

namespace Codartis.SoftVis.Diagramming.Layout.Sugiyama
{
    internal class LayoutVertexToPointMap : Map<LayoutVertexBase, Point2D>
    { 
        public Rect2D GetRect(LayoutVertexBase vertex)
        {
            var center = Get(vertex);
            return Rect2D.CreateFromCenterAndSize(center, vertex.Size);
        }
    }
}