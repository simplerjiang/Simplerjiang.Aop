using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SubMerchantEnterOpenModel : AopObject
	{
		[XmlElement("pid")]
		public string Pid
		{
			get;
			set;
		}

		[XmlElement("register_no")]
		public string RegisterNo
		{
			get;
			set;
		}

		[XmlElement("sub_m_name")]
		public string SubMName
		{
			get;
			set;
		}

		[XmlElement("sub_m_short_name")]
		public string SubMShortName
		{
			get;
			set;
		}
	}
}
