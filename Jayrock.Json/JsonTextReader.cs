#define DEBUG
using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;

namespace Jayrock.Json
{
	public sealed class JsonTextReader : JsonReaderBase
	{
		private delegate JsonToken Continuation();

		private BufferedCharReader _reader;

		private Stack _stack;

		private Continuation _methodParse;

		private Continuation _methodParseArrayFirst;

		private Continuation _methodParseArrayNext;

		private Continuation _methodParseObjectMember;

		private Continuation _methodParseObjectMemberValue;

		private Continuation _methodParseNextMember;

		private Continuation ParseMethod
		{
			get
			{
				if (_methodParse == null)
				{
					_methodParse = Parse;
				}
				return _methodParse;
			}
		}

		private Continuation ParseArrayFirstMethod
		{
			get
			{
				if (_methodParseArrayFirst == null)
				{
					_methodParseArrayFirst = ParseArrayFirst;
				}
				return _methodParseArrayFirst;
			}
		}

		private Continuation ParseArrayNextMethod
		{
			get
			{
				if (_methodParseArrayNext == null)
				{
					_methodParseArrayNext = ParseArrayNext;
				}
				return _methodParseArrayNext;
			}
		}

		private Continuation ParseObjectMemberMethod
		{
			get
			{
				if (_methodParseObjectMember == null)
				{
					_methodParseObjectMember = ParseObjectMember;
				}
				return _methodParseObjectMember;
			}
		}

		private Continuation ParseObjectMemberValueMethod
		{
			get
			{
				if (_methodParseObjectMemberValue == null)
				{
					_methodParseObjectMemberValue = ParseObjectMemberValue;
				}
				return _methodParseObjectMemberValue;
			}
		}

		private Continuation ParseNextMemberMethod
		{
			get
			{
				if (_methodParseNextMember == null)
				{
					_methodParseNextMember = ParseNextMember;
				}
				return _methodParseNextMember;
			}
		}

		public JsonTextReader(TextReader reader)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			_reader = new BufferedCharReader(reader);
			Push(ParseMethod);
		}

		protected override JsonToken ReadTokenImpl()
		{
			if (_stack == null)
			{
				return JsonToken.EOF();
			}
			if (_stack.Count == 0)
			{
				_stack = null;
				_reader = null;
				return JsonToken.EOF();
			}
			return Pop()();
		}

