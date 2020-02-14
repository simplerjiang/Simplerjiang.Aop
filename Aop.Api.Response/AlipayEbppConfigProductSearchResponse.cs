using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppConfigProductSearchResponse : AopResponse
	{
		[XmlElement("charge_inst")]
		public string ChargeInst
		{
			get;
			set;
		}

		[XmlElement("chargeoff_inst")]
		public string ChargeoffInst
		{
			get;
			set;
		}

		[XmlElement("error_code")]
		public string ErrorCode
		{
			get;
			set;
		}

		[XmlElement("error_message")]
		public string ErrorMessage
		{
			get;
			set;
		}

		[XmlArray("input_field_list")]
		[XmlArrayItem("input_field_model")]
		public List<InputFieldModel> InputFieldList
		{
			get;
			set;
		}

		[XmlElement("is_success")]
		public string IsSuccess
		{
			get;
			set;
		}
	}
}
