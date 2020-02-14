using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiAdvertDataPromotesummaryQueryResponse : AopResponse
	{
		[XmlElement("kb_platform_promote_data")]
		public PromoteDataModel KbPlatformPromoteData
		{
			get;
			set;
		}

		[XmlElement("others_promote_data")]
		public PromoteDataModel OthersPromoteData
		{
			get;
			set;
		}

		[XmlElement("part_promote_data")]
		public PromoteDataModel PartPromoteData
		{
			get;
			set;
		}

		[XmlElement("self_promote_data")]
		public PromoteDataModel SelfPromoteData
		{
			get;
			set;
		}

		[XmlElement("total_promote_data")]
		public PromoteDataModel TotalPromoteData
		{
			get;
			set;
		}
	}
}
