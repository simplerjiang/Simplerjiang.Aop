using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoWelfareCodeSyncModel : AopObject
	{
		[XmlElement("alipay_user_id")]
		public string AlipayUserId
		{
			get;
			set;
		}

		[XmlElement("code")]
		public string Code
		{
			get;
			set;
		}

		[XmlElement("code_expire_date")]
		public string CodeExpireDate
		{
			get;
			set;
		}

		[XmlElement("code_num")]
		public long CodeNum
		{
			get;
			set;
		}

		[XmlElement("code_pic_url")]
		public string CodePicUrl
		{
			get;
			set;
		}

		[XmlElement("code_start_date")]
		public string CodeStartDate
		{
			get;
			set;
		}

		[XmlElement("code_status")]
		public string CodeStatus
		{
			get;
			set;
		}

		[XmlElement("code_status_date")]
		public string CodeStatusDate
		{
			get;
			set;
		}

		[XmlElement("code_type")]
		public string CodeType
		{
			get;
			set;
		}

		[XmlElement("extend_params")]
		public string ExtendParams
		{
			get;
			set;
		}

		[XmlElement("isv_code")]
		public string IsvCode
		{
			get;
			set;
		}

		[XmlElement("store_info")]
		public WelfareEcoStoreInfo StoreInfo
		{
			get;
			set;
		}

		[XmlElement("sync_date")]
		public string SyncDate
		{
			get;
			set;
		}

		[XmlElement("welfare_user_id")]
		public string WelfareUserId
		{
			get;
			set;
		}
	}
}
