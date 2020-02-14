using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsAutoUserPointQueryResponse : AopResponse
	{
		[XmlElement("can_exchange")]
		public bool CanExchange
		{
			get;
			set;
		}

		[XmlElement("can_exchange_amount")]
		public long CanExchangeAmount
		{
			get;
			set;
		}

		[XmlElement("can_save_amount")]
		public long CanSaveAmount
		{
			get;
			set;
		}

		[XmlElement("can_use_amount")]
		public long CanUseAmount
		{
			get;
			set;
		}

		[XmlElement("recommend_exchange")]
		public bool RecommendExchange
		{
			get;
			set;
		}

		[XmlElement("total_limit")]
		public long TotalLimit
		{
			get;
			set;
		}

		[XmlElement("total_save_amount")]
		public long TotalSaveAmount
		{
			get;
			set;
		}
	}
}
