namespace SocialTimer
{
    partial class Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.タイマーTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新規タイマーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.既存のタイマーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.タイマーTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(210, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // タイマーTToolStripMenuItem
            // 
            this.タイマーTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新規タイマーToolStripMenuItem,
            this.既存のタイマーToolStripMenuItem});
            this.タイマーTToolStripMenuItem.Name = "タイマーTToolStripMenuItem";
            this.タイマーTToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.タイマーTToolStripMenuItem.Text = "タイマー(&T)";
            // 
            // 新規タイマーToolStripMenuItem
            // 
            this.新規タイマーToolStripMenuItem.Name = "新規タイマーToolStripMenuItem";
            this.新規タイマーToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.新規タイマーToolStripMenuItem.Text = "新規タイマー";
            this.新規タイマーToolStripMenuItem.Click += new System.EventHandler(this.新規タイマーToolStripMenuItem_Click);
            // 
            // 既存のタイマーToolStripMenuItem
            // 
            this.既存のタイマーToolStripMenuItem.Name = "既存のタイマーToolStripMenuItem";
            this.既存のタイマーToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.既存のタイマーToolStripMenuItem.Text = "既存のタイマー";
            this.既存のタイマーToolStripMenuItem.Click += new System.EventHandler(this.既存のタイマーToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 41);
            this.Controls.Add(this.menuStrip1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::SocialTimer.Properties.Settings.Default, "DafaultLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::SocialTimer.Properties.Settings.Default.DafaultLocation;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "SocialTimer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem タイマーTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新規タイマーToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 既存のタイマーToolStripMenuItem;

    }
}

