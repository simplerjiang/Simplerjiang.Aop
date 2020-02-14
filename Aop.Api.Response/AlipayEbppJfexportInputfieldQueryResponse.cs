using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppJfexportInputfieldQueryResponse : AopResponse
	{
		[XmlArray("input_fields")]
		[XmlArrayItem("j_f_export_input_field_model")]
		public List<JFExportInputFieldModel> InputFields
		{
			get;
			set;
		}
	}
}
