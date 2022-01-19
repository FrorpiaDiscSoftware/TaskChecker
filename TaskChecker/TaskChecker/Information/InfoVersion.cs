namespace TaskChecker.Information
{
	/// <summary>
	/// バージョン情報クラス
	/// </summary>
	public class InfoVersion
	{
		private static readonly string APP_NAME     = "TaskChecker";//アプリケーション名
		private static readonly byte[] VERSION      = {0,0,1};      //バージョン番号
		private static readonly string VERSION_TYPE = "a";          //バージョンステータス文字
		//-----------------------------------------------------------------------------
		public string appName       => APP_NAME;                                               //アプリケーション名
		public byte   majorVersion  => VERSION[0];                                             //メジャーバージョン番号
		public byte   minorVersion  => VERSION[1];                                             //マイナーバージョン番号
		public byte   buildVersion  => VERSION[2];                                             //ビルドバージョン番号
		public string versionType   => VERSION_TYPE;                                           //バージョンステータス文字
		public string formatVersion => $"v{VERSION[0]}.{VERSION[1]}{VERSION[2]}{VERSION_TYPE}";//フォーマットされたバージョン番号文字列
		//-----------------------------------------------------------------------------
	}
}
