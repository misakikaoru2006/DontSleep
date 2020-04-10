using System;
using System.Windows.Forms;

namespace DontSleep
{
	public partial class Form1 : Form
	{
		int DefaultInterval = 300 * 1000;
		//int DefaultInterval = 1* 1000;
		public Form1()
		{
			InitializeComponent();
		}

		bool IsFirst = true;

		private void OnMainTimerTick(object sender, EventArgs e)
		{
			//マウスポインタの位置を取得する
			//X座標を取得する
			int x = System.Windows.Forms.Cursor.Position.X;
			//Y座標を取得する
			int y = System.Windows.Forms.Cursor.Position.Y;

			if (IsFirst)
			{
				System.Windows.Forms.Cursor.Position = new System.Drawing.Point(x, y + 1);
				IsFirst = false;
			}
			else
			{
				System.Windows.Forms.Cursor.Position = new System.Drawing.Point(x, y - 1);
				IsFirst = true;
			}
			LocationX.Text = x.ToString();
			LocationY.Text = y.ToString();
		}

		private void StartButton_Click(object sender, EventArgs e)
		{
			StartButton.Enabled = false;
			StopButton.Enabled = true;
			if (int.TryParse(Interval.Text, out DefaultInterval)) {
				MainTimer.Interval = DefaultInterval * 1000;
			};
			MainTimer.Start();
			if (Minimize.Checked)
				this.WindowState = FormWindowState.Minimized;
		}

		private void StopButton_Click(object sender, EventArgs e)
		{
			StopButton.Enabled = false;
			StartButton.Enabled = true;
			MainTimer.Stop();
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			MainTimer.Stop();
			this.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//this.ShowInTaskbar = false;
			Copyright.Text = "(C)2020 MISAKI Kaoru, Icon by icons8 https://icons8.jp/icons/set/pointer";

			Interval.Text =( DefaultInterval / 1000).ToString();
			StopButton.Enabled = false;

			if (AutoStart.Checked)
				StartButton_Click(this, EventArgs.Empty);
		}
	}
}
