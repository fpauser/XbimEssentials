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
namespace Xbim.Ifc2x3.ExternalReferenceResource
{
	public partial class @IfcDocumentReference : IIfcDocumentReference
	{
		Ifc4.MeasureResource.IfcText? IIfcDocumentReference.Description 
		{ 
			get
			{
				//## Handle return of Description for which no match was found
				//TODO: Handle return of Description for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
		IIfcDocumentInformation IIfcDocumentReference.ReferencedDocument 
		{ 
			get
			{
				//## Handle return of ReferencedDocument for which no match was found
				//TODO: Handle return of ReferencedDocument for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
		IEnumerable<IIfcRelAssociatesDocument> IIfcDocumentReference.DocumentRefForObjects 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAssociatesDocument>(e => (e.RelatingDocument as IfcDocumentReference) == this);
			} 
		}
	}
}