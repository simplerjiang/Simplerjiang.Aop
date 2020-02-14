using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppJfUserinstinfoQueryResponse : AopResponse
	{
		[XmlArray("user_charge_inst_info_list")]
		[XmlArrayItem("ebpp_user_charge_inst_info")]
		public List<EbppUserChargeInstInfo> UserChargeInstInfoList
		{
			get;
			set;
		}
	}
}
