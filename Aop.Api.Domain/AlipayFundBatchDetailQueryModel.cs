using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayFundBatchDetailQueryModel : AopObject
	{
		[XmlElement("batch_no")]
		public string BatchNo
		{
			get;
			set;
		}

		[XmlElement("biz_code")]
		public string BizCode
		{
			get;
			set;
		}

		[XmlElement("biz_scene")]
		public string BizScene
		{
			get;
			set;
		}

		[XmlElement("detail_no")]
		public string DetailNo
		{
			get;
			set;
		}

		[XmlElement("detail_status")]
		public string DetailStatus
		{
			get;
			set;
		}

		[XmlElement("page_num")]
		public long PageNum
		{
			get;
			set;
		}

		[XmlElement("payee_account")]
		public string PayeeAccount
		{
			get;
			set;
		}

		[XmlElement("sign_principal")]
		public string SignPrincipal
		{
			get;
			set;
		}
	}
}
