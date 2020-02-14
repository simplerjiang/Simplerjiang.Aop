using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityProdIrisVerifyModel : AopObject
	{
		[XmlElement("biz_token")]
		public string BizToken
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

		[XmlElement("group_id")]
		public string GroupId
		{
			get;
			set;
		}

		[XmlElement("iris_str")]
		public string IrisStr
		{
			get;
			set;
		}

		[XmlElement("operate_type")]
		public string OperateType
		{
			get;
			set;
		}

		[XmlElement("out_app_flag")]
		public string OutAppFlag
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

		[XmlElement("person_id")]
		public string PersonId
		{
			get;
			set;
		}
	}
}
