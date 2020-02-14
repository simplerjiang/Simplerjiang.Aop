using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoRenthouseCommonImageUploadModel : AopObject
	{
		[XmlElement("file_base")]
		public string FileBase
		{
			get;
			set;
		}

		[XmlElement("file_type")]
		public string FileType
		{
			get;
			set;
		}

		[XmlElement("is_public")]
		public bool IsPublic
		{
			get;
			set;
		}
	}
}
