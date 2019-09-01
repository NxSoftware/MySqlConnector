using System;

namespace MySqlConnector.Protocol.Payloads.Replication.Events
{
	[Flags]
	public enum EventFlags
	{
		BinlogInUse = 0x0001,

		ForcedRotate = 0x0002,

		ThreadSpecific = 0x0004,

		SuppressUse = 0x0008,

		UpdateTableMapVersion = 0x0010,

		Artificial = 0x0020,

		RelayLog = 0x0040,

		Ignorable = 0x0080,

		NoFilter = 0x0100,

		MtsIsolate = 0x0200
	}
}
