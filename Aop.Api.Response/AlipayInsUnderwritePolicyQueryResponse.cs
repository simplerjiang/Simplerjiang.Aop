using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsUnderwritePolicyQueryResponse : AopResponse
	{
		[XmlElement("policy")]
		public InsPolicy Policy
		{
			get;
			set;
		}
	}
}
