using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsSceneClaimAttachmentConfirmModel : AopObject
	{
		[XmlElement("claim_report_no")]
		public string ClaimReportNo
		{
			get;
			set;
		}

		[XmlArray("upload_files")]
		[XmlArrayItem("string")]
		public List<string> UploadFiles
		{
			get;
			set;
		}
	}
}
