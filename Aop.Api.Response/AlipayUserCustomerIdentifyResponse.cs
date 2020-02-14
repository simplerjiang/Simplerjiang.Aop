using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserCustomerIdentifyResponse : AopResponse
	{
		[XmlArray("activity_list")]
		[XmlArrayItem("alipay_user_cust_identify_activity")]
		public List<AlipayUserCustIdentifyActivity> ActivityList
		{
			get;
			set;
		}

		[XmlElement("user_profile")]
		public string UserProfile
		{
			get;
			set;
		}
	}
}
