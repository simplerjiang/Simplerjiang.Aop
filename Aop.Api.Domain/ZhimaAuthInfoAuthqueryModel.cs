using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZhimaAuthInfoAuthqueryModel : AopObject
	{
		[XmlElement("identity_param")]
		public string IdentityParam
		{
			get;
			set;
		}
	}
}
