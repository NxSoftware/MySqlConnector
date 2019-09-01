namespace MySqlConnector.Protocol
{
	// From https://dev.mysql.com/doc/internals/en/com-binlog-dump.html
	internal enum BinlogFlags
	{
		/// <summary>
		/// If there is no more event to send a EOF_Packet instead of blocking the connection
		/// </summary>
		NonBlock = 1,
	}
}
