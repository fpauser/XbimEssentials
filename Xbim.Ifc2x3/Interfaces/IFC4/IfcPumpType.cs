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
	public partial class @IfcPumpType : IIfcPumpType
	{
		Ifc4.HvacDomain.IfcPumpTypeEnum IIfcPumpType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcPumpTypeEnum.CIRCULATOR:
						return Ifc4.HvacDomain.IfcPumpTypeEnum.CIRCULATOR;
					
					case IfcPumpTypeEnum.ENDSUCTION:
						return Ifc4.HvacDomain.IfcPumpTypeEnum.ENDSUCTION;
					
					case IfcPumpTypeEnum.SPLITCASE:
						return Ifc4.HvacDomain.IfcPumpTypeEnum.SPLITCASE;
					
					case IfcPumpTypeEnum.VERTICALINLINE:
						return Ifc4.HvacDomain.IfcPumpTypeEnum.VERTICALINLINE;
					
					case IfcPumpTypeEnum.VERTICALTURBINE:
						return Ifc4.HvacDomain.IfcPumpTypeEnum.VERTICALTURBINE;
					
					case IfcPumpTypeEnum.USERDEFINED:
						return Ifc4.HvacDomain.IfcPumpTypeEnum.USERDEFINED;
					
					case IfcPumpTypeEnum.NOTDEFINED:
						return Ifc4.HvacDomain.IfcPumpTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	}
}