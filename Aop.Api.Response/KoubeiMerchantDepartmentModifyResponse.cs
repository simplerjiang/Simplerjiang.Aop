using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMerchantDepartmentModifyResponse : AopResponse
	{
		[XmlElement("dept_id")]
		public string DeptId
		{
			get;
			set;
		}
	}
}
