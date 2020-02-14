using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFinanceFundFundFixedprofitQueryResponse : AopResponse
	{
		[XmlElement("last_five_year")]
		public string LastFiveYear
		{
			get;
			set;
		}

		[XmlElement("last_one_year")]
		public string LastOneYear
		{
			get;
			set;
		}

		[XmlElement("last_three_year")]
		public string LastThreeYear
		{
			get;
			set;
		}

		[XmlElement("last_two_year")]
		public string LastTwoYear
		{
			get;
			set;
		}

		[XmlElement("since_establish")]
		public string SinceEstablish
		{
			get;
			set;
		}
	}
}
