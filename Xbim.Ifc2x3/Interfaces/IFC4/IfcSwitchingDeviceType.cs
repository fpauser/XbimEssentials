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
namespace Xbim.Ifc2x3.ElectricalDomain
{
	public partial class @IfcSwitchingDeviceType : IIfcSwitchingDeviceType
	{
		Ifc4.ElectricalDomain.IfcSwitchingDeviceTypeEnum IIfcSwitchingDeviceType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcSwitchingDeviceTypeEnum.CONTACTOR:
						return Ifc4.ElectricalDomain.IfcSwitchingDeviceTypeEnum.CONTACTOR;
					
					case IfcSwitchingDeviceTypeEnum.EMERGENCYSTOP:
						return Ifc4.ElectricalDomain.IfcSwitchingDeviceTypeEnum.EMERGENCYSTOP;
					
					case IfcSwitchingDeviceTypeEnum.STARTER:
						return Ifc4.ElectricalDomain.IfcSwitchingDeviceTypeEnum.STARTER;
					
					case IfcSwitchingDeviceTypeEnum.SWITCHDISCONNECTOR:
						return Ifc4.ElectricalDomain.IfcSwitchingDeviceTypeEnum.SWITCHDISCONNECTOR;
					
					case IfcSwitchingDeviceTypeEnum.TOGGLESWITCH:
						return Ifc4.ElectricalDomain.IfcSwitchingDeviceTypeEnum.TOGGLESWITCH;
					
					case IfcSwitchingDeviceTypeEnum.USERDEFINED:
						return Ifc4.ElectricalDomain.IfcSwitchingDeviceTypeEnum.USERDEFINED;
					
					case IfcSwitchingDeviceTypeEnum.NOTDEFINED:
						return Ifc4.ElectricalDomain.IfcSwitchingDeviceTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	}
}