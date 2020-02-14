using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoCmsCdataUploadModel : AopObject
	{
		[XmlElement("attribute")]
		public string Attribute
		{
			get;
			set;
		}

		[XmlElement("category")]
		public string Category
		{
			get;
			set;
		}

		[XmlElement("exp_time")]
		public string ExpTime
		{
			get;
			set;
		}

		[XmlElement("merch_id")]
		public string MerchId
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

		[XmlElement("scene_data")]
		public string SceneData
		{
			get;
			set;
		}

		[XmlElement("start_time")]
		public string StartTime
		{
			get;
			set;
		}

		[XmlElement("syn")]
		public bool Syn
		{
			get;
			set;
		}

		[XmlElement("t_v")]
		public string TV
		{
			get;
			set;
		}

		[XmlElement("tamplate_id")]
		public long TamplateId
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
	}
}
