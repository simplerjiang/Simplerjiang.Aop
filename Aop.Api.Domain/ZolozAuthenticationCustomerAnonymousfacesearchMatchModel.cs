using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZolozAuthenticationCustomerAnonymousfacesearchMatchModel : AopObject
	{
		[XmlElement("antiattack")]
		public string Antiattack
		{
			get;
			set;
		}

		[XmlElement("areacode")]
		public string Areacode
		{
			get;
			set;
		}

		[XmlElement("authimg")]
		public string Authimg
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
