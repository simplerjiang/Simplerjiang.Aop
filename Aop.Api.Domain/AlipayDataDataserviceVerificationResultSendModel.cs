using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayDataDataserviceVerificationResultSendModel : AopObject
	{
		[XmlElement("record_id")]
		public long RecordId
		{
			get;
			set;
		}

		[XmlArray("result_items")]
		[XmlArrayItem("dx_verify_result_item")]
		public List<DxVerifyResultItem> ResultItems
		{
			get;
			set;
		}
	}
}
