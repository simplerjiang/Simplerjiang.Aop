using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MedicalSvTpCardBodyInfo : AopObject
	{
		[XmlElement("content")]
		public string Content
		{
			get;
			set;
		}

		[XmlElement("image_url")]
		public string ImageUrl
		{
			get;
			set;
		}

		[XmlElement("link_url")]
		public string LinkUrl
		{
			get;
			set;
		}

		[XmlElement("remark")]
		public string Remark
		{
			get;
			set;
		}

		[XmlElement("sub_contenet")]
		public string SubContenet
		{
			get;
			set;
		}

		[XmlElement("sub_title")]
		public string SubTitle
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
	}
}
