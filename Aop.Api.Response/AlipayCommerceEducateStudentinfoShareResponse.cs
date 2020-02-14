using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCommerceEducateStudentinfoShareResponse : AopResponse
	{
		[XmlElement("student_info_share_result")]
		public EduStudentInfoShareResult StudentInfoShareResult
		{
			get;
			set;
		}
	}
}
