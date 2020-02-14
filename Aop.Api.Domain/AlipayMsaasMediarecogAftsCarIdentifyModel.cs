using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMsaasMediarecogAftsCarIdentifyModel : AopObject
	{
		[XmlElement("ext")]
		public string Ext
		{
			get;
			set;
		}

		[XmlElement("h")]
		public long H
		{
			get;
			set;
		}

		[XmlElement("kilometres")]
		public long Kilometres
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

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}

		[XmlElement("w")]
		public long W
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
