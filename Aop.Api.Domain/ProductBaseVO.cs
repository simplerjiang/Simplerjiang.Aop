using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ProductBaseVO : AopObject
	{
		[XmlElement("biz_status")]
		public string BizStatus
		{
			get;
			set;
		}

		[XmlElement("is_combinate")]
		public string IsCombinate
		{
			get;
			set;
		}

		[XmlElement("prod_env")]
		public string ProdEnv
		{
			get;
			set;
		}

		[XmlElement("prod_name")]
		public string ProdName
		{
			get;
			set;
		}

		[XmlElement("prod_template_code")]
		public string ProdTemplateCode
		{
			get;
			set;
		}

		[XmlElement("prod_template_version")]
		public string ProdTemplateVersion
		{
			get;
			set;
		}

		[XmlElement("prod_type")]
		public string ProdType
		{
			get;
			set;
		}

		[XmlElement("prod_version")]
		public string ProdVersion
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}

		[XmlElement("std_prod_code")]
		public string StdProdCode
		{
			get;
			set;
		}

		[XmlElement("std_prod_version")]
		public string StdProdVersion
		{
			get;
			set;
		}
	}
}
