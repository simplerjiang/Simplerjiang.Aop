using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayAssetPointBalanceQueryResponse : AopResponse
	{
		[XmlElement("point_amount")]
		public long PointAmount
		{
			get;
			set;
		}
	}
}
