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
namespace Xbim.Ifc2x3.HVACDomain
{
	public partial class @IfcDuctSilencerType : IIfcDuctSilencerType
	{
		Ifc4.HvacDomain.IfcDuctSilencerTypeEnum IIfcDuctSilencerType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcDuctSilencerTypeEnum.FLATOVAL:
						return Ifc4.HvacDomain.IfcDuctSilencerTypeEnum.FLATOVAL;
					
					case IfcDuctSilencerTypeEnum.RECTANGULAR:
						return Ifc4.HvacDomain.IfcDuctSilencerTypeEnum.RECTANGULAR;
					
					case IfcDuctSilencerTypeEnum.ROUND:
						return Ifc4.HvacDomain.IfcDuctSilencerTypeEnum.ROUND;
					
					case IfcDuctSilencerTypeEnum.USERDEFINED:
						return Ifc4.HvacDomain.IfcDuctSilencerTypeEnum.USERDEFINED;
					
					case IfcDuctSilencerTypeEnum.NOTDEFINED:
						return Ifc4.HvacDomain.IfcDuctSilencerTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	}
}