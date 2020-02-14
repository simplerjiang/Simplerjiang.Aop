using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZolozIdentificationUserWebQueryModel : AopObject
	{
		[XmlElement("biz_id")]
		public string BizId
		{
			get;
			set;
		}

		[XmlElement("extern_param")]
		public string ExternParam
		{
			get;
			set;
		}

		[XmlElement("zim_id")]
		public string ZimId
		{
			get;
			set;
		}
	}
}
