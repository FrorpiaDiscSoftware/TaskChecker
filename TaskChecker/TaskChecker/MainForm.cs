using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskChecker.Information;

namespace TaskChecker
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			Text = $"{Info.version.appName} {Info.version.formatVersion}";//ウィンドウタイトルを設定。
		}
	}
}