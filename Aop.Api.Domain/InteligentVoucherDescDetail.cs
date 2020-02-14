using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InteligentVoucherDescDetail : AopObject
	{
		[XmlElement("details")]
		public string Details
		{
			get;
			set;
		}

		[XmlElement("images")]
		public string Images
		{
			get;
			set;
		}

		[XmlElement("title")]
		public string Title
		{
			get;
			set;
		}

		[XmlElement("url")]
		public string Url
		{
			get;
			set;
		}
	}
}
