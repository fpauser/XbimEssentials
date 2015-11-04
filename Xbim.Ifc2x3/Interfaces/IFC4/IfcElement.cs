// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.ProductExtension
{
	public partial class @IfcElement : IIfcElement
	{
		Ifc4.MeasureResource.IfcIdentifier? IIfcElement.Tag 
		{ 
			get
			{
				if (!Tag.HasValue) return null;
				return new Ifc4.MeasureResource.IfcIdentifier(Tag.Value);
			} 
		}
		IEnumerable<IIfcRelFillsElement> IIfcElement.FillsVoids 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelFillsElement>(e => (e.RelatedBuildingElement as IfcElement) == this);
			} 
		}
		IEnumerable<IIfcRelConnectsElements> IIfcElement.ConnectedTo 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelConnectsElements>(e => (e.RelatingElement as IfcElement) == this);
			} 
		}
		IEnumerable<IIfcRelInterferesElements> IIfcElement.IsInterferedByElements 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelInterferesElements>(e => (e.RelatedElement as IfcElement) == this);
			} 
		}
		IEnumerable<IIfcRelInterferesElements> IIfcElement.InterferesElements 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelInterferesElements>(e => (e.RelatingElement as IfcElement) == this);
			} 
		}
		IEnumerable<IIfcRelProjectsElement> IIfcElement.HasProjections 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelProjectsElement>(e => (e.RelatingElement as IfcElement) == this);
			} 
		}
		IEnumerable<IIfcRelReferencedInSpatialStructure> IIfcElement.ReferencedInStructures 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelReferencedInSpatialStructure>(e => e.RelatedElements != null &&  e.RelatedElements.Contains(this));
			} 
		}
		IEnumerable<IIfcRelVoidsElement> IIfcElement.HasOpenings 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelVoidsElement>(e => (e.RelatingBuildingElement as IfcElement) == this);
			} 
		}
		IEnumerable<IIfcRelConnectsWithRealizingElements> IIfcElement.IsConnectionRealization 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelConnectsWithRealizingElements>(e => e.RealizingElements != null &&  e.RealizingElements.Contains(this));
			} 
		}
		IEnumerable<IIfcRelSpaceBoundary> IIfcElement.ProvidesBoundaries 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelSpaceBoundary>(e => (e.RelatedBuildingElement as IfcElement) == this);
			} 
		}
		IEnumerable<IIfcRelConnectsElements> IIfcElement.ConnectedFrom 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelConnectsElements>(e => (e.RelatedElement as IfcElement) == this);
			} 
		}
		IEnumerable<IIfcRelContainedInSpatialStructure> IIfcElement.ContainedInStructure 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelContainedInSpatialStructure>(e => e.RelatedElements != null &&  e.RelatedElements.Contains(this));
			} 
		}
	}
}