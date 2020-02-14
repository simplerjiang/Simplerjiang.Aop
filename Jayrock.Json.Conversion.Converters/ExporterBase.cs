using System;

namespace Jayrock.Json.Conversion.Converters
{
	public abstract class ExporterBase : IExporter
	{
		private readonly Type _inputType;

		public Type InputType => _inputType;

		protected ExporterBase(Type inputType)
		{
			if (inputType == null)
			{
				throw new ArgumentNullException("inputType");
			}
			_inputType = inputType;
		}

		public virtual void Export(ExportContext context, object value, JsonWriter writer)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			if (JsonNull.LogicallyEquals(value))
			{
				writer.WriteNull();
			}
			else
			{
				ExportValue(context, value, writer);
			}
		}

		protected abstract void ExportValue(ExportContext context, object value, JsonWriter writer);
	}
}
