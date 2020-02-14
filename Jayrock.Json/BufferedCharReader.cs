#define DEBUG
using System;
using System.Diagnostics;
using System.IO;

namespace Jayrock.Json
{
	internal sealed class BufferedCharReader
	{
		private TextReader _reader;

		private char[] _buffer;

		private int _index;

		private int _end;

		private bool _backed;

		private char _backup;

		private int _bufferSize;

		public const char EOF = '\0';

		public BufferedCharReader(TextReader reader)
			: this(reader, 0)
		{
		}

		public BufferedCharReader(TextReader reader, int bufferSize)
		{
			Debug.Assert(reader != null);
			_reader = reader;
			_bufferSize = Math.Max(256, bufferSize);
		}

		public void Back()
		{
			Debug.Assert(!_backed);
			if (_index > 0)
			{
				_backup = _buffer[_index - 1];
				_backed = true;
			}
		}

		public bool More()
		{
			if (_index == _end)
			{
				if (_buffer == null)
				{
					_buffer = new char[_bufferSize];
				}
				_index = 0;
				_end = _reader.Read(_buffer, 0, _buffer.Length);
				if (_end == 0)
				{
					return false;
				}
			}
			return true;
		}

		public char Next()
		{
			if (_backed)
			{
				_backed = false;
				return _backup;
			}
			if (!More())
			{
				return '\0';
			}
			return _buffer[_index++];
		}
	}
}
