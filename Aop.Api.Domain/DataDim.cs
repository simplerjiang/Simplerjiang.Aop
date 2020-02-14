using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DataDim : AopObject
	{
		[XmlElement("dim_name")]
		public string DimName
		{
			get;
			set;
		}

		[XmlElement("dim_type")]
		public string DimType
		{
			get;
			set;
		}

		[XmlElement("dim_value")]
		public string DimValue
		{
			get;
			set;
		}
	}
}
