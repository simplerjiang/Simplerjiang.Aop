using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicSettingCategoryQueryResponse : AopResponse
	{
		[XmlElement("primary_category")]
		public string PrimaryCategory
		{
			get;
			set;
		}

		[XmlElement("secondary_category")]
		public string SecondaryCategory
		{
			get;
			set;
		}
	}
}
