using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMedicalcareCommonDataSyncModel : AopObject
	{
		[XmlElement("app_code")]
		public string AppCode
		{
			get;
			set;
		}

		[XmlElement("data_body")]
		public string DataBody
		{
			get;
			set;
		}

		[XmlElement("data_type")]
		public string DataType
		{
			get;
			set;
		}

		[XmlElement("template_id")]
		public string TemplateId
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
