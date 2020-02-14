using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MedicalSvTpCardActionInfo : AopObject
	{
		[XmlElement("action_code")]
		public string ActionCode
		{
			get;
			set;
		}

		[XmlElement("action_name")]
		public string ActionName
		{
			get;
			set;
		}

		[XmlElement("action_url")]
		public string ActionUrl
		{
			get;
			set;
		}
	}
}
