using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsSceneApplicationQueryModel : AopObject
	{
		[XmlElement("application_no")]
		public string ApplicationNo
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlElement("prod_code")]
		public string ProdCode
		{
			get;
			set;
		}
	}
}
