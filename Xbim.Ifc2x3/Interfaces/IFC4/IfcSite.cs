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
	public partial class @IfcSite : IIfcSite
	{
		Ifc4.MeasureResource.IfcCompoundPlaneAngleMeasure? IIfcSite.RefLatitude 
		{ 
			get
			{
				if (!RefLatitude.HasValue) return null;
				return new Ifc4.MeasureResource.IfcCompoundPlaneAngleMeasure(RefLatitude.Value);
			} 
		}
		Ifc4.MeasureResource.IfcCompoundPlaneAngleMeasure? IIfcSite.RefLongitude 
		{ 
			get
			{
				if (!RefLongitude.HasValue) return null;
				return new Ifc4.MeasureResource.IfcCompoundPlaneAngleMeasure(RefLongitude.Value);
			} 
		}
		Ifc4.MeasureResource.IfcLengthMeasure? IIfcSite.RefElevation 
		{ 
			get
			{
				if (!RefElevation.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLengthMeasure(RefElevation.Value);
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcSite.LandTitleNumber 
		{ 
			get
			{
				if (!LandTitleNumber.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(LandTitleNumber.Value);
			} 
		}
		IIfcPostalAddress IIfcSite.SiteAddress 
		{ 
			get
			{
				return SiteAddress;
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcSpatialElement.LongName 
		{ 
			get
			{
				//## Handle return of LongName for which no match was found
                return !Name.HasValue ? null : new Ifc4.MeasureResource.IfcLabel(Name.Value);
				//##
			} 
		}
		IEnumerable<IIfcRelContainedInSpatialStructure> IIfcSpatialElement.ContainsElements 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelContainedInSpatialStructure>(e => (e.RelatingStructure as IfcSite) == this);
			} 
		}
		IEnumerable<IIfcRelServicesBuildings> IIfcSpatialElement.ServicedBySystems 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelServicesBuildings>(e => e.RelatedBuildings != null &&  e.RelatedBuildings.Contains(this));
			} 
		}
		IEnumerable<IIfcRelReferencedInSpatialStructure> IIfcSpatialElement.ReferencesElements 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelReferencedInSpatialStructure>(e => (e.RelatingStructure as IfcSite) == this);
			} 
		}
	}
}