using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCreditAutofinanceLoanApplyModel : AopObject
	{
		[XmlElement("area")]
		public string Area
		{
			get;
			set;
		}

		[XmlElement("backurl")]
		public string Backurl
		{
			get;
			set;
		}

		[XmlElement("extparam")]
		public string Extparam
		{
			get;
			set;
		}

		[XmlElement("itemid")]
		public string Itemid
		{
			get;
			set;
		}

		[XmlElement("orgcode")]
		public string Orgcode
		{
			get;
			set;
		}

		[XmlElement("outorderno")]
		public string Outorderno
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

		[XmlElement("verifyid")]
		public string Verifyid
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
