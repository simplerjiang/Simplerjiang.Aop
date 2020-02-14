using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMemberDataTagQueryResponse : AopResponse
	{
		[XmlElement("card_member")]
		public bool CardMember
		{
			get;
			set;
		}

		[XmlElement("cate_prefer_label")]
		public string CatePreferLabel
		{
			get;
			set;
		}

		[XmlElement("fashion_label")]
		public string FashionLabel
		{
			get;
			set;
		}

		[XmlElement("taste_prefer_label")]
		public string TastePreferLabel
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
