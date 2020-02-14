using System.IO;

namespace Jayrock.Json
{
	public class JsonTextWriter : JsonWriterBase
	{
		private readonly TextWriter _writer;

		private bool _prettyPrint;

		private bool _newLine;

		private int _indent;

		private char[] _indentBuffer;

		public bool PrettyPrint
		{
			get
			{
				return _prettyPrint;
			}
			set
			{
				_prettyPrint = value;
			}
		}

		protected TextWriter InnerWriter => _writer;

		public JsonTextWriter()
			: this(null)
		{
		}

		public JsonTextWriter(TextWriter writer)
		{
			_writer = ((writer != null) ? writer : new StringWriter());
		}

		public override void Flush()
		{
			_writer.Flush();
		}

		public override string ToString()
		{
			StringWriter stringWriter = _writer as StringWriter;
			return (stringWriter != null) ? stringWriter.ToString() : base.ToString();
		}

		protected override void WriteStartObjectImpl()
		{
			OnWritingValue();
			WriteDelimiter('{');
			PrettySpace();
		}

		protected override void WriteEndObjectImpl()
		{
			if (Index > 0)
			{
				PrettyLine();
				_indent--;
			}
			WriteDelimiter('}');
		}

		protected override void WriteMemberImpl(string name)
		{
			if (Index > 0)
			{
				WriteDelimiter(',');
				PrettyLine();
			}
			else
			{
				PrettyLine();
				_indent++;
			}
			WriteStringImpl(name);
			PrettySpace();
			WriteDelimiter(':');
			PrettySpace();
		}

		protected override void WriteStringImpl(string value)
		{
			WriteScalar(JsonString.Enquote(value));
		}

		protected override void WriteNumberImpl(string value)
		{
			WriteScalar(value);
		}

		protected override void WriteBooleanImpl(bool value)
		{
			WriteScalar(value ? "true" : "false");
		}

		protected override void WriteNullImpl()
		{
			WriteScalar("null");
		}

		protected override void WriteStartArrayImpl()
		{
			OnWritingValue();
			WriteDelimiter('[');
			PrettySpace();
		}

		protected override void WriteEndArrayImpl()
		{
			if (IsNonEmptyArray())
			{
				PrettySpace();
			}
			WriteDelimiter(']');
		}

		private void WriteScalar(string text)
		{
			OnWritingValue();
			PrettyIndent();
			_writer.Write(text);
		}

		private bool IsNonEmptyArray()
		{
			return Bracket == JsonWriterBracket.Array && Index > 0;
		}

		private void OnWritingValue()
		{
			if (IsNonEmptyArray())
			{
				WriteDelimiter(',');
				PrettySpace();
			}
		}

		private void WriteDelimiter(char ch)
		{
			PrettyIndent();
			_writer.Write(ch);
		}

		private void PrettySpace()
		{
			if (_prettyPrint)
			{
				WriteDelimiter(' ');
			}
		}

		private void PrettyLine()
		{
			if (_prettyPrint)
			{
				_writer.WriteLine();
				_newLine = true;
			}
		}

		private void PrettyIndent()
		{
			if (!_prettyPrint || !_newLine)
			{
				return;
			}
			if (_indent > 0)
			{
				int num = _indent * 4;
				if (_indentBuffer == null || _indentBuffer.Length < num)
				{
					_indentBuffer = new string(' ', num * 4).ToCharArray();
				}
				_writer.Write(_indentBuffer, 0, num);
			}
			_newLine = false;
		}
	}
}
