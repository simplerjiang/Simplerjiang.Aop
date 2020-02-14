using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AuthenticationScene : AopObject
	{
		[XmlElement("access_channel")]
		public string AccessChannel
		{
			get;
			set;
		}

		[XmlElement("biz_name")]
		public string BizName
		{
			get;
			set;
		}

		[XmlElement("biz_prod_node")]
		public string BizProdNode
		{
			get;
			set;
		}

		[XmlElement("biz_product")]
		public string BizProduct
		{
			get;
			set;
		}

		[XmlElement("scene_params")]
		public string SceneParams
		{
			get;
			set;
		}
	}
}
