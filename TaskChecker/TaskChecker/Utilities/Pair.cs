using System;

namespace TaskChecker
{
	/// <summary>
	/// 汎用ペアデータ格納用データクラス
	/// </summary>
	/// <typeparam name="FirstT" >１番目とする要素の型(なんでもOK)</typeparam>
	/// <typeparam name="SecondT">２番目とする要素の型(なんでもOK)</typeparam>
	[Serializable]
	public class Pair<FirstT,SecondT>
	{
		public FirstT  first; //1番目の要素
		public SecondT second;//2番目の要素
		//-----------------------------------------------------------------------------
        
        
		//～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～
		//↓システム関連

		/// <summary>
		/// コンストラクタ(引数なし)
		/// </summary>
		public Pair()
		{
			first  = default;
			second = default;
		}
        
		/// <summary>
		/// コンストラクタ(T1,T2)
		/// </summary>
		/// <param name="pFirst" >１番目とする値の初期値</param>
		/// <param name="pSecond">２番目とする値の初期値</param>
		public Pair( FirstT pFirst , SecondT pSecond )
		{
			first  = pFirst;
			second = pSecond;
		}
	}
}