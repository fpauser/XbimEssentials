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
	public partial class @IfcLampType : IIfcLampType
	{
		Ifc4.ElectricalDomain.IfcLampTypeEnum IIfcLampType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcLampTypeEnum.COMPACTFLUORESCENT:
						return Ifc4.ElectricalDomain.IfcLampTypeEnum.COMPACTFLUORESCENT;
					
					case IfcLampTypeEnum.FLUORESCENT:
						return Ifc4.ElectricalDomain.IfcLampTypeEnum.FLUORESCENT;
					
					case IfcLampTypeEnum.HIGHPRESSUREMERCURY:
						return Ifc4.ElectricalDomain.IfcLampTypeEnum.HIGHPRESSUREMERCURY;
					
					case IfcLampTypeEnum.HIGHPRESSURESODIUM:
						return Ifc4.ElectricalDomain.IfcLampTypeEnum.HIGHPRESSURESODIUM;
					
					case IfcLampTypeEnum.METALHALIDE:
						return Ifc4.ElectricalDomain.IfcLampTypeEnum.METALHALIDE;
					
					case IfcLampTypeEnum.TUNGSTENFILAMENT:
						return Ifc4.ElectricalDomain.IfcLampTypeEnum.TUNGSTENFILAMENT;
					
					case IfcLampTypeEnum.USERDEFINED:
						return Ifc4.ElectricalDomain.IfcLampTypeEnum.USERDEFINED;
					
					case IfcLampTypeEnum.NOTDEFINED:
						return Ifc4.ElectricalDomain.IfcLampTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	}
}