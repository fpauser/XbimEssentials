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
namespace Xbim.Ifc2x3.ActorResource
{
	public partial class @IfcPersonAndOrganization : IIfcPersonAndOrganization
	{
		IIfcPerson IIfcPersonAndOrganization.ThePerson 
		{ 
			get
			{
				return ThePerson;
			} 
		}
		IIfcOrganization IIfcPersonAndOrganization.TheOrganization 
		{ 
			get
			{
				return TheOrganization;
			} 
		}
		IEnumerable<IIfcActorRole> IIfcPersonAndOrganization.Roles 
		{ 
			get
			{
			foreach (var member in Roles)
			{
				yield return member as IIfcActorRole;
			}
			} 
		}
	}
}