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
namespace Xbim.Ifc2x3.SharedBldgElements
{
	public partial class @IfcStairFlight : IIfcStairFlight
	{
		long? IIfcStairFlight.NumberOfRiser 
		{ 
			get
			{
				if (NumberOfRiser == null) return null;
				return NumberOfRiser;
			} 
		}
		long? IIfcStairFlight.NumberOfTreads 
		{ 
			get
			{
				if (NumberOfTreads == null) return null;
				return NumberOfTreads;
			} 
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcStairFlight.RiserHeight 
		{ 
			get
			{
				if (!RiserHeight.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(RiserHeight.Value);
			} 
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcStairFlight.TreadLength 
		{ 
			get
			{
				if (!TreadLength.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(TreadLength.Value);
			} 
		}
		Ifc4.SharedBldgElements.IfcStairFlightTypeEnum? IIfcStairFlight.PredefinedType 
		{ 
			get
			{
				//## Handle return of PredefinedType for which no match was found
				//TODO: Handle return of PredefinedType for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
	}
}