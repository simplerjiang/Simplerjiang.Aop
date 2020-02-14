using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ProductProvider : AopObject
	{
		[XmlElement("agency")]
		public string Agency
		{
			get;
			set;
		}

		[XmlElement("agency_name")]
		public string AgencyName
		{
			get;
			set;
		}

		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("id")]
		public string Id
		{
			get;
			set;
		}

		[XmlElement("sub_biz_type")]
		public string SubBizType
		{
			get;
			set;
		}

		[XmlElement("sub_operator")]
		public string SubOperator
		{
			get;
			set;
		}

		[XmlElement("sub_operator_name")]
		public string SubOperatorName
		{
			get;
			set;
		}
	}
}
