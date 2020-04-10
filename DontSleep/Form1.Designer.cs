namespace DontSleep
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.MainTimer = new System.Windows.Forms.Timer(this.components);
			this.IntervalLabel = new System.Windows.Forms.Label();
			this.Interval = new System.Windows.Forms.TextBox();
			this.AutoStart = new System.Windows.Forms.CheckBox();
			this.StartButton = new System.Windows.Forms.Button();
			this.StopButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.LocationX = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.LocationY = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.Minimize = new System.Windows.Forms.CheckBox();
			this.Copyright = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// MainTimer
			// 
			this.MainTimer.Enabled = true;
			this.MainTimer.Interval = 300000;
			this.MainTimer.Tick += new System.EventHandler(this.OnMainTimerTick);
			// 
			// IntervalLabel
			// 
			this.IntervalLabel.AutoSize = true;
			this.IntervalLabel.Location = new System.Drawing.Point(36, 48);
			this.IntervalLabel.Name = "IntervalLabel";
			this.IntervalLabel.Size = new System.Drawing.Size(105, 30);
			this.IntervalLabel.TabIndex = 0;
			this.IntervalLabel.Text = "Interval";
			// 
			// Interval
			// 
			this.Interval.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Interval.Location = new System.Drawing.Point(147, 31);
			this.Interval.Name = "Interval";
			this.Interval.Size = new System.Drawing.Size(195, 66);
			this.Interval.TabIndex = 1;
			this.Interval.Text = "300";
			this.Interval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// AutoStart
			// 
			this.AutoStart.AutoSize = true;
			this.AutoStart.Checked = true;
			this.AutoStart.CheckState = System.Windows.Forms.CheckState.Checked;
			this.AutoStart.Location = new System.Drawing.Point(521, 182);
			this.AutoStart.Name = "AutoStart";
			this.AutoStart.Size = new System.Drawing.Size(150, 34);
			this.AutoStart.TabIndex = 2;
			this.AutoStart.Text = "AutoStart";
			this.AutoStart.UseVisualStyleBackColor = true;
			// 
			// StartButton
			// 
			this.StartButton.Location = new System.Drawing.Point(521, 222);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(208, 56);
			this.StartButton.TabIndex = 3;
			this.StartButton.Text = "Start";
			this.StartButton.UseVisualStyleBackColor = true;
			this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
			// 
			// StopButton
			// 
			this.StopButton.Location = new System.Drawing.Point(217, 222);
			this.StopButton.Name = "StopButton";
			this.StopButton.Size = new System.Drawing.Size(208, 56);
			this.StopButton.TabIndex = 4;
			this.StopButton.Text = "Stop";
			this.StopButton.UseVisualStyleBackColor = true;
			this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(26, 222);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(133, 56);
			this.ExitButton.TabIndex = 5;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(348, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 30);
			this.label1.TabIndex = 6;
			this.label1.Text = "seconds";
			// 
			// LocationX
			// 
			this.LocationX.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LocationX.Location = new System.Drawing.Point(624, 31);
			this.LocationX.Name = "LocationX";
			this.LocationX.Size = new System.Drawing.Size(105, 42);
			this.LocationX.TabIndex = 8;
			this.LocationX.Text = "300";
			this.LocationX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(579, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 30);
			this.label2.TabIndex = 7;
			this.label2.Text = "x";
			// 
			// LocationY
			// 
			this.LocationY.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LocationY.Location = new System.Drawing.Point(566, 92);
			this.LocationY.Name = "LocationY";
			this.LocationY.Size = new System.Drawing.Size(105, 42);
			this.LocationY.TabIndex = 10;
			this.LocationY.Text = "300";
			this.LocationY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(521, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 45);
			this.label3.TabIndex = 9;
			this.label3.Text = "y";
			// 
			// Minimize
			// 
			this.Minimize.AutoSize = true;
			this.Minimize.Checked = true;
			this.Minimize.CheckState = System.Windows.Forms.CheckState.Checked;
			this.Minimize.Location = new System.Drawing.Point(521, 149);
			this.Minimize.Name = "Minimize";
			this.Minimize.Size = new System.Drawing.Size(141, 34);
			this.Minimize.TabIndex = 11;
			this.Minimize.Text = "Minimize";
			this.Minimize.UseVisualStyleBackColor = true;
			// 
			// Copyright
			// 
			this.Copyright.AutoSize = true;
			this.Copyright.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Copyright.Location = new System.Drawing.Point(21, 281);
			this.Copyright.Name = "Copyright";
			this.Copyright.Size = new System.Drawing.Size(138, 35);
			this.Copyright.TabIndex = 12;
			this.Copyright.Text = "copyright";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(755, 309);
			this.Controls.Add(this.Copyright);
			this.Controls.Add(this.Minimize);
			this.Controls.Add(this.LocationY);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.LocationX);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.StopButton);
			this.Controls.Add(this.StartButton);
			this.Controls.Add(this.AutoStart);
			this.Controls.Add(this.Interval);
			this.Controls.Add(this.IntervalLabel);
			this.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "DontSleep";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer MainTimer;
		private System.Windows.Forms.Label IntervalLabel;
		private System.Windows.Forms.TextBox Interval;
		private System.Windows.Forms.CheckBox AutoStart;
		private System.Windows.Forms.Button StartButton;
		private System.Windows.Forms.Button StopButton;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox LocationX;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox LocationY;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox Minimize;
		private System.Windows.Forms.Label Copyright;
	}
}

