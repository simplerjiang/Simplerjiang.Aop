namespace Jayrock.Json
{
	public abstract class JsonReaderBase : JsonReader
	{
		private JsonToken _token;

		private int _depth;

		public sealed override JsonToken Token => _token;

		public sealed override int Depth => _depth;

		public JsonReaderBase()
		{
			_token = JsonToken.BOF();
		}

		public sealed override bool Read()
		{
			if (!base.EOF)
			{
				if (base.TokenClass == JsonTokenClass.EndObject || base.TokenClass == JsonTokenClass.EndArray)
				{
					_depth--;
				}
				_token = ReadTokenImpl();
				if (base.TokenClass == JsonTokenClass.Object || base.TokenClass == JsonTokenClass.Array)
				{
					_depth++;
				}
			}
			return !base.EOF;
		}

		protected abstract JsonToken ReadTokenImpl();
	}
}
