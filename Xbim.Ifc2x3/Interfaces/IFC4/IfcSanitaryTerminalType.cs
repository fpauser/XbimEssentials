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
namespace Xbim.Ifc2x3.PlumbingFireProtectionDomain
{
	public partial class @IfcSanitaryTerminalType : IIfcSanitaryTerminalType
	{
		Ifc4.PlumbingFireProtectionDomain.IfcSanitaryTerminalTypeEnum IIfcSanitaryTerminalType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcSanitaryTerminalTypeEnum.BATH:
						return Ifc4.PlumbingFireProtectionDomain.IfcSanitaryTerminalTypeEnum.BATH;
					
					case IfcSanitaryTerminalTypeEnum.BIDET:
						return Ifc4.PlumbingFireProtectionDomain.IfcSanitaryTerminalTypeEnum.BIDET;
					
					case IfcSanitaryTerminalTypeEnum.CISTERN:
						return Ifc4.PlumbingFireProtectionDomain.IfcSanitaryTerminalTypeEnum.CISTERN;
					
					case IfcSanitaryTerminalTypeEnum.SHOWER:
						return Ifc4.PlumbingFireProtectionDomain.IfcSanitaryTerminalTypeEnum.SHOWER;
					
					case IfcSanitaryTerminalTypeEnum.SINK:
						return Ifc4.PlumbingFireProtectionDomain.IfcSanitaryTerminalTypeEnum.SINK;
					
					case IfcSanitaryTerminalTypeEnum.SANITARYFOUNTAIN:
						return Ifc4.PlumbingFireProtectionDomain.IfcSanitaryTerminalTypeEnum.SANITARYFOUNTAIN;
					
					case IfcSanitaryTerminalTypeEnum.TOILETPAN:
						return Ifc4.PlumbingFireProtectionDomain.IfcSanitaryTerminalTypeEnum.TOILETPAN;
					
					case IfcSanitaryTerminalTypeEnum.URINAL:
						return Ifc4.PlumbingFireProtectionDomain.IfcSanitaryTerminalTypeEnum.URINAL;
					
					case IfcSanitaryTerminalTypeEnum.WASHHANDBASIN:
						return Ifc4.PlumbingFireProtectionDomain.IfcSanitaryTerminalTypeEnum.WASHHANDBASIN;
					
					case IfcSanitaryTerminalTypeEnum.WCSEAT:
						return Ifc4.PlumbingFireProtectionDomain.IfcSanitaryTerminalTypeEnum.WCSEAT;
					
					case IfcSanitaryTerminalTypeEnum.USERDEFINED:
						return Ifc4.PlumbingFireProtectionDomain.IfcSanitaryTerminalTypeEnum.USERDEFINED;
					
					case IfcSanitaryTerminalTypeEnum.NOTDEFINED:
						return Ifc4.PlumbingFireProtectionDomain.IfcSanitaryTerminalTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	}
}