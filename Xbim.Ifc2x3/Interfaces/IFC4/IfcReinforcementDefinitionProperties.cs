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
namespace Xbim.Ifc2x3.StructuralElementsDomain
{
	public partial class @IfcReinforcementDefinitionProperties : IIfcReinforcementDefinitionProperties
	{
		Ifc4.MeasureResource.IfcLabel? IIfcReinforcementDefinitionProperties.DefinitionType 
		{ 
			get
			{
				if (!DefinitionType.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(DefinitionType.Value);
			} 
		}
		IEnumerable<IIfcSectionReinforcementProperties> IIfcReinforcementDefinitionProperties.ReinforcementSectionDefinitions 
		{ 
			get
			{
			foreach (var member in ReinforcementSectionDefinitions)
			{
				yield return member as IIfcSectionReinforcementProperties;
			}
			} 
		}
	}
}