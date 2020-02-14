using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZolozAuthenticationCustomerFacemanageCreateModel : AopObject
	{
		[XmlElement("areacode")]
		public string Areacode
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

		[XmlElement("bizscale")]
		public string Bizscale
		{
			get;
			set;
		}

		[XmlElement("brandcode")]
		public string Brandcode
		{
			get;
			set;
		}

		[XmlElement("devicenum")]
		public string Devicenum
		{
			get;
			set;
		}

		[XmlElement("extinfo")]
		public string Extinfo
		{
			get;
			set;
		}

		[XmlElement("facetype")]
		public string Facetype
		{
			get;
			set;
		}

		[XmlElement("faceval")]
		public string Faceval
		{
			get;
			set;
		}

		[XmlElement("group")]
		public string Group
		{
			get;
			set;
		}

		[XmlElement("storecode")]
		public string Storecode
		{
			get;
			set;
		}

		[XmlElement("validtimes")]
		public string Validtimes
		{
			get;
			set;
		}
	}
}
