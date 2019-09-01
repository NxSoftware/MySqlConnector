using MySqlConnector.Protocol.Serialization;

namespace MySqlConnector.Protocol.Payloads.Replication
{
	internal static class StartBinlogNetworkStream
	{
		public static PayloadData Create(string filename)
		{
			var writer = new ByteBufferWriter();
			var position = 4;
			var flags = (ushort)BinlogFlags.NonBlock;
			var serverId = 10;

			writer.Write((byte) CommandKind.BinlogDump);
			writer.Write(position);
			writer.Write(flags);
			writer.Write(serverId);
			writer.Write(filename);

			return writer.ToPayloadData();
		}
	}
}
