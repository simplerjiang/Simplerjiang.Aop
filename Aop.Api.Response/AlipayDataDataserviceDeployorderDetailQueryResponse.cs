using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayDataDataserviceDeployorderDetailQueryResponse : AopResponse
	{
		[XmlArray("deploy_order_list")]
		[XmlArrayItem("dx_deploy_order_info")]
		public List<DxDeployOrderInfo> DeployOrderList
		{
			get;
			set;
		}
	}
}
