using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceDataSendModel : AopObject
	{
		[XmlElement("channel")]
		public string Channel
		{
			get;
			set;
		}

		[XmlElement("op_code")]
		public string OpCode
		{
			get;
			set;
		}

		[XmlElement("op_data")]
		public string OpData
		{
			get;
			set;
		}

		[XmlElement("scene_code")]
		public string SceneCode
		{
			get;
			set;
		}

		[XmlElement("scene_data")]
		public string SceneData
		{
			get;
			set;
		}

		[XmlElement("target_id")]
		public string TargetId
		{
			get;
			set;
		}

		[XmlElement("target_id_type")]
		public string TargetIdType
		{
			get;
			set;
		}

		[XmlElement("version")]
		public string Version
		{
			get;
			set;
		}
	}
}
