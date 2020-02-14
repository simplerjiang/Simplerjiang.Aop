using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarViolationInfoPushModel : AopObject
	{
		[XmlElement("deal_type")]
		public string DealType
		{
			get;
			set;
		}

		[XmlElement("push_type")]
		public string PushType
		{
			get;
			set;
		}

		[XmlElement("vi_address")]
		public string ViAddress
		{
			get;
			set;
		}

		[XmlElement("vi_fine")]
		public string ViFine
		{
			get;
			set;
		}

		[XmlElement("vi_handled")]
		public string ViHandled
		{
			get;
			set;
		}

		[XmlElement("vi_number")]
		public string ViNumber
		{
			get;
			set;
		}

		[XmlElement("vi_point")]
		public string ViPoint
		{
			get;
			set;
		}

		[XmlElement("vi_time")]
		public string ViTime
		{
			get;
			set;
		}

		[XmlElement("vi_type")]
		public string ViType
		{
			get;
			set;
		}
	}
}
