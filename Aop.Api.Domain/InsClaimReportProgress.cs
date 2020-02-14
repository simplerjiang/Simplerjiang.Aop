using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsClaimReportProgress : AopObject
	{
		[XmlElement("progress_update_content")]
		public string ProgressUpdateContent
		{
			get;
			set;
		}

		[XmlElement("progress_update_time")]
		public string ProgressUpdateTime
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
