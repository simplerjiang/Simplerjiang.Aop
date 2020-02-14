using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingDataEnterpriseStaffinfoUploadModel : AopObject
	{
		[XmlElement("batch_id")]
		public string BatchId
		{
			get;
			set;
		}

		[XmlElement("enterprise_name")]
		public string EnterpriseName
		{
			get;
			set;
		}

		[XmlElement("operator_type")]
		public string OperatorType
		{
			get;
			set;
		}

		[XmlArray("staff_info")]
		[XmlArrayItem("staff_info")]
		public List<StaffInfo> StaffInfo
		{
			get;
			set;
		}
	}
}
