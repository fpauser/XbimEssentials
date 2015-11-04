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
namespace Xbim.Ifc2x3.ConstraintResource
{
	public partial class @IfcMetric : IIfcMetric
	{
		Ifc4.ConstraintResource.IfcBenchmarkEnum IIfcMetric.Benchmark 
		{ 
			get
			{
				switch (Benchmark)
				{
					case IfcBenchmarkEnum.GREATERTHAN:
						return Ifc4.ConstraintResource.IfcBenchmarkEnum.GREATERTHAN;
					
					case IfcBenchmarkEnum.GREATERTHANOREQUALTO:
						return Ifc4.ConstraintResource.IfcBenchmarkEnum.GREATERTHANOREQUALTO;
					
					case IfcBenchmarkEnum.LESSTHAN:
						return Ifc4.ConstraintResource.IfcBenchmarkEnum.LESSTHAN;
					
					case IfcBenchmarkEnum.LESSTHANOREQUALTO:
						return Ifc4.ConstraintResource.IfcBenchmarkEnum.LESSTHANOREQUALTO;
					
					case IfcBenchmarkEnum.EQUALTO:
						return Ifc4.ConstraintResource.IfcBenchmarkEnum.EQUALTO;
					
					case IfcBenchmarkEnum.NOTEQUALTO:
						return Ifc4.ConstraintResource.IfcBenchmarkEnum.NOTEQUALTO;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcMetric.ValueSource 
		{ 
			get
			{
				if (!ValueSource.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(ValueSource.Value);
			} 
		}
		Ifc4.ConstraintResource.IfcMetricValueSelect IIfcMetric.DataValue 
		{ 
			get
			{
				if (DataValue == null) return null;
				var ifccalendardate = DataValue as DateTimeResource.IfcCalendarDate;
				if (ifccalendardate != null) 
					//## Handle entity IfcCalendarDate which is not a part of the target select interface Ifc4.ConstraintResource.IfcMetricValueSelect in property DataValue
					//TODO: Handle entity IfcCalendarDate which is not a part of the target select interface Ifc4.ConstraintResource.IfcMetricValueSelect in property DataValue
					throw new System.NotImplementedException();
					//##
				var ifclocaltime = DataValue as DateTimeResource.IfcLocalTime;
				if (ifclocaltime != null) 
					//## Handle entity IfcLocalTime which is not a part of the target select interface Ifc4.ConstraintResource.IfcMetricValueSelect in property DataValue
					//TODO: Handle entity IfcLocalTime which is not a part of the target select interface Ifc4.ConstraintResource.IfcMetricValueSelect in property DataValue
					throw new System.NotImplementedException();
					//##
				var ifcdateandtime = DataValue as DateTimeResource.IfcDateAndTime;
				if (ifcdateandtime != null) 
					//## Handle entity IfcDateAndTime which is not a part of the target select interface Ifc4.ConstraintResource.IfcMetricValueSelect in property DataValue
					//TODO: Handle entity IfcDateAndTime which is not a part of the target select interface Ifc4.ConstraintResource.IfcMetricValueSelect in property DataValue
					throw new System.NotImplementedException();
					//##
				var ifcmeasurewithunit = DataValue as MeasureResource.IfcMeasureWithUnit;
				if (ifcmeasurewithunit != null) 
					return ifcmeasurewithunit;
				var ifctable = DataValue as UtilityResource.IfcTable;
				if (ifctable != null) 
					return ifctable;
				if (DataValue is MeasureResource.IfcText) 
					return new Ifc4.MeasureResource.IfcText((string)(MeasureResource.IfcText)DataValue);
				var ifctimeseries = DataValue as TimeSeriesResource.IfcTimeSeries;
				if (ifctimeseries != null) 
					return ifctimeseries;
				var ifccostvalue = DataValue as CostResource.IfcCostValue;
				if (ifccostvalue != null) 
					return ifccostvalue;
				return null;
			} 
		}
		IIfcReference IIfcMetric.ReferencePath 
		{ 
			get
			{
				//## Handle return of ReferencePath for which no match was found
				//TODO: Handle return of ReferencePath for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
	}
}