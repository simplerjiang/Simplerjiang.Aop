using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserCertDocIDCard : AopObject
	{
		[XmlElement("encoded_img_emblem")]
		public string EncodedImgEmblem
		{
			get;
			set;
		}

		[XmlElement("encoded_img_identity")]
		public string EncodedImgIdentity
		{
			get;
			set;
		}

		[XmlElement("expire_date")]
		public string ExpireDate
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}

		[XmlElement("number")]
		public string Number
		{
			get;
			set;
		}
	}
}
