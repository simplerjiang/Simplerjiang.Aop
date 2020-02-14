using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZolozIdentificationUserWebInitializeModel : AopObject
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

		[XmlElement("identity_param")]
		public IdentityParam IdentityParam
		{
			get;
			set;
		}

		[XmlElement("metainfo")]
		public string Metainfo
		{
			get;
			set;
		}
	}
}
