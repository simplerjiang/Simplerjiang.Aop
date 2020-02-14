#define DEBUG
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;

namespace Jayrock.Json.Conversion.Converters
{
	public sealed class ComponentExporter : ExporterBase
	{
		private sealed class ObjectReferenceTracker
		{
			private ArrayList _stack = new ArrayList(6);

			public void PushNew(object value)
			{
				Debug.Assert(value != null);
				Debug.Assert(value.GetType().IsClass);
				for (int num = _stack.Count - 1; num >= 0; num--)
				{
					if (_stack[num] == value)
					{
						throw new JsonException($"{typeof(ComponentExporter).FullName} does not support export of an object graph containing circular references. A value of type {value.GetType().FullName} has already been exported.");
					}
				}
				_stack.Add(value);
			}

			public void Pop(object value)
			{
				int num = _stack.Count - 1;
				Debug.Assert(num >= 0);
				Debug.Assert(_stack[num] == value);
				_stack.RemoveAt(num);
			}
		}

		private readonly PropertyDescriptorCollection _properties;

		public ComponentExporter(Type inputType)
			: this(inputType, (ICustomTypeDescriptor)null)
		{
		}

		public ComponentExporter(Type inputType, ICustomTypeDescriptor typeDescriptor)
			: this(inputType, (typeDescriptor != null) ? typeDescriptor.GetProperties() : new CustomTypeDescriptor(inputType).GetProperties())
		{
		}

		private ComponentExporter(Type inputType, PropertyDescriptorCollection properties)
			: base(inputType)
		{
			Debug.Assert(properties != null);
			_properties = properties;
		}

		protected override void ExportValue(ExportContext context, object value, JsonWriter writer)
		{
			Debug.Assert(context != null);
			Debug.Assert(value != null);
			Debug.Assert(writer != null);
			if (_properties.Count == 0)
			{
				writer.WriteString(value.ToString());
				return;
			}
			ObjectReferenceTracker objectReferenceTracker = null;
			try
			{
				writer.WriteStartObject();
				foreach (PropertyDescriptor property in _properties)
				{
					object value2 = property.GetValue(value);
					if (!JsonNull.LogicallyEquals(value2))
					{
						writer.WriteMember(property.Name);
						if (objectReferenceTracker == null)
						{
							objectReferenceTracker = TrackObject(context, value);
						}
						context.Export(value2, writer);
					}
				}
				writer.WriteEndObject();
			}
			finally
			{
				objectReferenceTracker?.Pop(value);
			}
		}

		private static ObjectReferenceTracker TrackObject(ExportContext context, object value)
		{
			Debug.Assert(context != null);
			Debug.Assert(value != null);
			Type typeFromHandle = typeof(ComponentExporter);
			ObjectReferenceTracker objectReferenceTracker = (ObjectReferenceTracker)context.Items[typeFromHandle];
			if (objectReferenceTracker == null)
			{
				objectReferenceTracker = new ObjectReferenceTracker();
				context.Items.Add(typeFromHandle, objectReferenceTracker);
			}
			objectReferenceTracker.PushNew(value);
			return objectReferenceTracker;
		}
	}
}
