using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsProduct : AopObject
	{
		[XmlElement("coverages")]
		public InsProdCoverage Coverages
		{
			get;
			set;
		}

		[XmlElement("effect_date")]
		public string EffectDate
		{
			get;
			set;
		}

		[XmlElement("invalid_date")]
		public string InvalidDate
		{
			get;
			set;
		}

		[XmlElement("is_sp")]
		public bool IsSp
		{
			get;
			set;
		}

		[XmlArray("liabilities")]
		[XmlArrayItem("ins_liability")]
		public List<InsLiability> Liabilities
		{
			get;
			set;
		}

		[XmlElement("merchant")]
		public InsMerchant Merchant
		{
			get;
			set;
		}

		[XmlElement("prod_code")]
		public string ProdCode
		{
			get;
			set;
		}

		[XmlElement("prod_desc")]
		public string ProdDesc
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

		[XmlElement("prod_no")]
		public string ProdNo
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

		[XmlElement("real_premium")]
		public string RealPremium
		{
			get;
			set;
		}

		[XmlElement("reduce_premium")]
		public string ReducePremium
		{
			get;
			set;
		}

		[XmlArray("resources")]
		[XmlArrayItem("ins_prod_resource")]
		public List<InsProdResource> Resources
		{
			get;
			set;
		}

		[XmlElement("sales")]
		public long Sales
		{
			get;
			set;
		}

		[XmlElement("short_name")]
		public string ShortName
		{
			get;
			set;
		}

		[XmlElement("sp_code")]
		public string SpCode
		{
			get;
			set;
		}

		[XmlArray("tags")]
		[XmlArrayItem("ins_prod_tag")]
		public List<InsProdTag> Tags
		{
			get;
			set;
		}

		[XmlElement("total_premium")]
		public string TotalPremium
		{
			get;
			set;
		}
	}
}
