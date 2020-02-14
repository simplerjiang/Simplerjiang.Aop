using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsOffilneProduct : AopObject
	{
		[XmlElement("biz_data")]
		public string BizData
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

		[XmlElement("prod_name")]
		public string ProdName
		{
			get;
			set;
		}
	}
}
