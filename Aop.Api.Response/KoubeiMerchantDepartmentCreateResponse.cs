using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMerchantDepartmentCreateResponse : AopResponse
	{
		[XmlElement("dept_id")]
		public string DeptId
		{
			get;
			set;
		}
	}
}
