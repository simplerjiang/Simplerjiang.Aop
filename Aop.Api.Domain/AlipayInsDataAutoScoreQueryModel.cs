using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsDataAutoScoreQueryModel : AopObject
	{
		[XmlElement("area_id")]
		public string AreaId
		{
			get;
			set;
		}

		[XmlElement("biz_no")]
		public string BizNo
		{
			get;
			set;
		}

		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("car_frame_no")]
		public string CarFrameNo
		{
			get;
			set;
		}

		[XmlElement("car_no")]
		public string CarNo
		{
			get;
			set;
		}

		[XmlElement("cert_name")]
		public string CertName
		{
			get;
			set;
		}

		[XmlElement("cert_no")]
		public string CertNo
		{
			get;
			set;
		}

		[XmlElement("cert_type")]
		public string CertType
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("role_type")]
		public string RoleType
		{
			get;
			set;
		}

		[XmlElement("score_type")]
		public string ScoreType
		{
			get;
			set;
		}

		[XmlElement("uuid")]
		public string Uuid
		{
			get;
			set;
		}
	}
}
