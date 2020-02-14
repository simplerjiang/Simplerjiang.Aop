using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringTablecodeQueryResponse : AopResponse
	{
		[XmlElement("code_flag")]
		public string CodeFlag
		{
			get;
			set;
		}

		[XmlElement("shop_id")]
		public string ShopId
		{
			get;
			set;
		}

		[XmlElement("table_num")]
		public string TableNum
		{
			get;
			set;
		}
	}
}
