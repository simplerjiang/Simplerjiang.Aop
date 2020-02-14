using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserFunditemGetResponse : AopResponse
	{
		[XmlElement("fund_detail_item_aopmodel")]
		public FundDetailItemAOPModel FundDetailItemAopmodel
		{
			get;
			set;
		}
	}
}
