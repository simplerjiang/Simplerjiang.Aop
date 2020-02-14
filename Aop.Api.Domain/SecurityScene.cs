using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SecurityScene : AopObject
	{
		[XmlElement("access_channel")]
		public string AccessChannel
		{
			get;
			set;
		}

		[XmlElement("ctu_params")]
		public string CtuParams
		{
			get;
			set;
		}

		[XmlElement("product_name")]
		public string ProductName
		{
			get;
			set;
		}

		[XmlElement("product_node")]
		public string ProductNode
		{
			get;
			set;
		}

		[XmlElement("security_scene_params")]
		public string SecuritySceneParams
		{
			get;
			set;
		}

		[XmlElement("system_name")]
		public string SystemName
		{
			get;
			set;
		}

		[XmlElement("total_fee")]
		public string TotalFee
		{
			get;
			set;
		}
	}
}
