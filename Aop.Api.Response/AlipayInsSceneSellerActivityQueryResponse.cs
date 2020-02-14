using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsSceneSellerActivityQueryResponse : AopResponse
	{
		[XmlElement("ins_seller_activity")]
		public InsSellerActivity InsSellerActivity
		{
			get;
			set;
		}
	}
}
