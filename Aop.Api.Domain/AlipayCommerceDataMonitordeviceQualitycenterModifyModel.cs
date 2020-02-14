using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceDataMonitordeviceQualitycenterModifyModel : AopObject
	{
		[XmlElement("asset_id")]
		public string AssetId
		{
			get;
			set;
		}

		[XmlElement("fault_type")]
		public string FaultType
		{
			get;
			set;
		}

		[XmlElement("invoke_id")]
		public long InvokeId
		{
			get;
			set;
		}

		[XmlElement("quality_center_id")]
		public string QualityCenterId
		{
			get;
			set;
		}

		[XmlElement("result")]
		public string Result
		{
			get;
			set;
		}

		[XmlElement("result_date")]
		public string ResultDate
		{
			get;
			set;
		}

		[XmlElement("result_msg")]
		public string ResultMsg
		{
			get;
			set;
		}
	}
}
