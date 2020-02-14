using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingDataBizadviserMemberprofileQueryResponse : AopResponse
	{
		[XmlElement("result")]
		public string Result
		{
			get;
			set;
		}
	}
}
