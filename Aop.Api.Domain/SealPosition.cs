using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SealPosition : AopObject
	{
		[XmlElement("keyword")]
		public string Keyword
		{
			get;
			set;
		}

		[XmlElement("page_no")]
		public long PageNo
		{
			get;
			set;
		}

		[XmlElement("type")]
		public long Type
		{
			get;
			set;
		}

		[XmlElement("x")]
		public long X
		{
			get;
			set;
		}

		[XmlElement("y")]
		public long Y
		{
			get;
			set;
		}
	}
}
