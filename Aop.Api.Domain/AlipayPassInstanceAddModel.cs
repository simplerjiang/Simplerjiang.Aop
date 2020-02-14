using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayPassInstanceAddModel : AopObject
	{
		[XmlElement("recognition_info")]
		public string RecognitionInfo
		{
			get;
			set;
		}

		[XmlElement("recognition_type")]
		public string RecognitionType
		{
			get;
			set;
		}

		[XmlElement("tpl_id")]
		public string TplId
		{
			get;
			set;
		}

		[XmlElement("tpl_params")]
		public string TplParams
		{
			get;
			set;
		}
	}
}
