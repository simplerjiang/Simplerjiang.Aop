using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiRetailWmsDeliverypackageQueryResponse : AopResponse
	{
		[XmlArray("delivery_package_vo_list")]
		[XmlArrayItem("delivery_package_v_o")]
		public List<DeliveryPackageVO> DeliveryPackageVoList
		{
			get;
			set;
		}
	}
}
