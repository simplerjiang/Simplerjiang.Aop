using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankFinanceYulibaoAccountQueryResponse : AopResponse
	{
		[XmlElement("available_amount")]
		public string AvailableAmount
		{
			get;
			set;
		}

		[XmlElement("freeze_amount")]
		public string FreezeAmount
		{
			get;
			set;
		}

		[XmlElement("sys_freeze_amount")]
		public string SysFreezeAmount
		{
			get;
			set;
		}

		[XmlElement("total_amount")]
		public string TotalAmount
		{
			get;
			set;
		}

		[XmlElement("ylb_profit_detail_info")]
		public YLBProfitDetailInfo YlbProfitDetailInfo
		{
			get;
			set;
		}
	}
}
