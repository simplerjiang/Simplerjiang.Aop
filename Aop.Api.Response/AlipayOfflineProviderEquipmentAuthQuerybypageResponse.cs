using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOfflineProviderEquipmentAuthQuerybypageResponse : AopResponse
	{
		[XmlArray("equipmentauthremovequerybypagelist")]
		[XmlArrayItem("equipment_auth_remove_query_bypage_d_t_o")]
		public List<EquipmentAuthRemoveQueryBypageDTO> Equipmentauthremovequerybypagelist
		{
			get;
			set;
		}

		[XmlElement("total")]
		public long Total
		{
			get;
			set;
		}
	}
}
