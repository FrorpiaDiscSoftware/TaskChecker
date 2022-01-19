using System;
using System.Windows.Forms;

namespace TaskChecker.GuiControl
{
	/// <summary>
	/// ListItemとするコントロールを並べて配置する為の枠組みを提供するクラス
	/// </summary>
	/// <typeparam name="ListItemT">扱うListItemコントロール型</typeparam>
	public partial class ListItemContainer<ListItemT> : UserControl
		where ListItemT : UserControl
	{
		private Pair<ListItemT,ListItemContainer<ListItemT>> _containerData = new Pair<ListItemT,ListItemContainer<ListItemT>>();//SplitContainerに登録されているコントロールペア
		//-----------------------------------------------------------------------------
		public ListItemT                    item           { get => _containerData.first;  }//このContainerに登録されているリスト項目
		public ListItemContainer<ListItemT> next           { get => _containerData.second; }//次のListItemContainer
		public Orientation                  splitDirection { get => _container.Orientation; set => _container.Orientation = value; }//分割方向
		//-----------------------------------------------------------------------------
		
		
		//～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～
		//↓追加定義クラス関連
		
		/// <summary>
		/// 表示内容の一括設定データクラス
		/// </summary>
		public class Entity
		{
			/// <summary>
			/// このContainerに登録するリスト項目<br />
			/// ※不要な場合はnullにします。
			/// </summary>
			public ListItemT item = null;
			
			/// <summary>
			/// このContainerに登録する次のリスト項目コンテナー設定<br />
			/// ※不要な場合はnullにします。
			/// </summary>
			public Entity next = null;
		}
		
		
		//～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～
		//↓システム関連
		
		/// <summary>
		/// コンストラクタ(引数なし)
		/// </summary>
		public ListItemContainer()
		{
			InitializeComponent();
		}

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="pEntity">初期設定</param>
		public ListItemContainer( Entity pEntity )
		{
			InitializeComponent();
			Setup(pEntity);
		}
		
		
		//～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～
		//↓基本機能関連
		
		/// <summary>
		/// 表示内容の一括セットアップを行なう関数
		/// </summary>
		/// <param name="pEntity">全表示内容の設定</param>
		public void Setup( Entity pEntity )
		{
			if ( pEntity == null ) { return; }

			SetItem(pEntity.item);
			SetNext(pEntity.next);

			switch( _container.Orientation )
			{
				case Orientation.Horizontal:
					_container.SplitterDistance = Size.Height / 2;
					break;
				case Orientation.Vertical:
					_container.SplitterDistance = Size.Width / 2;
					break;
			}
		}

		/// <summary>
		/// アタッチしているコンポーネントをすべて削除する関数
		/// </summary>
		public void Clear()
		{
			ClearItem();
			ClearNext();
		}

		/// <summary>
		/// アタッチしているメイン項目を削除する関数
		/// </summary>
		public void ClearItem()
		{
			_container.Panel1.Controls.Clear();
			_containerData.first = null;
			_container.Panel1Collapsed = true;
		}

		/// <summary>
		/// アタッチしている次以降の項目を削除する関数
		/// </summary>
		public void ClearNext()
		{
			_container.Panel2.Controls.Clear();
			_containerData.second = null;
			_container.Panel2Collapsed = true;
		}
		
		
		//～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～～
		//↓アクセサ関連

		/// <summary>
		/// 指定した項目をメイン項目として設定する関数
		/// </summary>
		/// <param name="pItem">設定する項目</param>
		public void SetItem( ListItemT pItem )
		{
			ClearItem();
			
			if ( pItem == null ) { return; }

			_container.Panel1Collapsed = false;
			
			_containerData.first = pItem;
			_container.Panel1.Controls.Add(_containerData.first);
			_containerData.first.Dock = DockStyle.Fill;
		}

		/// <summary>
		/// 指定した設定を基に次の項目を設定する関数
		/// </summary>
		/// <param name="pEntity">項目コンテナー設定</param>
		public void SetNext( Entity pEntity )
		{
			ClearNext();
			
			if ( pEntity == null ) { return; }

			_container.Panel2Collapsed = false;
			
			_containerData.second = new ListItemContainer<ListItemT>();
			_container.Panel2.Controls.Add(_containerData.second);
			_containerData.second.Dock = DockStyle.Fill;
			_containerData.second.Setup(pEntity);
		}

		/// <summary>
		/// 指定したListItemの枠組みを次の項目に設定(リンク)する関数
		/// </summary>
		/// <param name="pItemContainer">設定するListItemContainer</param>
		public void SetNext( ListItemContainer<ListItemT> pItemContainer )
		{
			ClearNext();
			
			if ( pItemContainer == null ) { return; }
			
			_container.Panel2Collapsed = false;
			
			_containerData.second = pItemContainer;
			_container.Panel2.Controls.Add(_containerData.second);
			_containerData.second.Dock = DockStyle.Fill;
		}

		/// <summary>
		/// 指定した項目を次の項目として設定する関数
		/// </summary>
		/// <param name="pItem">設定する項目</param>
		public void SetNextItem( ListItemT pItem )
		{
			Entity fNextEntity = null;
			//-------------------------------------------------------------
			
			ClearNext();
			
			if ( pItem == null ) { return; }
			
			fNextEntity = new Entity{ item = pItem };
			
			_containerData.second = new ListItemContainer<ListItemT>(fNextEntity);
			_container.Panel2.Controls.Add(_containerData.second);
			_containerData.second.Dock = DockStyle.Fill;
		}
	}
}