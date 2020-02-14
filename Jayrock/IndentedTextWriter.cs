using System.Globalization;
using System.IO;
using System.Text;

namespace Jayrock
{
	public sealed class IndentedTextWriter : TextWriter
	{
		private TextWriter _writer;

		private int _level;

		private bool _tabsPending;

		private string _tab;

		public const string DefaultTabString = "    ";

		public override Encoding Encoding => _writer.Encoding;

		public override string NewLine
		{
			get
			{
				return _writer.NewLine;
			}
			set
			{
				_writer.NewLine = value;
			}
		}

		public int Indent
		{
			get
			{
				return _level;
			}
			set
			{
				_level = ((value >= 0) ? value : 0);
			}
		}

		public TextWriter InnerWriter => _writer;

		internal string TabString => _tab;

		public IndentedTextWriter(TextWriter writer)
			: this(writer, "    ")
		{
		}

		public IndentedTextWriter(TextWriter writer, string tabString)
			: base(CultureInfo.InvariantCulture)
		{
			_writer = writer;
			_tab = tabString;
			_level = 0;
			_tabsPending = false;
		}

		public override void Close()
		{
			_writer.Close();
		}

		public override void Flush()
		{
			_writer.Flush();
		}

		public override void Write(string s)
		{
			WritePendingTabs();
			_writer.Write(s);
		}

		public override void Write(bool value)
		{
			WritePendingTabs();
			_writer.Write(value);
		}

		public override void Write(char value)
		{
			WritePendingTabs();
			_writer.Write(value);
		}

		public override void Write(char[] buffer)
		{
			WritePendingTabs();
			_writer.Write(buffer);
		}

		public override void Write(char[] buffer, int index, int count)
		{
			WritePendingTabs();
			_writer.Write(buffer, index, count);
		}

		public override void Write(double value)
		{
			WritePendingTabs();
			_writer.Write(value);
		}

		public override void Write(float value)
		{
			WritePendingTabs();
			_writer.Write(value);
		}

		public override void Write(int value)
		{
			WritePendingTabs();
			_writer.Write(value);
		}

		public override void Write(long value)
		{
			WritePendingTabs();
			_writer.Write(value);
		}

		public override void Write(object value)
		{
			WritePendingTabs();
			_writer.Write(value);
		}

		public override void Write(string format, object arg0)
		{
			WritePendingTabs();
			_writer.Write(format, arg0);
		}

		public override void Write(string format, object arg0, object arg1)
		{
			WritePendingTabs();
			_writer.Write(format, arg0, arg1);
		}

		public override void Write(string format, params object[] arg)
		{
			WritePendingTabs();
			_writer.Write(format, arg);
		}

		public void WriteLineNoTabs(string s)
		{
			_writer.WriteLine(s);
		}

		public override void WriteLine(string s)
		{
			WritePendingTabs();
			_writer.WriteLine(s);
			_tabsPending = true;
		}

		public override void WriteLine()
		{
			WritePendingTabs();
			_writer.WriteLine();
			_tabsPending = true;
		}

		public override void WriteLine(bool value)
		{
			WritePendingTabs();
			_writer.WriteLine(value);
			_tabsPending = true;
		}

		public override void WriteLine(char value)
		{
			WritePendingTabs();
			_writer.WriteLine(value);
			_tabsPending = true;
		}

		public override void WriteLine(char[] buffer)
		{
			WritePendingTabs();
			_writer.WriteLine(buffer);
			_tabsPending = true;
		}

		public override void WriteLine(char[] buffer, int index, int count)
		{
			WritePendingTabs();
			_writer.WriteLine(buffer, index, count);
			_tabsPending = true;
		}

		public override void WriteLine(double value)
		{
			WritePendingTabs();
			_writer.WriteLine(value);
			_tabsPending = true;
		}

		public override void WriteLine(float value)
		{
			WritePendingTabs();
			_writer.WriteLine(value);
			_tabsPending = true;
		}

		public override void WriteLine(int value)
		{
			WritePendingTabs();
			_writer.WriteLine(value);
			_tabsPending = true;
		}

		public override void WriteLine(long value)
		{
			WritePendingTabs();
			_writer.WriteLine(value);
			_tabsPending = true;
		}

		public override void WriteLine(object value)
		{
			WritePendingTabs();
			_writer.WriteLine(value);
			_tabsPending = true;
		}

		public override void WriteLine(string format, object arg0)
		{
			WritePendingTabs();
			_writer.WriteLine(format, arg0);
			_tabsPending = true;
		}

		public override void WriteLine(string format, object arg0, object arg1)
		{
			WritePendingTabs();
			_writer.WriteLine(format, arg0, arg1);
			_tabsPending = true;
		}

		public override void WriteLine(string format, params object[] arg)
		{
			WritePendingTabs();
			_writer.WriteLine(format, arg);
			_tabsPending = true;
		}

		private void WritePendingTabs()
		{
			if (_tabsPending)
			{
				_tabsPending = false;
				for (int i = 0; i < _level; i++)
				{
					_writer.Write(_tab);
				}
			}
		}
	}
}
