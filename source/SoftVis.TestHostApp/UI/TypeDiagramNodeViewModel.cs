﻿using System.Collections.Generic;
using System.Windows;
using Codartis.SoftVis.Diagramming;
using Codartis.SoftVis.Modeling2;
using Codartis.SoftVis.TestHostApp.Modeling;
using Codartis.SoftVis.UI.Wpf.ViewModel;
using Codartis.SoftVis.Util.UI.Wpf;

namespace Codartis.SoftVis.TestHostApp.UI
{
    internal class TypeDiagramNodeViewModel : DiagramNodeViewModelBase
    {
        public TypeDiagramNodeViewModel(IArrangedDiagram diagram, IDiagramNode diagramNode, bool isDescriptionVisible)
            : this(diagram,  diagramNode,  isDescriptionVisible, Size.Empty, PointExtensions.Undefined, PointExtensions.Undefined)
        {
        }

        public TypeDiagramNodeViewModel(IArrangedDiagram diagram, IDiagramNode diagramNode, bool isDescriptionVisible,
            Size size, Point center, Point topLeft)
            : base(diagram, diagramNode, isDescriptionVisible, size, center, topLeft)
        {
        }

        public override object Clone()
        {
            return new TypeDiagramNodeViewModel(Diagram, DiagramNode, IsDescriptionVisible, Size, Center, TopLeft);
        }

        protected override IEnumerable<DirectedModelRelationshipType> GetRelatedNodeCueTypes()
        {
            yield return DirectedRelationshipTypes.BaseType;
            yield return DirectedRelationshipTypes.Subtype;
            yield return DirectedRelationshipTypes.ImplementerType;
            yield return DirectedRelationshipTypes.ImplementedInterface;
        }
    }
}
