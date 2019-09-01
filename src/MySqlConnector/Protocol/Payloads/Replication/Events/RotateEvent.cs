using System;
using System.Text;
using MySqlConnector.Protocol.Serialization;
using MySqlConnector.Utilities;

namespace MySqlConnector.Protocol.Payloads.Replication.Events
{
	internal sealed class RotateEvent
	{
		public ulong Position { get; }
		public string Filename { get; }

		public static RotateEvent Create(ref ByteArrayReader reader)
		{
			var position = reader.ReadFixedLengthUInt64(8);
			var filename = Encoding.UTF8.GetString(reader.ReadNullOrEofTerminatedByteString());

			return new RotateEvent(position, filename);
		}

		private RotateEvent(ulong position, string filename)
		{
			Position = position;
			Filename = filename;
		}
	}
}
