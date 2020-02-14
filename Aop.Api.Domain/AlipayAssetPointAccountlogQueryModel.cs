using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayAssetPointAccountlogQueryModel : AopObject
	{
		[XmlElement("account_date_begin")]
		public string AccountDateBegin
		{
			get;
			set;
		}

		[XmlElement("account_date_end")]
		public string AccountDateEnd
		{
			get;
			set;
		}

		[XmlElement("page_number")]
		public long PageNumber
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public long PageSize
		{
			get;
			set;
		}

		[XmlArray("sub_trans_code")]
		[XmlArrayItem("string")]
		public List<string> SubTransCode
		{
			get;
			set;
		}

		[XmlArray("trans_code")]
		[XmlArrayItem("string")]
		public List<string> TransCode
		{
			get;
			set;
		}

		[XmlElement("user_symbol")]
		public string UserSymbol
		{
			get;
			set;
		}

		[XmlElement("user_symbol_type")]
		public string UserSymbolType
		{
			get;
			set;
		}
	}
}
