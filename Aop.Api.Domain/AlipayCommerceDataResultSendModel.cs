using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceDataResultSendModel : AopObject
	{
		[XmlElement("channel")]
		public string Channel
		{
			get;
			set;
		}

		[XmlElement("interface_version")]
		public string InterfaceVersion
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

		[XmlElement("result_code")]
		public string ResultCode
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
	}
}