		private JsonToken Parse()
		{
			char c = NextClean();
			if (c == '"' || c == '\'')
			{
				return Yield(JsonToken.String(NextString(c)));
			}
			switch (c)
			{
			case '{':
				_reader.Back();
				return ParseObject();
			case '[':
				_reader.Back();
				return ParseArray();
			default:
			{
				StringBuilder stringBuilder = new StringBuilder();
				char c2 = c;
				while (c >= ' ' && ",:]}/\\\"[{;=#".IndexOf(c) < 0)
				{
					stringBuilder.Append(c);
					c = _reader.Next();
				}
				_reader.Back();
				string text = stringBuilder.ToString().Trim();
				if (text.Length == 0)
				{
					throw new JsonException("Missing value.");
				}
				if (text == "true" || text == "false")
				{
					return Yield(JsonToken.Boolean(text == "true"));
				}
				if (text == "null")
				{
					return Yield(JsonToken.Null());
				}
				if ((c2 >= '0' && c2 <= '9') || c2 == '.' || c2 == '-' || c2 == '+')
				{
					if (!double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out double _))
					{
						throw new JsonException($"The text '{text}' has the incorrect syntax for a number.");
					}
					return Yield(JsonToken.Number(text));
				}
				return Yield(JsonToken.String(text));
			}
			}
		}

		private JsonToken ParseArray()
		{
			if (NextClean() != '[')
			{
				throw new JsonException("An array must start with '['.");
			}
			return Yield(JsonToken.Array(), ParseArrayFirstMethod);
		}

		private JsonToken ParseArrayFirst()
		{
			if (NextClean() == ']')
			{
				return Yield(JsonToken.EndArray());
			}
			_reader.Back();
			Push(ParseArrayNextMethod);
			return Parse();
		}

		private JsonToken ParseArrayNext()
		{
			switch (NextClean())
			{
			case ',':
			case ';':
				if (NextClean() == ']')
				{
					return Yield(JsonToken.EndArray());
				}
				_reader.Back();
				Push(ParseArrayNextMethod);
				return Parse();
			case ']':
				return Yield(JsonToken.EndArray());
			default:
				throw new JsonException("Expected a ',' or ']'.");
			}
		}

		private JsonToken ParseObject()
		{
			if (NextClean() != '{')
			{
				throw new JsonException("An object must begin with '{'.");
			}
			return Yield(JsonToken.Object(), ParseObjectMemberMethod);
		}

		private JsonToken ParseObjectMember()
		{
			switch (NextClean())
			{
			case '}':
				return Yield(JsonToken.EndObject());
			case '\0':
				throw new JsonException("An object must end with '}'.");
			default:
			{
				_reader.Back();
				string text = Parse().Text;
				return Yield(JsonToken.Member(text), ParseObjectMemberValueMethod);
			}
			}
		}

		private JsonToken ParseObjectMemberValue()
		{
			switch (NextClean())
			{
			case '=':
				if (_reader.Next() != '>')
				{
					_reader.Back();
				}
				break;
			default:
				throw new JsonException("Expected a ':' after a key.");
			case ':':
				break;
			}
			Push(ParseNextMemberMethod);
			return Parse();
		}

		private JsonToken ParseNextMember()
		{
			switch (NextClean())
			{
			case ',':
			case ';':
			{
				if (NextClean() == '}')
				{
					return Yield(JsonToken.EndObject());
				}
				_reader.Back();
				string text = Parse().Text;
				return Yield(JsonToken.Member(text), ParseObjectMemberValueMethod);
			}
			case '}':
				return Yield(JsonToken.EndObject());
			default:
				throw new JsonException("Expected a ',' or '}'.");
			}
		}

		private JsonToken Yield(JsonToken token)
		{
			return Yield(token, null);
		}

		private JsonToken Yield(JsonToken token, Continuation continuation)
		{
			if (continuation != null)
			{
				Push(continuation);
			}
			return token;
		}

		private char NextClean()
		{
			Debug.Assert(_reader != null);
			char c;
			while (true)
			{
				c = _reader.Next();
				if (c == '/')
				{
					char c2 = _reader.Next();
					if (c2 != '*')
					{
						if (c2 == '/')
						{
							do
							{
								c = _reader.Next();
							}
							while (c != '\n' && c != '\r' && c != 0);
							continue;
						}
						_reader.Back();
						return '/';
					}
					while (true)
					{
						switch (_reader.Next())
						{
						case '\0':
							throw new JsonException("Unclosed comment.");
						case '*':
							break;
						default:
							continue;
						}
						if (_reader.Next() == '/')
						{
							break;
						}
						_reader.Back();
					}
				}
				else if (c == '#')
				{
					do
					{
						c = _reader.Next();
					}
					while (c != '\n' && c != '\r' && c != 0);
				}
				else if (c == '\0' || c > ' ')
				{
					break;
				}
			}
			return c;
		}

		private string NextString(char quote)
		{
			try
			{
				return JsonString.Dequote(_reader, quote);
			}
			catch (FormatException ex)
			{
				throw new JsonException(ex.Message, ex);
			}
		}

		private void Push(Continuation continuation)
		{
			Debug.Assert(continuation != null);
			if (_stack == null)
			{
				_stack = new Stack(6);
			}
			_stack.Push(continuation);
		}

		private Continuation Pop()
		{
			Debug.Assert(_stack != null);
			return (Continuation)_stack.Pop();
		}
	}
}
