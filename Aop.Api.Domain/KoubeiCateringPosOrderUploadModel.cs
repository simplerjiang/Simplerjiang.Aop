using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCateringPosOrderUploadModel : AopObject
	{
		[XmlArray("pos_device_infos")]
		[XmlArrayItem("pos_device_info_v_o")]
		public List<PosDeviceInfoVO> PosDeviceInfos
		{
			get;
			set;
		}

		[XmlArray("pos_order_infos")]
		[XmlArrayItem("pos_order_info_v_o")]
		public List<PosOrderInfoVO> PosOrderInfos
		{
			get;
			set;
		}

		[XmlElement("source_type")]
		public string SourceType
		{
			get;
			set;
		}
	}
}
