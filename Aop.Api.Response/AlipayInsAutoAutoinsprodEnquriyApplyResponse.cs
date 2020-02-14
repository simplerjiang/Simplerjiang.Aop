using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsAutoAutoinsprodEnquriyApplyResponse : AopResponse
	{
		[XmlArray("car_model")]
		[XmlArrayItem("car_model")]
		public List<CarModel> CarModel
		{
			get;
			set;
		}

		[XmlElement("enquiry_biz_id")]
		public string EnquiryBizId
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}
	}
}
