using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SpAccountInfo : AopObject
	{
		[XmlElement("account_inst_name")]
		public string AccountInstName
		{
			get;
			set;
		}

		[XmlElement("account_name")]
		public string AccountName
		{
			get;
			set;
		}

		[XmlElement("sp_account_no")]
		public string SpAccountNo
		{
			get;
			set;
		}
	}
}
