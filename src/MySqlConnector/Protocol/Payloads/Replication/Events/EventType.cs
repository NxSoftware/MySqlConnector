namespace MySqlConnector.Protocol.Payloads.Replication.Events
{
	public enum EventType
	{
		UnknownEvent = 0x00,

		StartEventV3 = 0x01,

		QueryEvent = 0x02,

		StopEvent = 0x03,

		RotateEvent = 0x04,

		IntvarEvent = 0x05,

		LoadEvent = 0x06,

		SlaveEvent = 0x07,

		CreateFileEvent = 0x08,

		AppendBlockEvent = 0x09,

		ExecLoadEvent = 0x0A,

		DeleteFileEvent = 0x0B,

		NewLoadEvent = 0x0C,

		RandEvent = 0x0D,

		UserVarEvent = 0x0E,

		FormatDescriptionEvent = 0x0F,

		XidEvent = 0x10,

		BeginLoadQueryEvent = 0x11,

		ExecuteLoadQueryEvent = 0x12,

		TableMapEvent = 0x13,

		WriteRowsEventv0 = 0x14,

		UpdateRowsEventv0 = 0x15,

		DeleteRowsEventv0 = 0x16,

		WriteRowsEventv1 = 0x17,

		UpdateRowsEventv1 = 0x18,

		DeleteRowsEventv1 = 0x19,

		IncidentEvent = 0x1A,

		HeartbeatEvent = 0x1B,

		IgnorableEvent = 0x1C,

		RowsQueryEvent = 0x1D,

		WriteRowsEventv2 = 0x1E,

		UpdateRowsEventv2 = 0x1F,

		DeleteRowsEventv2 = 0x20,

		GtidEvent = 0x21,

		AnonymousGtidEvent = 0x22,

		PreviousGtidsEvent = 0x23
	}
}
