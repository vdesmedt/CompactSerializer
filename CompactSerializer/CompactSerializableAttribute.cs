using System;

namespace CompactSerializer
{
	[AttributeUsage (AttributeTargets.Class)]
	public class CompactSerializableAttribute : Attribute
	{
		public CompactSerializableAttribute (int messageLenght, byte [] header)
		{
			MessageLenght = messageLenght;
			Header = header;
		}

		public int MessageLenght { get; set; }
		public byte [] Header { get; set; }
	}
}