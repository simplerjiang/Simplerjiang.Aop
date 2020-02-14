using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AntMerchantExpandIndirectAttachmentUploadModel : AopObject
	{
		[XmlArray("attachment_info")]
		[XmlArrayItem("attachment_info")]
		public List<AttachmentInfo> AttachmentInfo
		{
			get;
			set;
		}

		[XmlElement("memo")]
		public string Memo
		{
			get;
			set;
		}

		[XmlElement("sub_merchant_id")]
		public string SubMerchantId
		{
			get;
			set;
		}
	}
}
