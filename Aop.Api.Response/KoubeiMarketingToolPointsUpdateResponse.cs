using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingToolPointsUpdateResponse : AopResponse
	{
		[XmlElement("point_log_no")]
		public string PointLogNo
		{
			get;
			set;
		}
	}
}
