#define DEBUG
using System;
using System.Collections;
using System.Diagnostics;

namespace Jayrock.Json
{
	[Serializable]
	public sealed class JsonRecorder : JsonWriterBase
	{
		[Serializable]
		private sealed class JsonPlayer : JsonReaderBase
		{
			private int _index;

			private readonly JsonToken[] _tokens;

			public JsonPlayer(JsonToken[] tokens)
			{
				Debug.Assert(tokens != null);
				_tokens = tokens;
			}

			protected override JsonToken ReadTokenImpl()
			{
				return _tokens[++_index];
			}
		}

		private ArrayList _tokenList;

		private ArrayList TokenList
		{
			get
			{
				if (_tokenList == null)
				{
					_tokenList = new ArrayList();
				}
				return _tokenList;
			}
		}

		private void Write(JsonToken token)
		{
			TokenList.Add(token);
		}

		protected override void WriteStartObjectImpl()
		{
			Write(JsonToken.Object());
		}

		protected override void WriteEndObjectImpl()
		{
			Write(JsonToken.EndObject());
		}

		protected override void WriteMemberImpl(string name)
		{
			Write(JsonToken.Member(name));
		}

		protected override void WriteStartArrayImpl()
		{
			Write(JsonToken.Array());
		}

		protected override void WriteEndArrayImpl()
		{
			Write(JsonToken.EndArray());
		}

		protected override void WriteStringImpl(string value)
		{
			Write(JsonToken.String(value));
		}

		protected override void WriteNumberImpl(string value)
		{
			Write(JsonToken.Number(value));
		}

		protected override void WriteBooleanImpl(bool value)
		{
			Write(JsonToken.Boolean(value));
		}

		protected override void WriteNullImpl()
		{
			Write(JsonToken.Null());
		}

		public JsonReader CreatePlayer()
		{
			int num = (_tokenList != null) ? _tokenList.Count : 0;
			JsonToken[] array = new JsonToken[num + 2];
			if (num > 0)
			{
				_tokenList.CopyTo(array, 1);
			}
			array[0] = JsonToken.BOF();
			array[array.Length - 1] = JsonToken.EOF();
			return new JsonPlayer(array);
		}

		public void Playback(JsonWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			writer.WriteFromReader(CreatePlayer());
		}

		public static JsonRecorder Record(JsonReader reader)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			JsonRecorder jsonRecorder = new JsonRecorder();
			jsonRecorder.WriteFromReader(reader);
			return jsonRecorder;
		}
	}
}
