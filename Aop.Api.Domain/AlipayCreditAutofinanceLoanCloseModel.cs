using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCreditAutofinanceLoanCloseModel : AopObject
	{
		[XmlElement("applyno")]
		public string Applyno
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

		[XmlElement("reson")]
		public string Reson
		{
			get;
			set;
		}

		[XmlElement("type")]
		public string Type
		{
			get;
			set;
		}
	}
}
