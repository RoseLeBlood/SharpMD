/*
 * Created by SharpDevelop.
 * User: annas
 * Date: 20.02.2017
 * Time: 11:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SharpMD
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip msmain;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openStreamToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem prefToolStripMenuItem;
		private System.Windows.Forms.StatusStrip stMain;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
		private System.Windows.Forms.ToolStripStatusLabel lblStatusInfo;
		private System.Windows.Forms.Button cmdStop;
		private System.Windows.Forms.Button cmdPre;
		private System.Windows.Forms.Button cmdPlayPause;
		private System.Windows.Forms.Button cmdBack;
		private System.Windows.Forms.TableLayoutPanel tblMain;
		private System.Windows.Forms.ListBox lstDb;
		private System.Windows.Forms.TableLayoutPanel tblControll;
		private System.Windows.Forms.TrackBar trPosition;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.msmain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openStreamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.prefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tblMain = new System.Windows.Forms.TableLayoutPanel();
			this.lstDb = new System.Windows.Forms.ListBox();
			this.tblControll = new System.Windows.Forms.TableLayoutPanel();
			this.cmdBack = new System.Windows.Forms.Button();
			this.cmdPlayPause = new System.Windows.Forms.Button();
			this.cmdPre = new System.Windows.Forms.Button();
			this.cmdStop = new System.Windows.Forms.Button();
			this.trPosition = new System.Windows.Forms.TrackBar();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblStatusInfo = new System.Windows.Forms.ToolStripStatusLabel();
			this.stMain = new System.Windows.Forms.StatusStrip();
			this.msmain.SuspendLayout();
			this.tblMain.SuspendLayout();
			this.tblControll.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trPosition)).BeginInit();
			this.stMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// msmain
			// 
			this.msmain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem,
			this.prefToolStripMenuItem});
			this.msmain.Location = new System.Drawing.Point(1, 1);
			this.msmain.Name = "msmain";
			this.msmain.Size = new System.Drawing.Size(584, 24);
			this.msmain.TabIndex = 1;
			this.msmain.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.openStreamToolStripMenuItem,
			this.toolStripMenuItem1,
			this.quitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openStreamToolStripMenuItem
			// 
			this.openStreamToolStripMenuItem.Name = "openStreamToolStripMenuItem";
			this.openStreamToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.openStreamToolStripMenuItem.Text = "Open Stream";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.quitToolStripMenuItem.Text = "Quit";
			// 
			// prefToolStripMenuItem
			// 
			this.prefToolStripMenuItem.Name = "prefToolStripMenuItem";
			this.prefToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.prefToolStripMenuItem.Text = "Pref";
			// 
			// tblMain
			// 
			this.tblMain.BackColor = System.Drawing.SystemColors.Control;
			this.tblMain.ColumnCount = 1;
			this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tblMain.Controls.Add(this.lstDb, 0, 0);
			this.tblMain.Controls.Add(this.tblControll, 0, 1);
			this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tblMain.Location = new System.Drawing.Point(1, 25);
			this.tblMain.Name = "tblMain";
			this.tblMain.RowCount = 2;
			this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
			this.tblMain.Size = new System.Drawing.Size(584, 192);
			this.tblMain.TabIndex = 3;
			// 
			// lstDb
			// 
			this.lstDb.BackColor = System.Drawing.SystemColors.Window;
			this.lstDb.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstDb.FormattingEnabled = true;
			this.lstDb.Location = new System.Drawing.Point(3, 3);
			this.lstDb.Name = "lstDb";
			this.lstDb.Size = new System.Drawing.Size(578, 150);
			this.lstDb.TabIndex = 0;
			// 
			// tblControll
			// 
			this.tblControll.BackColor = System.Drawing.SystemColors.Control;
			this.tblControll.ColumnCount = 5;
			this.tblControll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tblControll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tblControll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tblControll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tblControll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tblControll.Controls.Add(this.cmdBack, 0, 0);
			this.tblControll.Controls.Add(this.cmdPlayPause, 1, 0);
			this.tblControll.Controls.Add(this.cmdPre, 2, 0);
			this.tblControll.Controls.Add(this.cmdStop, 3, 0);
			this.tblControll.Controls.Add(this.trPosition, 4, 0);
			this.tblControll.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tblControll.Location = new System.Drawing.Point(3, 159);
			this.tblControll.Name = "tblControll";
			this.tblControll.RowCount = 1;
			this.tblControll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tblControll.Size = new System.Drawing.Size(578, 30);
			this.tblControll.TabIndex = 1;
			// 
			// cmdBack
			// 
			this.cmdBack.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmdBack.Location = new System.Drawing.Point(3, 3);
			this.cmdBack.Name = "cmdBack";
			this.cmdBack.Size = new System.Drawing.Size(69, 24);
			this.cmdBack.TabIndex = 0;
			this.cmdBack.Text = "|<";
			this.cmdBack.UseVisualStyleBackColor = true;
			// 
			// cmdPlayPause
			// 
			this.cmdPlayPause.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmdPlayPause.Location = new System.Drawing.Point(78, 3);
			this.cmdPlayPause.Name = "cmdPlayPause";
			this.cmdPlayPause.Size = new System.Drawing.Size(69, 24);
			this.cmdPlayPause.TabIndex = 1;
			this.cmdPlayPause.Text = "|>";
			this.cmdPlayPause.UseVisualStyleBackColor = true;
			// 
			// cmdPre
			// 
			this.cmdPre.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmdPre.Location = new System.Drawing.Point(153, 3);
			this.cmdPre.Name = "cmdPre";
			this.cmdPre.Size = new System.Drawing.Size(69, 24);
			this.cmdPre.TabIndex = 2;
			this.cmdPre.Text = ">|";
			this.cmdPre.UseVisualStyleBackColor = true;
			// 
			// cmdStop
			// 
			this.cmdStop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmdStop.Location = new System.Drawing.Point(228, 3);
			this.cmdStop.Name = "cmdStop";
			this.cmdStop.Size = new System.Drawing.Size(69, 24);
			this.cmdStop.TabIndex = 3;
			this.cmdStop.Text = "[ ]";
			this.cmdStop.UseVisualStyleBackColor = true;
			// 
			// trPosition
			// 
			this.trPosition.Dock = System.Windows.Forms.DockStyle.Fill;
			this.trPosition.Location = new System.Drawing.Point(303, 3);
			this.trPosition.Name = "trPosition";
			this.trPosition.Size = new System.Drawing.Size(272, 24);
			this.trPosition.TabIndex = 4;
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(42, 17);
			this.lblStatus.Text = "Status:";
			this.lblStatus.Click += new System.EventHandler(this.ToolStripStatusLabel1Click);
			// 
			// lblStatusInfo
			// 
			this.lblStatusInfo.Name = "lblStatusInfo";
			this.lblStatusInfo.Size = new System.Drawing.Size(77, 17);
			this.lblStatusInfo.Text = "Dissconected";
			// 
			// stMain
			// 
			this.stMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.lblStatus,
			this.lblStatusInfo});
			this.stMain.Location = new System.Drawing.Point(1, 217);
			this.stMain.Name = "stMain";
			this.stMain.Size = new System.Drawing.Size(584, 22);
			this.stMain.TabIndex = 2;
			this.stMain.Text = "statusStrip1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(586, 240);
			this.Controls.Add(this.tblMain);
			this.Controls.Add(this.stMain);
			this.Controls.Add(this.msmain);
			this.DoubleBuffered = true;
			this.MainMenuStrip = this.msmain;
			this.Name = "MainForm";
			this.Padding = new System.Windows.Forms.Padding(1);
			this.Text = "SharpMD";
			this.msmain.ResumeLayout(false);
			this.msmain.PerformLayout();
			this.tblMain.ResumeLayout(false);
			this.tblControll.ResumeLayout(false);
			this.tblControll.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trPosition)).EndInit();
			this.stMain.ResumeLayout(false);
			this.stMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
