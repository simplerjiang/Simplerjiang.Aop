using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ProdParams : AopObject
	{
		[XmlElement("auth_biz_params")]
		public string AuthBizParams
		{
			get;
			set;
		}
	}
}
