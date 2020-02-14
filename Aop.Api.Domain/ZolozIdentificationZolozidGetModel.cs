using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZolozIdentificationZolozidGetModel : AopObject
	{
		[XmlElement("action")]
		public string Action
		{
			get;
			set;
		}

		[XmlElement("biz_id")]
		public string BizId
		{
			get;
			set;
		}

		[XmlElement("extern_params")]
		public string ExternParams
		{
			get;
			set;
		}

		[XmlElement("zcif_params")]
		public string ZcifParams
		{
			get;
			set;
		}
	}
}
