using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCreditAutofinanceVidGetModel : AopObject
	{
		[XmlElement("orgcode")]
		public string Orgcode
		{
			get;
			set;
		}

		[XmlElement("uid")]
		public string Uid
		{
			get;
			set;
		}

		[XmlElement("version")]
		public string Version
		{
			get;
			set;
		}
	}
}
