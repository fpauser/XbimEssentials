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
namespace Xbim.Ifc2x3.ProfileResource
{
	public partial class @IfcCompositeProfileDef : IIfcCompositeProfileDef
	{
		IEnumerable<IIfcProfileDef> IIfcCompositeProfileDef.Profiles 
		{ 
			get
			{
			foreach (var member in Profiles)
			{
				yield return member as IIfcProfileDef;
			}
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcCompositeProfileDef.Label 
		{ 
			get
			{
				if (!Label.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Label.Value);
			} 
		}
	}
}