using System;
using MySqlConnector.Protocol.Serialization;

namespace MySqlConnector.Protocol.Payloads.Replication.Events
{
	internal sealed class EventHeader
	{
		public int Timestamp { get; }
		public EventType EventType { get; }
		public int ServerId { get; }
		public int EventSize { get; }
		public int Position { get; }
		public EventFlags Flags { get; }

		public static EventHeader Create(ReadOnlySpan<byte> span)
		{
			var reader = new ByteArrayReader(span);
			reader.ReadByte(); // skip 0x00 OK byte
			var timestamp = reader.ReadInt32();
			var eventType = (EventType)reader.ReadByte();
			var serverId = reader.ReadInt32();
			var eventSize = reader.ReadInt32();
			var position = reader.ReadInt32();
			var flags = (EventFlags)reader.ReadInt16();

			return new EventHeader(timestamp, eventType, serverId, eventSize, position, flags);
		}

		private EventHeader(
			int timestamp,
			EventType eventType,
			int serverId,
			int eventSize,
			int position,
			EventFlags flags)
		{
			Timestamp = timestamp;
			EventType = eventType;
			ServerId = serverId;
			EventSize = eventSize;
			Position = position;
			Flags = flags;
		}
	}
}
